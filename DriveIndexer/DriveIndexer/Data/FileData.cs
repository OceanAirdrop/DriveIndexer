using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveIndexer.Data
{
    public class FileData
    {
        public string FileName { get; set; }
        public string FileExtension { get; set; }
        public string FilePath { get; set; }
        public string FileSize { get; set; }
        public string FileTypeId { get; set; }
        public string FileUserComment { get; set; }
        public string DiskName { get; set; }
    }
}
