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
        public static List<PhysicalDriveData> ReadDriveList()
        {
            List<PhysicalDriveData> list = new List<PhysicalDriveData>();

            string sql = "select DriveId, SerialNumber, Manufacturer, MediaType, Model, Partitions, Caption, InterfaceType, Size, UserComment FROM PhysicalDrives";
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

                data.m_drivePartitions = ReadDrivePartitionList(data);
                list.Add(data);

            }

            return list;
        }

        public static List<DrivePartitionData> ReadDrivePartitionList( PhysicalDriveData drive )
        {
            List<DrivePartitionData> list = new List<DrivePartitionData>();

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

            return list;
        }

        public static void PopulatePhyicalDriveTable( List<PhysicalDriveData> driveList )
        {
            string sql = "";
            foreach (var drive in driveList)
            {
                // check if we have already seen this drive! 
                sql = WritePhysicalDriveToDatabase( drive );
                LocalSqllite.ExecSQLCommand( sql );

                string driveId = CheckDriveIdExists( drive );

                foreach ( var drivePartition in drive.m_drivePartitions )
                {
                    sql = WritePartitionDataToDatabase( driveId, drivePartition );
                    LocalSqllite.ExecSQLCommand( sql );
                }
            }
        }

        private static string CheckDriveIdExists( PhysicalDriveData data )
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
            
            string driveId = CheckDriveIdExists( data );
            if ( driveId == "") 
            {
                // insert statment
                sqlStatement.AppendLine("INSERT OR IGNORE INTO PhysicalDrives ( SerialNumber, Manufacturer, MediaType, Model, Partitions, Caption, InterfaceType, Size, UserComment ) VALUES ( ");
                sqlStatement.AppendLine( string.Format("'{0}'", data.SerialNumber) );
                sqlStatement.AppendLine( string.Format(",'{0}'", data.Manufacturer) );
                sqlStatement.AppendLine( string.Format(",'{0}'", data.MediaType) );
                sqlStatement.AppendLine( string.Format(",'{0}'", data.Model) );
                sqlStatement.AppendLine( string.Format(",'{0}'", data.Partitions) );
                sqlStatement.AppendLine( string.Format(",'{0}'", data.Caption) );
                sqlStatement.AppendLine( string.Format(",'{0}'", data.InterfaceType) );
                sqlStatement.AppendLine( string.Format(",'{0}'", data.Size) );
                sqlStatement.AppendLine( string.Format(",'{0}'", data.UserComment) );
                sqlStatement.AppendLine(");");
            }
            else
            {
                // update statment
                sqlStatement.AppendLine("UPDATE PhysicalDrives SET ");
                sqlStatement.AppendLine(string.Format("SerialNumber = '{0}'", data.SerialNumber));
                sqlStatement.AppendLine(string.Format("Manufacturer = '{0}'", data.Manufacturer));
                sqlStatement.AppendLine(string.Format("MediaType = '{0}'", data.MediaType));
                sqlStatement.AppendLine(string.Format("Model = '{0}'", data.Model));
                sqlStatement.AppendLine(string.Format("Partitions = '{0}'", data.Partitions));
                sqlStatement.AppendLine(string.Format("Caption = '{0}'", data.Caption));
                sqlStatement.AppendLine(string.Format("InterfaceType = '{0}'", data.InterfaceType));
                sqlStatement.AppendLine(string.Format("Size = '{0}'", data.Size));
                sqlStatement.AppendLine(string.Format("UserComment = '{0}'", data.UserComment));
                sqlStatement.AppendLine(string.Format("WHERE DriveId = '{0}'", driveId));
            }

            return sqlStatement.ToString();
        }

        private static string WritePartitionDataToDatabase(string driveId, DrivePartitionData data)
        {
            StringBuilder sqlStatement = new StringBuilder();

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
                // update statment
                sqlStatement.AppendLine("UPDATE PhysicalDrivePartitions SET ");
                sqlStatement.AppendLine(string.Format("VolumeSerialNumber = '{0}'", data.VolumeSerialNumber));
                sqlStatement.AppendLine(string.Format("Name = '{0}'", data.Name));
                sqlStatement.AppendLine(string.Format("Caption = '{0}'", data.Caption));
                sqlStatement.AppendLine(string.Format("Description = '{0}'", data.Description));
                sqlStatement.AppendLine(string.Format("DeviceID = '{0}'", data.DeviceID));
                sqlStatement.AppendLine(string.Format("DriveType = '{0}'", data.DriveType));
                sqlStatement.AppendLine(string.Format("FileSystem = '{0}'", data.FileSystem));
                sqlStatement.AppendLine(string.Format("FreeSpace = '{0}'", data.FreeSpace));
                sqlStatement.AppendLine(string.Format("Size = '{0}'", data.Size));
                sqlStatement.AppendLine(string.Format("UserComment = '{0}'", data.UserComment));
                sqlStatement.AppendLine(string.Format("WHERE DriveId = '{0}'", partitionId));
            }

            return sqlStatement.ToString();
        }

        private static string CheckFileExists(DrivePartitionData data, System.IO.FileInfo fi)
        {
            string returnVal = "";
            string sql = string.Format("select FileId from FileIndex where FileName = '{0}' and FilePath = '{1}' and DriveId = '{2}' and PartitionId = '{3}'", fi.Name, fi.DirectoryName, data.PhysicalDrive.DriveId, data.PartitionId );

            returnVal = LocalSqllite.ExecSQLCommandScalar(sql);

            return returnVal;
        }

        public static bool WriteFileToDatabase(DrivePartitionData data, System.IO.FileInfo fi, IFileExplorerUIManager ui)
        {
            bool bSuccessInsert = false;

            StringBuilder sqlStatement = new StringBuilder();

            string fileExists = CheckFileExists(data, fi);
            if (fileExists == "")
            {
                if (ui != null)
                    ui.OutputFileScanned(string.Format("Hashing File: {0} (Size: {1})", fi.Name, fi.Length));

                string hash = GetFileHash(fi.FullName);

                // insert statment
                sqlStatement.AppendLine("INSERT OR IGNORE INTO FileIndex ( DriveId, PartitionId, FileName, FileExtension, FilePath, FileSize, FileTypeId, FileTag, FileHash, UserComment ) VALUES ( ");
                sqlStatement.AppendLine(string.Format("'{0}'", data.PhysicalDrive.DriveId));
                sqlStatement.AppendLine(string.Format(",'{0}'", data.PartitionId));
                sqlStatement.AppendLine(string.Format(",'{0}'", fi.Name));
                sqlStatement.AppendLine(string.Format(",'{0}'", fi.Extension));
                sqlStatement.AppendLine(string.Format(",'{0}'", fi.DirectoryName));
                sqlStatement.AppendLine(string.Format(",'{0}'", fi.Length));
                sqlStatement.AppendLine(string.Format(",'{0}'", "unknown type" ));
                sqlStatement.AppendLine(string.Format(",'{0}'", "unknown tag"));
                sqlStatement.AppendLine(string.Format(",'{0}'", hash));
                sqlStatement.AppendLine(string.Format(",'{0}'", "user comment"));
                sqlStatement.AppendLine(");");

                bSuccessInsert = LocalSqllite.ExecSQLCommand(sqlStatement.ToString());

                Console.WriteLine(string.Format("{0}: {1}", hash, fi.FullName));
                if ( ui != null )
                    ui.OutputFileScanned(string.Format("Indexing File: {0}", fi.Name));
            }
            else
            {
                Console.WriteLine(string.Format("Skipping File (Already Indexed): {0}", fi.Name));
                if ( ui != null )
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
    }
}

