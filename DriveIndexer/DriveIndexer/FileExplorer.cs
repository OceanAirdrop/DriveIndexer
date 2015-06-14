using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DriveIndexer
{
    // Found this: How to: Iterate Through a Directory Tree
    // https://msdn.microsoft.com/en-GB/library/bb513869.aspx

    public static class FileExplorer
    {
        static System.Collections.Specialized.StringCollection log = new System.Collections.Specialized.StringCollection();

        static List<string> m_extensionWhiteList = new List<string>();

        public static void SetupExtensionWhiteList()
        {
            m_extensionWhiteList.Add(".cs");
            m_extensionWhiteList.Add(".cpp");
            m_extensionWhiteList.Add(".h");
        }

        public static string GetFileHash( string fileName )
        {
            string hash = "";
            using (var md5 = MD5.Create())
            {
                using (var stream = File.OpenRead(fileName))
                {
                    var result = md5.ComputeHash(stream);

                    hash = BitConverter.ToString(result).Replace("-", "").ToLower();
                }
            }

            return hash;
        }

        public static void ScanDrive( string driveLetter )
        {
            SetupExtensionWhiteList();

            System.IO.DriveInfo di = new System.IO.DriveInfo( driveLetter );

            // Here we skip the drive if it is not ready to be read. This 
            // is not necessarily the appropriate action in all scenarios. 
            if (!di.IsReady)
            {
                Console.WriteLine("The drive {0} could not be read", di.Name);
                return;
            }
            System.IO.DirectoryInfo rootDir = di.RootDirectory;
            WalkDirectoryTree(rootDir);
        }

        public static void ScanAll()
        {
            SetupExtensionWhiteList();

            // Start with drives if you have to search the entire computer. 
            string[] drives = System.Environment.GetLogicalDrives();

            foreach (string dr in drives)
            {
                System.IO.DriveInfo di = new System.IO.DriveInfo(dr);

                // Here we skip the drive if it is not ready to be read. This 
                // is not necessarily the appropriate action in all scenarios. 
                if (!di.IsReady)
                {
                    Console.WriteLine("The drive {0} could not be read", di.Name);
                    continue;
                }
                System.IO.DirectoryInfo rootDir = di.RootDirectory;
                WalkDirectoryTree(rootDir);
            }

            // Write out all the files that could not be processed.
            Console.WriteLine("Files with restricted access:");
            foreach (string s in log)
            {
                Console.WriteLine(s);
            }
            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key");
            Console.ReadKey();
        }

        static void WalkDirectoryTree(System.IO.DirectoryInfo root)
        {
            System.IO.FileInfo[] files = null;
            System.IO.DirectoryInfo[] subDirs = null;

            // First, process all the files directly under this folder 
            try
            {
                files = root.GetFiles("*.*");
            }
            // This is thrown if even one of the files requires permissions greater 
            // than the application provides. 
            catch (UnauthorizedAccessException e)
            {
                // This code just writes out the message and continues to recurse. 
                // You may decide to do something different here. For example, you 
                // can try to elevate your privileges and access the file again.
                log.Add(e.Message);
            }
            catch (System.IO.DirectoryNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }

            if (files != null)
            {
                foreach (System.IO.FileInfo fi in files)
                {
                    // In this example, we only access the existing FileInfo object. If we 
                    // want to open, delete or modify the file, then 
                    // a try-catch block is required here to handle the case 
                    // where the file has been deleted since the call to TraverseTree().
                    if ( m_extensionWhiteList.Contains( fi.Extension ) == true )
                    {
                        //Console.WriteLine(fi.FullName);

                        string hash = GetFileHash(fi.FullName);

                        Console.WriteLine(string.Format("{0}: {1}", hash, fi.FullName));
                    }
                }

                // Now find all the subdirectories under this directory.
                subDirs = root.GetDirectories();

                foreach (System.IO.DirectoryInfo dirInfo in subDirs)
                {
                    // Resursive call for each subdirectory.
                    WalkDirectoryTree(dirInfo);
                }
            }
        }
    }
}
