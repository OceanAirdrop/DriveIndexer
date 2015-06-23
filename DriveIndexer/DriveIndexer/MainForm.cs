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
                    LabelNewDrive dlg = new LabelNewDrive();
                    dlg.m_driveData = drive;

                    if ( dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK )
                    {
                        drive.UserComment = dlg.m_userDescription;
                    }
                }

            }

            // Add the current drives to the sqllite database
            DBHelper.PopulatePhyicalDriveTable(currentDrives);
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
        }

        private void AddPhysicialDriveToDataGridView( DataGridView dgv, PhysicalDriveData driveData )
        {
            int nNewRow = dgv.Rows.Add();
            int nColCount = 0;
            dgv.Rows[nNewRow].Cells[nColCount++].Value = driveData.DriveScanned;
            dgv.Rows[nNewRow].Cells[nColCount++].Value = driveData.UserComment;
            dgv.Rows[nNewRow].Cells[nColCount++].Value = driveData.SerialNumber;
            dgv.Rows[nNewRow].Cells[nColCount++].Value = driveData.Model;
            dgv.Rows[nNewRow].Cells[nColCount++].Value = driveData.InterfaceType;
            dgv.Rows[nNewRow].Cells[nColCount++].Value = driveData.Partitions;
            dgv.Rows[nNewRow].Cells[nColCount++].Value = driveData.Size;
            dgv.Rows[nNewRow].Cells[nColCount++].Value = driveData.DriveScannedDate;

            // Assosiate driveData with this row.
            dgv.Rows[nNewRow].Tag = driveData;
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

           if ( FileExplorer.CheckIfDriveAvailableToScan(m_dgvSelectedDrive) == false )
           {
               MessageBox.Show("The selected drive/usb is not available to scan");
               return;
           }

           DialogResult dlgRes = MessageBox.Show(string.Format("Are you sure you want to scan the drive: {0} Model: {1}", m_dgvSelectedDrive.UserComment, m_dgvSelectedDrive.Model), "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlgRes == DialogResult.No)
            {
                return;
            }

            IndexFilesForm dlg = new IndexFilesForm(m_dgvSelectedDrive);
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

        private void dataGridViewDrives_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

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
            FileViewer dlg = new FileViewer();
            dlg.ShowDialog();
        }


    }
}
