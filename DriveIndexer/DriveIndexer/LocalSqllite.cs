using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.IO;

namespace OceanAirdrop
{
    public static class LocalSqllite
    {
        public static string m_dbName = "IndexedFiles.db";
        public static SQLiteConnection m_sqlLiteConnection;

        // Creates a connection with our database file.
        public static void ConnectToDatabase()
        {
            try
            {
                m_sqlLiteConnection = new SQLiteConnection(string.Format("Data Source={0};Version=3;", m_dbName));
                m_sqlLiteConnection.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void ExecSQLCommand(string sql)
        {
            try
            {
                SQLiteCommand command = new SQLiteCommand(sql, m_sqlLiteConnection);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        // Creates an empty database file
        public static void CreateNewSQLLiteDatabase()
        {
            string dbLocation = AppDomain.CurrentDomain.BaseDirectory + m_dbName;

            FileInfo fi = new FileInfo(dbLocation);
            if (fi.Exists == false)
            {
                SQLiteConnection.CreateFile(dbLocation);

                ConnectToDatabase();

                // now create schema
                CreateSQLLiteSchema();
            }
            else
                ConnectToDatabase();
        }

        public static void CreateSQLLiteSchema()
        {
            try
            {
                CreatePhysicalDrivesTable();
                CreateDrivePartitionTable();
                CreateFileGroupTable();
                CreateFileTypeTable();
                CreateFileIndexTable();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void CreatePhysicalDrivesTable()
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("create table PhysicalDrives ( ");
                sb.Append("DriveId integer primary key, ");
                sb.Append("SerialNumber text, ");
                sb.Append("Manufacturer text, ");
                sb.Append("MediaType text, ");
                sb.Append("Model text, ");
                sb.Append("Partitions numeric, ");
                sb.Append("Caption text, ");
                sb.Append("InterfaceType text, ");
                sb.Append("Size numeric, ");
                sb.Append("UserComment text); ");

                ExecSQLCommand(sb.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void CreateDrivePartitionTable()
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("create table DrivePartitions ( ");
                sb.Append("PartitionId integer primary key, ");
                sb.Append("DriveId integer, ");
                sb.Append("VolumeSerialNumber text, ");
                sb.Append("Name text, ");
                sb.Append("Caption text, ");
                sb.Append("Description text, ");
                sb.Append("DeviceID text, ");
                sb.Append("DriveType text, ");
                sb.Append("FileSystem text, ");
                sb.Append("FreeSpace text, ");
                sb.Append("Size text, ");
                sb.Append("UserComment text); ");

                ExecSQLCommand(sb.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void CreateFileGroupTable()
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("create table FileGroup ( ");
                sb.Append("FileGroupId integer primary key, ");
                sb.Append("FileGroupName text); ");                     // Name of Group ( document / Video / Music / Code )

                ExecSQLCommand(sb.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void CreateFileTypeTable()
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("create table FileType ( ");
                sb.Append("FileTypeId integer primary key, ");
                sb.Append("FileGroupId integer,");                      // Links to FileGroupTable
                sb.Append("FileType text); ");                          //  .txt / .doc / etc

                ExecSQLCommand(sb.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void CreateFileIndexTable()
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("create table FileIndex ( ");
                sb.Append("FileId integer primary key, ");          // unique! (maybe use a guid?) 
                sb.Append("DriveId integer, ");                     // links to PhysicalDrives table
                sb.Append("PartitionId  integer, ");                // links to DrivePartitions table
                
                // File Details
                sb.Append("FileName text, ");                       // Name of the file ( e.g: someTxtfile )
                sb.Append("FileExtension text, ");                  // Extension of the file ( e.g: .txt )
                sb.Append("FilePath text, ");
                sb.Append("FileSize numeric, ");
                sb.Append("FileTypeId integer, ");                  // links to FileType table (pdf / txt / mp3 / etc )
                sb.Append("FileTag text, ");                        // User Specific Tags they can attach to a file for later searching
                sb.Append("FileHash text, ");
                sb.Append("UserComment text); ");                   // user comment

                ExecSQLCommand(sb.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
