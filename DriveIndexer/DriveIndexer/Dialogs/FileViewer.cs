using DriveIndexer.Data;
using OceanAirdrop;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DriveIndexer.Dialogs
{
    public partial class FileViewer : Form
    {
        int m_fileCount = 0;
        int m_limitRecordSet = 1000;
        int m_recordOffset = -100;

        public FileViewer()
        {
            InitializeComponent();
        }

        private void FileViewer_Load(object sender, EventArgs e)
        {
            SetupDataGridView(dataGridViewFiles);

            m_fileCount = Convert.ToInt32( LocalSqllite.ExecSQLCommandScalar("select count(*) from FileIndex") );

            string sql = GenerateSQL(true);
            PopulateListView(sql);
        }

        public void SetupDataGridView(DataGridView dgv)
        {
            // Setting the style of the DataGridView control
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9, FontStyle.Bold, GraphicsUnit.Point);
            dgv.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.ControlDark;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.DefaultCellStyle.Font = new Font("Tahoma", 8, FontStyle.Regular, GraphicsUnit.Point);
            dgv.DefaultCellStyle.BackColor = Color.Empty;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgv.AllowUserToAddRows = false;
        }

        private string GenerateSQL( bool bAdvanceForward )
        {
            if ( bAdvanceForward == true )
                m_recordOffset += m_limitRecordSet;
            else
                m_recordOffset -= m_limitRecordSet;

            return string.Format("select FileName, FileExtension, FilePath, FileSize, FileTypeId, a.UserComment as FileUserComment,b.UserComment as DiskName from FileIndex a,  PhysicalDrives b where a.DriveId = b.DriveId LIMIT {0} OFFSET {1}", m_limitRecordSet, m_recordOffset );
        }

        private void PopulateListView(string sql)
        {
            try
            {
                dataGridViewFiles.Rows.Clear();
                //"select FileName, FileExtension, FilePath, FileSize, FileTypeId, a.UserComment as FileUserComment,b.UserComment as DiskName from FileIndex a,  PhysicalDrives b where a.DriveId = b.DriveId";
                SQLiteCommand command = new SQLiteCommand(sql, LocalSqllite.m_sqlLiteConnection);
                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    FileData data = new FileData();
                    data.FileName           = reader["FileName"].ToString();
                    data.FileExtension      = reader["FileExtension"].ToString();
                    data.FilePath           = reader["FilePath"].ToString();
                    data.FileSize           = reader["FileSize"].ToString();
                    data.FileTypeId         = reader["FileTypeId"].ToString();
                    data.FileUserComment    = reader["FileUserComment"].ToString();
                    data.DiskName           = reader["DiskName"].ToString();

                    AddFileToDataGridView(dataGridViewFiles, data);
                }

                UpdateRecordLabel();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void AddFileToDataGridView(DataGridView dgv, FileData fileData)
        {
            int nNewRow = dgv.Rows.Add();
            int nColCount = 0;

            dgv.Rows[nNewRow].Cells[nColCount++].Value = fileData.FileName;
            dgv.Rows[nNewRow].Cells[nColCount++].Value = fileData.FileExtension;
            dgv.Rows[nNewRow].Cells[nColCount++].Value = fileData.FilePath;
            dgv.Rows[nNewRow].Cells[nColCount++].Value = fileData.FileSize;
            dgv.Rows[nNewRow].Cells[nColCount++].Value = fileData.FileTypeId;
            dgv.Rows[nNewRow].Cells[nColCount++].Value = fileData.FileUserComment;
            dgv.Rows[nNewRow].Cells[nColCount++].Value = fileData.DiskName;

            // Assosiate driveData with this row.
            //dgv.Rows[nNewRow].Tag = fileData;
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            string sql = GenerateSQL(false);
            PopulateListView(sql);
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            string sql = GenerateSQL(true);
            PopulateListView(sql);
        }

        private void UpdateRecordLabel()
        {
            //Display 1 to 100 of 1,000

            string str = string.Format("Display {0} to {1} of {2}", m_recordOffset, m_recordOffset + m_limitRecordSet, m_fileCount);
            labelRecordDisplay.Text = str;
        }
    }
}
