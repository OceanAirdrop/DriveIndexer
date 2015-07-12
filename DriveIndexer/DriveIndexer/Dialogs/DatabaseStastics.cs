using OceanAirdrop;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DriveIndexer.Dialogs
{
    public partial class DatabaseStastics : Form
    {
        public DatabaseStastics()
        {
            InitializeComponent();
        }

        private void DatabaseStastics_Load(object sender, EventArgs e)
        {
            GetTotalFileCount();
            GetTotalFileTypes();
            GetTotalFileGroupType( "Documents", labelTotalDocuments );
            //GetTotalFileGroupType( "Spreadsheet", Label lbl );
            //GetTotalFileGroupType( "Ebook", Label lbl );
            //GetTotalFileGroupType( "Code", Label lbl );
            GetTotalFileGroupType( "Movies", labelTotalMovies );
            GetTotalFileGroupType( "Audio", labelTotalMusic );
            //GetTotalFileGroupType( "Games", Label lbl );
            GetTotalFileGroupType( "Image", labelTotalImages );
            //GetTotalFileGroupType( "System", Label lbl );
            //GetTotalFileGroupType( "Compressed", Label lbl );
            //GetTotalFileGroupType( "Executable", Label lbl );
            //GetTotalFileGroupType( "Unknown", Label lbl );

            GetTotalDriveSpace();

        }

        private void GetTotalDriveSpace()
        {
            string sql = "select sum(size) from PhysicalDrives";
            string result = LocalSqllite.ExecSQLCommandScalar(sql);

            result = DriveInfoScanner.DriveSizeToGB(result);

            labelTotalDriveSpace.Text = string.Format("Total Disk Space Across All Drives: \t\t{0}", result);
        }

        private void GetTotalFileCount()
        {
            string sql = "select count(*) from FileIndex";
            string result = LocalSqllite.ExecSQLCommandScalar(sql);
            labelTotalNumberOfFiles.Text = string.Format("Total Number of Files Scanned: \t\t{0}", result);
        }

        private void GetTotalFileTypes()
        {
            string sql = "select count(distinct(FileExtension)) from FileIndex";
            string result = LocalSqllite.ExecSQLCommandScalar(sql);
            labelFileTypes.Text = string.Format("Total Number of File Types: \t\t{0}", result);
        }

        private void GetTotalFileGroupType( string fileGroup, Label lbl )
        {
            string sql = string.Format("select count(*) from FileIndex where FileGroupId in ( select FileGroupId from FileGroup where FileGroupName = '{0}' )", fileGroup);
            string result = LocalSqllite.ExecSQLCommandScalar(sql);
            lbl.Text = string.Format("Total Number of {0} File Types: \t\t{1}", fileGroup, result);
        }
    }
}
