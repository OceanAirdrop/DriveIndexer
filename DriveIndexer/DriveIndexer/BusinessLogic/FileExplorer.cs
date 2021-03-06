﻿using DriveIndexer.Data;
using OceanAirdrop;
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
        public static bool bCancelProcess = false;

        public static UInt64 m_indexedFileCount = 0;

        static IFileExplorerUIManager m_uiManager = null;

        static List<FileTypeData> m_extensionWhiteList = new List<FileTypeData>();

        public static void Initialise()
        {
            bCancelProcess = false;
            m_indexedFileCount = 0;
            m_uiManager = null;

            SetupExtensionWhiteList();
        }

        public static void SetupExtensionWhiteList()
        {
            m_extensionWhiteList = DBHelper.ReadWhiteListedFileTypes();
            
        }

        public static void InjectUserInterfaceManager(IFileExplorerUIManager ui)
        {
            m_uiManager = ui;
        }

        private static void OutputMessage(string msg)
        {
            if (m_uiManager != null)
                m_uiManager.OutputFileScanned(msg);
        }

        public static bool CheckIfDriveAvailableToScan(PhysicalDriveData driveSelected)
        {
            bool bDriveAvailable = false;

            try
            {
                List<PhysicalDriveData> driveList = DriveInfoScanner.ScanDrives();

                foreach (var drive in driveList)
                {
                    if (drive.SerialNumber == driveSelected.SerialNumber)
                    {
                        bDriveAvailable = true;
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return bDriveAvailable;
        }

        

        public static bool CheckIfDriveAvailableToScan(DrivePartitionData logicalDrive)
        {
            bool bDriveAvailable = false;

            try
            {
                List<PhysicalDriveData> driveList = DriveInfoScanner.ScanDrives();

                foreach (var drive in driveList)
                {
                    foreach (var drivePartition in drive.m_drivePartitions)
                    {
                        if (drivePartition.VolumeSerialNumber == logicalDrive.VolumeSerialNumber)
                        {
                            bDriveAvailable = true;
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //string[] availableDriveLabels = System.Environment.GetLogicalDrives();

            //if (availableDriveLabels.Contains( string.Format(@"{0}\",logicalDrive.Name) ) == true)
            //    bDriveAvailable = true;

            return bDriveAvailable;
        }

        public static string GetCurrentDriveLetterForDrive(DrivePartitionData driveInfo )
        {
            string currentDriveLetter = "";

            try
            {
                List<PhysicalDriveData> driveList = DriveInfoScanner.ScanDrives();

                foreach (var drive in driveList)
                {
                    foreach (var drivePartition in drive.m_drivePartitions)
                    {
                        if (drivePartition.VolumeSerialNumber == driveInfo.VolumeSerialNumber)
                        {
                            currentDriveLetter = drivePartition.Name;
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return currentDriveLetter;
        }

        private static DrivePartitionData m_logicalDrive = null;

        public static void ScanDrive(DrivePartitionData logicalDrive)
        {
            try
            {
                m_logicalDrive = logicalDrive;

                if (CheckIfDriveAvailableToScan(logicalDrive) == false)
                {
                    OutputMessage(string.Format("Logical Drive: {0} not available to scan", logicalDrive.Name));
                    return;
                }

                logicalDrive.Name = GetCurrentDriveLetterForDrive(logicalDrive);

                OutputMessage(string.Format("Starting scan: {0}", logicalDrive.Name));


                //SetupExtensionWhiteList();

                System.IO.DriveInfo di = new System.IO.DriveInfo(logicalDrive.DeviceID);

                // Here we skip the drive if it is not ready to be read. This 
                // is not necessarily the appropriate action in all scenarios. 
                if (!di.IsReady)
                {
                    OutputMessage(string.Format("The drive: {0} could not be read", di.Name));
                    Console.WriteLine("The drive {0} could not be read", di.Name);
                    return;
                }
                System.IO.DirectoryInfo rootDir = di.RootDirectory;
                WalkDirectoryTree(rootDir);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        //public static void ScanDrive( string driveLetter )
        //{
        //    SetupExtensionWhiteList();

        //    System.IO.DriveInfo di = new System.IO.DriveInfo( driveLetter );

        //    // Here we skip the drive if it is not ready to be read. This 
        //    // is not necessarily the appropriate action in all scenarios. 
        //    if (!di.IsReady)
        //    {
        //        Console.WriteLine("The drive {0} could not be read", di.Name);
        //        return;
        //    }
        //    System.IO.DirectoryInfo rootDir = di.RootDirectory;
        //    WalkDirectoryTree(rootDir);
        //}

        //public static void ScanAll()
        //{
        //    SetupExtensionWhiteList();

        //    // Start with drives if you have to search the entire computer. 
        //    string[] drives = System.Environment.GetLogicalDrives();

        //    foreach (string dr in drives)
        //    {
        //        System.IO.DriveInfo di = new System.IO.DriveInfo(dr);

        //        // Here we skip the drive if it is not ready to be read. This 
        //        // is not necessarily the appropriate action in all scenarios. 
        //        if (!di.IsReady)
        //        {
        //            Console.WriteLine("The drive {0} could not be read", di.Name);
        //            continue;
        //        }
        //        System.IO.DirectoryInfo rootDir = di.RootDirectory;
        //        WalkDirectoryTree(rootDir);
        //    }

        //    // Write out all the files that could not be processed.
        //    Console.WriteLine("Files with restricted access:");
        //    foreach (string s in log)
        //    {
        //        Console.WriteLine(s);
        //    }
        //}

        static FileTypeData IstExtensionWhiteListed( string ext )
        {
            FileTypeData found = null;
            foreach (var fileType in m_extensionWhiteList)
            {
                if ( fileType.m_fileType == ext)
                {
                    found = fileType;
                    break;
                }
            }

            return found;
        }

        static void WalkDirectoryTree(System.IO.DirectoryInfo root)
        {
            try
            {
                if (bCancelProcess == true)
                    return;

                System.IO.FileInfo[] files = null;
                System.IO.DirectoryInfo[] subDirs = null;

                // First, process all the files directly under this folder 
                try
                {
                    files = root.GetFiles("*.*");

                    m_uiManager.OutputCurrentDirectoryBeingScanned(root.FullName);
                }
                // This is thrown if even one of the files requires permissions greater 
                // than the application provides. 
                catch (UnauthorizedAccessException e)
                {
                    // This code just writes out the message and continues to recurse. 
                    // You may decide to do something different here. For example, you 
                    // can try to elevate your privileges and access the file again.
                    //log.Add(e.Message);
                    Console.WriteLine(e.Message);
                }
                catch (System.IO.DirectoryNotFoundException e)
                {
                    Console.WriteLine(e.Message);
                }

                if (files != null)
                {
                    foreach (System.IO.FileInfo fi in files)
                    {
                        try
                        {
                            if (bCancelProcess == true)
                                return;

                            FileTypeData includeFile = IstExtensionWhiteListed(fi.Extension);
                            if (includeFile == null)
                            {
                                OutputMessage(string.Format("Skipping File (Blacklisted): {0}", fi.Name));
                                continue;
                            }

                            //Console.WriteLine(fi.FullName);
                            //var x = m_logicalDrive.Name;
                            //OutputMessage(string.Format("file: {0}", fi.FullName));

                            if (DBHelper.WriteFileToDatabase(m_logicalDrive, fi, includeFile, m_uiManager) == true)
                            {
                                m_indexedFileCount++;
                                m_uiManager.OutputFileIndexCount(m_indexedFileCount);
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
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
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

