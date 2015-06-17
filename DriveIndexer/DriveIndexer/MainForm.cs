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

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LocalSqllite.CreateNewSQLLiteDatabase();    

            SetupDataGridView( dataGridViewDrives );

            PopulateDriveList();
            PopulateListView(m_physicalDriveList);
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
            FileExplorer.ScanAll();
        }

        private void buttonRefreshDriveInfo_Click(object sender, EventArgs e)
        {
            PopulateDriveList();
            PopulateListView(m_physicalDriveList);
        }

        private void PopulateDriveList()
        {
            m_physicalDriveList = DriveInfoScanner.ScanDrives();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PopulateDriveList();

            PopulateListView( m_physicalDriveList );
        }

        private void PopulateListView( List<PhysicalDriveData> driveList )
        {
            dataGridViewDrives.Rows.Clear();

            foreach ( var drive in driveList )
            {
                AddPhysicialDriveToDataGridView( dataGridViewDrives, drive );
            }
        }

        private void AddPhysicialDriveToDataGridView( DataGridView dgv, PhysicalDriveData driveData )
        {
            int nNewRow = dgv.Rows.Add();
            int nColCount = 0;

            dgv.Rows[nNewRow].Cells[nColCount++].Value = driveData.SerialNumber;
            dgv.Rows[nNewRow].Cells[nColCount++].Value = driveData.Model;
            dgv.Rows[nNewRow].Cells[nColCount++].Value = driveData.InterfaceType;
            dgv.Rows[nNewRow].Cells[nColCount++].Value = driveData.Partitions;
            dgv.Rows[nNewRow].Cells[nColCount++].Value = driveData.Size;
        }

        private void buttonIndexFiles_Click(object sender, EventArgs e)
        {
            if (m_physicalDriveList == null )
                PopulateDriveList();

            foreach (var drive in m_physicalDriveList)
            {
                foreach (var logicalDrive in drive.m_drivePartitions)
                {
                    FileExplorer.ScanDrive(logicalDrive.Caption);
                }
            }
        }


    }
}
