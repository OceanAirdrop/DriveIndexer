using DriveIndexer.Dialogs;
using OceanAirdrop;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DriveIndexer
{
    public partial class MainForm : Form
    {
        List<PhysicalDriveData> m_physicalDriveList = null;

        PhysicalDriveData m_dgvSelectedDrive = null;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LocalSqllite.CreateNewSQLLiteDatabase();    

            SetupDataGridView( dataGridViewDrives );

           // WriteCurrentDriveListToDatabase();

            PopulateListView();
        }

        private void SetupDataGridView(DataGridView dgv)
        {
            dgv.RowHeadersVisible = false;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9, FontStyle.Bold, GraphicsUnit.Point);
            dgv.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.ControlDark;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.DefaultCellStyle.Font = new Font("Tahoma", 8, FontStyle.Regular, GraphicsUnit.Point);
            dgv.DefaultCellStyle.BackColor = Color.Empty;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgv.AllowUserToAddRows = false;
                dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //else
            //    dgv.SelectionMode = DataGridViewSelectionMode.CellSelect;
        }

        //public void SetupDataGridView(DataGridView dgv)
        //{
        //    // Setting the style of the DataGridView control
        //    dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9, FontStyle.Bold, GraphicsUnit.Point);
        //    dgv.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.ControlDark;
        //    dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
        //    dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        //    dgv.DefaultCellStyle.Font = new Font("Tahoma", 8, FontStyle.Regular, GraphicsUnit.Point);
        //    dgv.DefaultCellStyle.BackColor = Color.Empty;
        //    dgv.CellBorderStyle = DataGridViewCellBorderStyle.Single;
        //    dgv.AllowUserToAddRows = false;
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            //FileExplorer.ScanAll();
        }

        private void buttonRefreshDriveInfo_Click(object sender, EventArgs e)
        {
            WriteCurrentDriveListToDatabase();
            PopulateListView();
        }

        private void WriteCurrentDriveListToDatabase()
        {
            List<PhysicalDriveData> currentDrives = DriveInfoScanner.ScanDrives();

            foreach (var drive in currentDrives)
            {
                string driveId = DBHelper.CheckDriveIdExists(drive);
                if ( driveId == "")
                {
                    // this is a new drive we have not seen before! Lets get a label/description for it.
                    LabelNewDrive dlg = new LabelNewDrive(drive);
                    dlg.ShowDialog();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WriteCurrentDriveListToDatabase();

            PopulateListView();
        }

        private void PopulateListView( )
        {
            m_physicalDriveList = DBHelper.ReadDriveList();

            dataGridViewDrives.Rows.Clear();

            foreach (var drive in m_physicalDriveList)
            {
                AddPhysicialDriveToDataGridView( dataGridViewDrives, drive );

                // set this drive as the selected drive!
                m_dgvSelectedDrive = drive;
            }

            // Unselect all rows in datagridview
            dataGridViewDrives.ClearSelection();
        }

        private void AddPhysicialDriveToDataGridView( DataGridView dgv, PhysicalDriveData driveData )
        {
            int nNewRow = dgv.Rows.Add();
            int nColCount = 0;

            if (driveData.DriveScanned == "0" || driveData.DriveScanned == "") // ugly!! 
                dgv.Rows[nNewRow].Cells[nColCount++].Value = DriveIndexer.Properties.Resources.Button_Close_icon24;
            else
                dgv.Rows[nNewRow].Cells[nColCount++].Value = DriveIndexer.Properties.Resources.Button_Check_icon24;

            dgv.Rows[nNewRow].Cells[nColCount++].Value = driveData.Name;
            dgv.Rows[nNewRow].Cells[nColCount++].Value = driveData.UserComment;
            dgv.Rows[nNewRow].Cells[nColCount++].Value = driveData.SerialNumber;
            dgv.Rows[nNewRow].Cells[nColCount++].Value = driveData.Model;
            dgv.Rows[nNewRow].Cells[nColCount++].Value = driveData.InterfaceType;
            dgv.Rows[nNewRow].Cells[nColCount++].Value = driveData.Partitions;
            dgv.Rows[nNewRow].Cells[nColCount++].Value = DriveInfoScanner.DriveSizeToGB(driveData.Size);
            dgv.Rows[nNewRow].Cells[nColCount++].Value = driveData.DriveScannedDate;

            // Assosiate driveData with this row.
            dgv.Rows[nNewRow].Tag = driveData;

            dgv.Rows[nNewRow].Height = 30;

            // make this RowNotInTableException readonly
            dgv.Rows[nNewRow].ReadOnly = true;

        }

        private void buttonIndexFiles_Click(object sender, EventArgs e)
        {
            if (m_physicalDriveList == null )
                WriteCurrentDriveListToDatabase();

            if (m_dgvSelectedDrive == null)
            {
                MessageBox.Show("Please select a drive from the list");
                return;
            }

            SelectDrivePartition selectPartition = new SelectDrivePartition(m_dgvSelectedDrive);
            if ( selectPartition.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                IndexFilesForm dlg = new IndexFilesForm(m_dgvSelectedDrive, selectPartition.m_driveLettersToScan);
                if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
                {
                    MessageBox.Show("Process was cancelled");
                }
                else
                {
                    DBHelper.UpdateDriveScannedStatus(m_dgvSelectedDrive);
                    PopulateListView();

                    MessageBox.Show("Scan completed successfully.");
                }
            }

            
        }

        private void dataGridViewDrives_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            var data = (PhysicalDriveData)dataGridViewDrives.Rows[e.RowIndex].Tag;

            LabelNewDrive dlg = new LabelNewDrive(data);
    
            if ( dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK )
            {
                // user migth have changed name or drive comment. Lets repopulate the view
                PopulateListView();
            }
        }

        private void dataGridViewDrives_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            m_dgvSelectedDrive = (PhysicalDriveData)dataGridViewDrives.Rows[e.RowIndex].Tag;
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            WriteCurrentDriveListToDatabase();
            PopulateListView();
        }

        private void buttonFileViewer_Click(object sender, EventArgs e)
        {
            return;

            FileViewer dlg = new FileViewer();
            dlg.ShowDialog();
        }

        private void buttonDatabaseStatistics_Click(object sender, EventArgs e)
        {
            DatabaseStastics dlg = new DatabaseStastics();
            dlg.ShowDialog();
        }

        private void buttonFileTypes_Click(object sender, EventArgs e)
        {
            FileTypeManagerForm dlg = new FileTypeManagerForm();
            dlg.ShowDialog();
        }

        private void buttonFileSearch_Click(object sender, EventArgs e)
        {
            FileSearch dlg = new FileSearch();
            dlg.ShowDialog();
        }

        private void pictureBoxHelp_Click(object sender, EventArgs e)
        {
            AboutBoxForm dlg = new AboutBoxForm();
            dlg.ShowDialog();
        }


    }
}
