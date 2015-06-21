using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OceanAirdrop
{
    public interface IFileExplorerUIManager
    {
        void OutputFileScanned(string fileName);
        void OutputFileIndexCount(UInt64 count);
        void OutputCurrentDirectoryBeingScanned(string dir);
    }
}
