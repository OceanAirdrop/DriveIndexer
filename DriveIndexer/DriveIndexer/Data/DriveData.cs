using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveIndexer
{
    public class PhysicalDriveData
    {
        public string DriveId { get; set; }              // id
        public string Caption { get; set; }         // Hitachi HTS725032A9A364
        public string InterfaceType { get; set; }   // IDE
        public string Manufacturer { get; set; }    // (Standard disk drives)
        public string MediaType { get; set; }       // Fixed hard disk media
        public string Model { get; set; }           // Hitachi HTS725032A9A364
        public string Partitions { get; set; }      // 2
        public string SerialNumber { get; set; }    // 019022CPCK00PBPGM0KU
        public string Size { get; set; }            // 320070320640
        public string UserComment { get; set; }     // ?
        
        public List<DrivePartitionData> m_drivePartitions = new List<DrivePartitionData>();
    }

    public class DrivePartitionData
    {
        public string PartitionId { get; set; }                  // id
        public string DriveId { get; set; }                  // id
        public string Caption { get; set; }             // C:
        public string CreationClassName { get; set; }   // Win32_LogicalDisk
        public string Description { get; set; }         // Local Fixed Disk
        public string DeviceID { get; set; }            // C:
        public string DriveType { get; set; }           // 3
        public string FileSystem { get; set; }          // NTFS
        public string FreeSpace { get; set; }           // 166468071424
        public string MediaType { get; set; }           // 12
        public string Name { get; set; }                // C:
        public string Size { get; set; }                // 319547240448
        public string VolumeSerialNumber { get; set; }  // D2A94F5F
        public string UserComment { get; set; }     // ?

        public PhysicalDriveData PhysicalDrive { get; set; }
    }
}
