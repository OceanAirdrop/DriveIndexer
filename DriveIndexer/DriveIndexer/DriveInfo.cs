using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace DriveIndexer
{
    public static class DriveInfoScanner
    {
        const int IdenentSize = 3;

        public static List<PhysicalDriveData> ScanDrives()
        {
            List<PhysicalDriveData> driveList = new List<PhysicalDriveData>();

            //var sb = new StringBuilder();

            var diskDriveManagement = new ManagementClass("Win32_DiskDrive");
            var diskDriveInstanceObjectCollection = diskDriveManagement.GetInstances();

            foreach (ManagementObject diskDriveInstanceObject in diskDriveInstanceObjectCollection)
            {
                PhysicalDriveData driveData = new PhysicalDriveData();

                //sb.AppendLine(DumpProperties(diskDriveInstanceObject, 0));

                driveData.Caption = GetProperty(diskDriveInstanceObject, "Caption");
                driveData.InterfaceType = GetProperty(diskDriveInstanceObject, "InterfaceType");
                driveData.Manufacturer = GetProperty(diskDriveInstanceObject, "Manufacturer");
                driveData.MediaType = GetProperty(diskDriveInstanceObject, "MediaType");
                driveData.Model = GetProperty(diskDriveInstanceObject, "Model");
                driveData.Partitions = GetProperty(diskDriveInstanceObject, "Partitions");
                driveData.SerialNumber = GetProperty(diskDriveInstanceObject, "SerialNumber");
                driveData.Size = GetProperty(diskDriveInstanceObject, "Size");

                foreach (ManagementObject diskPartitionObject in diskDriveInstanceObject.GetRelated("Win32_DiskPartition"))
                {
                    //sb.AppendLine(DumpProperties(diskPartitionObject, 1));

                    foreach (ManagementBaseObject logicalDiskObject in diskPartitionObject.GetRelated("Win32_LogicalDisk"))
                    {
                        DrivePartitionData partitionData = new DrivePartitionData();

                        partitionData.Caption = GetProperty(logicalDiskObject, "Caption");
                        partitionData.CreationClassName = GetProperty(logicalDiskObject, "CreationClassName");
                        partitionData.Description = GetProperty(logicalDiskObject, "Description");
                        partitionData.DeviceID = GetProperty(logicalDiskObject, "DeviceID");
                        partitionData.DriveType = GetProperty(logicalDiskObject, "DriveType");
                        partitionData.FileSystem = GetProperty(logicalDiskObject, "FileSystem");
                        partitionData.FreeSpace = GetProperty(logicalDiskObject, "FreeSpace");
                        partitionData.MediaType = GetProperty(logicalDiskObject, "MediaType");
                        partitionData.Name = GetProperty(logicalDiskObject, "Name");
                        partitionData.Size = GetProperty(logicalDiskObject, "Size");
                        partitionData.VolumeSerialNumber = GetProperty(logicalDiskObject, "VolumeSerialNumber");

                        driveData.m_drivePartitions.Add(partitionData);
                        //sb.AppendLine(DumpProperties(logicalDiskObject, 2));
                    }
                }

                driveList.Add(driveData);
            }

            //sb.AppendLine();
            //Console.WriteLine(sb.ToString());

            return driveList;
        }

        static string GetProperty(ManagementBaseObject managementObject, string property )
        {
            string value = "";
            var properties = managementObject.Properties;
            foreach (var prop in properties)
            {
                if (prop != null && prop.Value != null)
                {
                    if (prop.Name == property)
                    {
                        value = prop.Value.ToString();
                        break;
                    }
                }
            }
            return value;
        }

        static String DumpProperties(ManagementBaseObject managementObject, int level)
        {
            var padd = "".PadLeft(level * IdenentSize);
            var sb = new StringBuilder();

            sb.AppendFormat(
                @"
                {0}========================================
                {0}    {1}
                {0}========================================
                ",
            padd, managementObject["Name"]);
            sb.AppendLine();

            var properties = managementObject.Properties;
            foreach (var prop in properties)
            {
                if (prop != null && prop.Value != null)
                {
                    if (prop.IsArray)
                    {
                        Array valuelist = prop.Value as Array;
                        sb.AppendFormat("{0}{1}:", padd, prop.Name);
                        sb.AppendLine();
                        foreach (var val in valuelist)
                        {
                            sb.AppendFormat("{0}   {1}", padd, val);
                            sb.AppendLine();
                        }
                    }
                    else
                    {
                        sb.AppendFormat("{0}{1}: {2}", padd, prop.Name, prop.Value);
                        sb.AppendLine();
                    }
                }
            }
            return sb.ToString();
        }
    }
}
