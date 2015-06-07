using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace DriveIndexer
{
    public static class DriveInfo
    {
        const int IdenentSize = 3;
        
        public static void ScanDrives()
        {
            var sb = new StringBuilder();

            var diskDriveManagement = new ManagementClass("Win32_DiskDrive");
            var diskDriveInstanceObjectCollection = diskDriveManagement.GetInstances();

            foreach (ManagementObject diskDriveInstanceObject in diskDriveInstanceObjectCollection)
            {
                sb.AppendLine(DumpProperties(diskDriveInstanceObject, 0));
                foreach (ManagementObject diskPartitionObject in diskDriveInstanceObject.GetRelated("Win32_DiskPartition"))
                {
                    sb.AppendLine(DumpProperties(diskPartitionObject, 1));
                    foreach (ManagementBaseObject logicalDiskObject in diskPartitionObject.GetRelated("Win32_LogicalDisk"))
                    {
                        sb.AppendLine(DumpProperties(logicalDiskObject, 2));
                    }
                }
            }

            sb.AppendLine();
            Console.WriteLine(sb.ToString());
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
