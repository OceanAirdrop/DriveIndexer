using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveIndexer.Data
{
    public class FileGroupData
    {
        public string m_fileGroupId;
        public string m_fileGroupName;

        public List<FileTypeData> m_fileTypeList = new List<FileTypeData>();
    }

    public class FileTypeData
    {
        public string m_fileTypeId;
        public string m_fileGroupId;
        public string m_fileType;
        public string m_fileTypeDesc;
        public string m_includeInDriveScan;


        public FileTypeData()
        {
        }

        public FileTypeData(string fileGroupId, string fileTypeId, string fileType, string fileDesc)
        {
            m_fileGroupId = fileGroupId;
            m_fileTypeId = fileTypeId;
            m_fileType = fileType;
            m_fileTypeDesc = fileDesc;
        }

        public FileTypeData(string fileType, string fileDesc)
        {
            m_fileType = fileType;
            m_fileTypeDesc = fileDesc;
        }
    }
}
