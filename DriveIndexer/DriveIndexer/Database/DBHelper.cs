using DriveIndexer.Data;
using DriveIndexer.Database;
using OceanAirdrop;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DriveIndexer
{
    public static class DBHelper
    {
        public static string DateToDBDateTime(DateTime date)
        {
            return date.ToString("yyyy-MM-dd HH:mm:ss");
        }

        public static string DateToDBDate(DateTime date)
        {
            return date.ToString("yyyy-MM-dd");
        }

        public static List<DBTableInfo> GetTableInfo(string tableName)
        {
            List<DBTableInfo> list = new List<DBTableInfo>();

            try
            {
                string sql = string.Format("PRAGMA table_info({0});", tableName);

                SQLiteCommand command = new SQLiteCommand(sql, LocalSqllite.m_sqlLiteConnection);
                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    DBTableInfo data = new DBTableInfo();
                    data.m_cid = reader["cid"].ToString();
                    data.m_columnName = reader["name"].ToString();
                    data.m_columnType = reader["type"].ToString();
                    data.m_defaultValue = reader["notnull"].ToString();
                    data.m_notNull = reader["dflt_value"].ToString();
                    data.m_primaryKey = reader["pk"].ToString();

                    list.Add(data);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return list;
        }

        public static List<PhysicalDriveData> ReadDriveList()
        {
            List<PhysicalDriveData> list = new List<PhysicalDriveData>();

            try
            {
                string sql = "select DriveId, SerialNumber, Manufacturer, MediaType, Model, Partitions, Caption, InterfaceType, Size, UserComment, DriveScanned, DriveScannedDate FROM PhysicalDrives";
                SQLiteCommand command = new SQLiteCommand(sql, LocalSqllite.m_sqlLiteConnection);
                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    PhysicalDriveData data = new PhysicalDriveData();
                    data.DriveId = reader["DriveId"].ToString();
                    data.SerialNumber = reader["SerialNumber"].ToString();
                    data.Manufacturer = reader["Manufacturer"].ToString();
                    data.MediaType = reader["MediaType"].ToString();
                    data.Model = reader["Model"].ToString();
                    data.Partitions = reader["Partitions"].ToString();
                    data.Caption = reader["Caption"].ToString();
                    data.InterfaceType = reader["InterfaceType"].ToString();
                    data.Size = reader["Size"].ToString();
                    data.UserComment = reader["UserComment"].ToString();
                    data.DriveScanned = reader["DriveScanned"].ToString();
                    data.DriveScannedDate = reader["DriveScannedDate"].ToString();

                    data.m_drivePartitions = ReadDrivePartitionList(data);
                    list.Add(data);

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return list;
        }

        public static List<DrivePartitionData> ReadDrivePartitionList( PhysicalDriveData drive )
        {
            List<DrivePartitionData> list = new List<DrivePartitionData>();

            try
            {
                string sql = "select PartitionId, DriveId, VolumeSerialNumber, Name, Caption, Description, DeviceID, DriveType, FileSystem, FreeSpace, Size, UserComment FROM PhysicalDrivePartitions where DriveId = " + drive.DriveId;
                SQLiteCommand command = new SQLiteCommand(sql, LocalSqllite.m_sqlLiteConnection);
                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    DrivePartitionData data = new DrivePartitionData();
                    data.PartitionId = reader["PartitionId"].ToString();
                    data.DriveId = reader["DriveId"].ToString();
                    data.VolumeSerialNumber = reader["VolumeSerialNumber"].ToString();
                    data.Name = reader["Name"].ToString();
                    data.Description = reader["Description"].ToString();
                    data.DeviceID = reader["DeviceID"].ToString();
                    data.DriveType = reader["DriveType"].ToString();
                    data.FileSystem = reader["FileSystem"].ToString();
                    data.FreeSpace = reader["FreeSpace"].ToString();
                    data.Size = reader["Size"].ToString();
                    data.UserComment = reader["UserComment"].ToString();

                    data.PhysicalDrive = drive;

                    list.Add(data);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return list;
        }

        public static void PopulatePhyicalDrive(PhysicalDriveData drive)
        {
            try
            {
                // check if we have already seen this drive! 
                string sql = WritePhysicalDriveToDatabase(drive);
                LocalSqllite.ExecSQLCommand(sql);

                string driveId = CheckDriveIdExists(drive);

                foreach (var drivePartition in drive.m_drivePartitions)
                {
                    sql = WritePartitionDataToDatabase(driveId, drivePartition);
                    LocalSqllite.ExecSQLCommand(sql);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public static void PopulatePhyicalDriveList( List<PhysicalDriveData> driveList )
        {
            try
            {
                string sql = "";
                foreach (var drive in driveList)
                {
                    PopulatePhyicalDrive(drive);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public static string CheckDriveIdExists( PhysicalDriveData data )
        {
            string returnVal = "";
            string sql = string.Format("select DriveId from PhysicalDrives where SerialNumber = '{0}'", data.SerialNumber);

            returnVal = LocalSqllite.ExecSQLCommandScalar(sql);

            return returnVal;
        }

        private static string CheckPartitionIdExists( string driveId, DrivePartitionData data )
        {
            string returnVal = "";
            string sql = string.Format("select PartitionId from PhysicalDrivePartitions where VolumeSerialNumber = '{0}' and DriveId = '{1}'", data.VolumeSerialNumber, driveId);

            returnVal = LocalSqllite.ExecSQLCommandScalar(sql);

            return returnVal;
        }

        private static string WritePhysicalDriveToDatabase( PhysicalDriveData data )
        {
            StringBuilder sqlStatement = new StringBuilder();

            try
            {
                string driveId = CheckDriveIdExists(data);
                if (driveId == "")
                {
                    // insert statment
                    sqlStatement.AppendLine("INSERT OR IGNORE INTO PhysicalDrives ( SerialNumber, Manufacturer, MediaType, Model, Partitions, Caption, InterfaceType, Size, UserComment ) VALUES ( ");
                    sqlStatement.AppendLine(string.Format("'{0}'", data.SerialNumber));
                    sqlStatement.AppendLine(string.Format(",'{0}'", data.Manufacturer));
                    sqlStatement.AppendLine(string.Format(",'{0}'", data.MediaType));
                    sqlStatement.AppendLine(string.Format(",'{0}'", data.Model));
                    sqlStatement.AppendLine(string.Format(",'{0}'", data.Partitions));
                    sqlStatement.AppendLine(string.Format(",'{0}'", data.Caption));
                    sqlStatement.AppendLine(string.Format(",'{0}'", data.InterfaceType));
                    sqlStatement.AppendLine(string.Format(",'{0}'", data.Size));
                    sqlStatement.AppendLine(string.Format(",'{0}'", data.UserComment));
                    sqlStatement.AppendLine(");");
                }
                else
                {
                    // update statment
                    //sqlStatement.AppendLine("UPDATE PhysicalDrives SET ");
                    //sqlStatement.AppendLine(string.Format("SerialNumber = '{0}'", data.SerialNumber));
                    //sqlStatement.AppendLine(string.Format(",Manufacturer = '{0}'", data.Manufacturer));
                    //sqlStatement.AppendLine(string.Format(",MediaType = '{0}'", data.MediaType));
                    //sqlStatement.AppendLine(string.Format(",Model = '{0}'", data.Model));
                    //sqlStatement.AppendLine(string.Format(",Partitions = '{0}'", data.Partitions));
                    //sqlStatement.AppendLine(string.Format(",Caption = '{0}'", data.Caption));
                    //sqlStatement.AppendLine(string.Format(",InterfaceType = '{0}'", data.InterfaceType));
                    //sqlStatement.AppendLine(string.Format(",Size = '{0}'", data.Size));
                    //sqlStatement.AppendLine(string.Format(",UserComment = '{0}'", data.UserComment));
                    //sqlStatement.AppendLine(string.Format("WHERE DriveId = '{0}'", driveId));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return sqlStatement.ToString();
        }

        private static string WritePartitionDataToDatabase(string driveId, DrivePartitionData data)
        {
            StringBuilder sqlStatement = new StringBuilder();

            try
            {
                string partitionId = CheckPartitionIdExists(driveId, data);
                if (partitionId == "")
                {
                    // insert statment
                    sqlStatement.AppendLine("INSERT OR IGNORE INTO PhysicalDrivePartitions ( DriveId, VolumeSerialNumber, Name, Caption, Description, DeviceID, DriveType, FileSystem, FreeSpace, Size, UserComment ) VALUES ( ");
                    sqlStatement.AppendLine(string.Format("'{0}'", driveId));
                    sqlStatement.AppendLine(string.Format(",'{0}'", data.VolumeSerialNumber));
                    sqlStatement.AppendLine(string.Format(",'{0}'", data.Name));
                    sqlStatement.AppendLine(string.Format(",'{0}'", data.Caption));
                    sqlStatement.AppendLine(string.Format(",'{0}'", data.Description));
                    sqlStatement.AppendLine(string.Format(",'{0}'", data.DeviceID));
                    sqlStatement.AppendLine(string.Format(",'{0}'", data.DriveType));
                    sqlStatement.AppendLine(string.Format(",'{0}'", data.FileSystem));
                    sqlStatement.AppendLine(string.Format(",'{0}'", data.FreeSpace));
                    sqlStatement.AppendLine(string.Format(",'{0}'", data.Size));
                    sqlStatement.AppendLine(string.Format(",'{0}'", data.UserComment));
                    sqlStatement.AppendLine(");");
                }
                else
                {
                    //// update statment
                    //sqlStatement.AppendLine("UPDATE PhysicalDrivePartitions SET ");
                    //sqlStatement.AppendLine(string.Format("VolumeSerialNumber = '{0}'", data.VolumeSerialNumber));
                    //sqlStatement.AppendLine(string.Format(",Name = '{0}'", data.Name));
                    //sqlStatement.AppendLine(string.Format(",Caption = '{0}'", data.Caption));
                    //sqlStatement.AppendLine(string.Format(",Description = '{0}'", data.Description));
                    //sqlStatement.AppendLine(string.Format(",DeviceID = '{0}'", data.DeviceID));
                    //sqlStatement.AppendLine(string.Format(",DriveType = '{0}'", data.DriveType));
                    //sqlStatement.AppendLine(string.Format(",FileSystem = '{0}'", data.FileSystem));
                    //sqlStatement.AppendLine(string.Format(",FreeSpace = '{0}'", data.FreeSpace));
                    //sqlStatement.AppendLine(string.Format(",Size = '{0}'", data.Size));
                    //sqlStatement.AppendLine(string.Format(",UserComment = '{0}'", data.UserComment));
                    //sqlStatement.AppendLine(string.Format("WHERE DriveId = '{0}'", partitionId));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return sqlStatement.ToString();
        }

        private static string CheckFileExists(DrivePartitionData data, System.IO.FileInfo fi)
        {
            string returnVal = "";

            string dirName = GetDirectoryName(fi);

            string sql = string.Format("select FileId from FileIndex where FileName = '{0}' and FilePath = '{1}' and DriveId = '{2}' and PartitionId = '{3}'", fi.Name.Replace("'", "''"), dirName.Replace("'", "''"), data.PhysicalDrive.DriveId, data.PartitionId);

            returnVal = LocalSqllite.ExecSQLCommandScalar(sql);

            return returnVal;
        }

        private static string GetDirectoryName(System.IO.FileInfo fi)
        {
            // Its important that we write every file to the database as if it was on the Z: drive.
            // This is beacuse the next time we insert the drive/usb stick windows might assign it a new drive letter.
            // Then when we check to see if we have indexed this file previosuly the lookup wont match because the letter is different.
            /// This way the base drive letter is always Z:
            /// 
            StringBuilder strBuilder = new StringBuilder(fi.DirectoryName);
            strBuilder[0] = 'Z';

            return strBuilder.ToString();
        }

        public static bool WriteFileToDatabase(DrivePartitionData data, System.IO.FileInfo fi, IFileExplorerUIManager ui)
        {
            bool bSuccessInsert = false;

            try
            {
                string dirName = GetDirectoryName(fi);

                StringBuilder sqlStatement = new StringBuilder();

                string fileExists = CheckFileExists(data, fi);
                if (fileExists == "")
                {
                    // if (ui != null)
                    //    ui.OutputFileScanned(string.Format("Hashing File: {0} (Size: {1})", fi.Name, fi.Length));
                    string hash = ""; // GetFileHash(fi.FullName);

                    // insert statment
                    sqlStatement.AppendLine("INSERT OR IGNORE INTO FileIndex ( DriveId, PartitionId, FileName, FileExtension, FilePath, FileSize, FileTypeId, FileTag, FileHash, UserComment ) VALUES ( ");
                    sqlStatement.AppendLine(string.Format("'{0}'", data.PhysicalDrive.DriveId));
                    sqlStatement.AppendLine(string.Format(",'{0}'", data.PartitionId));
                    sqlStatement.AppendLine(string.Format(",'{0}'", fi.Name.Replace("'","''")));
                    sqlStatement.AppendLine(string.Format(",'{0}'", fi.Extension));
                    sqlStatement.AppendLine(string.Format(",'{0}'", dirName.Replace("'", "''")));
                    sqlStatement.AppendLine(string.Format(",'{0}'", fi.Length));
                    sqlStatement.AppendLine(string.Format(",'{0}'", "unknown type"));
                    sqlStatement.AppendLine(string.Format(",'{0}'", "unknown tag"));
                    sqlStatement.AppendLine(string.Format(",'{0}'", hash));
                    sqlStatement.AppendLine(string.Format(",'{0}'", "user comment"));
                    sqlStatement.AppendLine(");");

                    bSuccessInsert = LocalSqllite.ExecSQLCommand(sqlStatement.ToString());

                    //Console.WriteLine(string.Format("{0}: {1}", hash, fi.FullName));
                    if (ui != null)
                        ui.OutputFileScanned(string.Format("Indexing File: {0}", fi.Name));
                }
                else
                {
                    //Console.WriteLine(string.Format("Skipping File (Already Indexed): {0}", fi.Name));
                    if (ui != null)
                        ui.OutputFileScanned(string.Format("Skipping File (Already Indexed): {0}", fi.FullName));
                }
                //else
                //{
                //    // update statment
                //    sqlStatement.AppendLine("UPDATE PhysicalDrivePartitions SET ");
                //    sqlStatement.AppendLine(string.Format("VolumeSerialNumber = '{0}'", data.VolumeSerialNumber));
                //    sqlStatement.AppendLine(string.Format("Name = '{0}'", data.Name));
                //    sqlStatement.AppendLine(string.Format("Caption = '{0}'", data.Caption));
                //    sqlStatement.AppendLine(string.Format("Description = '{0}'", data.Description));
                //    sqlStatement.AppendLine(string.Format("DeviceID = '{0}'", data.DeviceID));
                //    sqlStatement.AppendLine(string.Format("DriveType = '{0}'", data.DriveType));
                //    sqlStatement.AppendLine(string.Format("FileSystem = '{0}'", data.FileSystem));
                //    sqlStatement.AppendLine(string.Format("FreeSpace = '{0}'", data.FreeSpace));
                //    sqlStatement.AppendLine(string.Format("Size = '{0}'", data.Size));
                //    sqlStatement.AppendLine(string.Format("UserComment = '{0}'", data.UserComment));
                //    sqlStatement.AppendLine(string.Format("WHERE DriveId = '{0}'", partitionId));
                //}
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return bSuccessInsert;
        }

        public static string GetFileHash(string fileName)
        {
            string hash = "";
            try
            {
                using (var md5 = MD5.Create())
                {
                    using (var stream = File.OpenRead(fileName))
                    {
                        var result = md5.ComputeHash(stream);

                        hash = BitConverter.ToString(result).Replace("-", "").ToLower();
                    }
                }
            }
            catch (Exception)
            {
            }

            return hash;
        }

        public static bool UpdateDriveScannedStatus(PhysicalDriveData data)
        {
            string sql = string.Format("Update PhysicalDrives set DriveScanned = 1, DriveScannedDate = '{0}' where DriveId = '{1}'", DateTime.Now.ToString("YYYY-MM-DD"), data.DriveId);

            return LocalSqllite.ExecSQLCommand(sql);
        }

        public static void SetupDefaultFileGroups()
        {
            string sqlTemplate = "INSERT OR IGNORE INTO FileGroup ( FileGroupName ) VALUES ( '{0}' ); SELECT last_insert_rowid()";

            List<string> defaultFileGroups = new List<string>();
            defaultFileGroups.Add("Everything");
            defaultFileGroups.Add("Documents");
            defaultFileGroups.Add("Spreadsheet");
            defaultFileGroups.Add("Ebook");
            defaultFileGroups.Add("Code");
            defaultFileGroups.Add("Movies");
            defaultFileGroups.Add("Music");
            defaultFileGroups.Add("Games");
            defaultFileGroups.Add("Image");
            defaultFileGroups.Add("Web");
            defaultFileGroups.Add("System");
            defaultFileGroups.Add("Compressed");
            defaultFileGroups.Add("Executable");

            foreach( var fileGroup in defaultFileGroups)
            {
                string sql = string.Format(sqlTemplate, fileGroup);

                string id = LocalSqllite.ExecSQLCommandScalar(sql);

                List<FileTypeData> fileTypes = SetupDefaultFileTypes(fileGroup);
                foreach (var type in fileTypes)
                {
                    string sqlFileType = string.Format("INSERT OR IGNORE INTO FileType ( FileGroupId, FileType, FileTypeDesc ) VALUES ( '{0}', '{1}', '{2}' );", id, type.m_fileType, type.m_fileTypeDesc);
                    LocalSqllite.ExecSQLCommand(sqlFileType);
                    Console.WriteLine(sqlFileType);
                }
            }
        }

        public static List<FileTypeData> SetupDefaultFileTypes(string fileGroup)
        {
            // http://fileinfo.com/filetypes/common
            List<FileTypeData> fileTypes = new List<FileTypeData>();

            switch (fileGroup)
            {
                case "Documents":
                    return DefaultFileTypesText.DefaultTypes();
                    break;
                case "Spreadsheet":
                    return DefaultFileTypesSpreadsheet.DefaultTypes();
                    break;
                case "Ebook":
                    return DefaulFileTypesEbook.DefaultTypes();
                    break;
                case "Code":
                    return DefaultFileTypesCode.DefaultTypes();
                    break;
                case "Movies":
                    return DefaultFileTypesVideo.DefaultTypes();
                    break;
                case "Audio":
                    return DefaulFileTypesAudio.DefaultTypes();
                    break;
                case "Image":
                    return DefaultFileTypesImage.DefaultTypes();
                    break;
                case "Database":
                    return DefaultFileTypesDatabase.DefaultTypes();
                    break;
                case "Web":
                    return DefaultFileTypesWeb.DefaultTypes();
                    break;
                case "Compressed":
                    return DefaultFileTypesCompressed.DefaultTypes();
                    break;
                case "Games":
                    return DefaultFileTypesGame.DefaultTypes();
                    break;
                case "System":
                    return DefaultFileTypesSystem.DefaultTypes();
                    break;
                case "Executable":
                    return DefaultFileTypesSystem.DefaultTypes();
                    break;

                default:
                    break;
            }

            return fileTypes;
        }


    }
}

