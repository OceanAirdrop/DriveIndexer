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
    public partial class SelectDrivePartition : Form
    {
        PhysicalDriveData m_data;

        public List<string> m_driveLettersToScan = null;

        public SelectDrivePartition(PhysicalDriveData data)
        {
            InitializeComponent();

            m_data = data;
        }

        private void SelectDrivePartition_Load(object sender, EventArgs e)
        {
            labelStatus.Text = "";

            foreach( var partition in m_data.m_drivePartitions)
            {
                AddCheckBoxControl(partition);
            }

            labelDriveName.Text = string.Format("{0}", m_data.Name);
            labelDriveUserComment.Text = string.Format("{0}", m_data.UserComment);
            labelDriveModel.Text = string.Format("{0}", m_data.Model);
            labelDriveSize.Text = DriveInfoScanner.DriveSizeToGB(m_data.Size);
        }

        private void AddCheckBoxControl(DrivePartitionData data)
        {
            flowLayoutPanel1.AutoScroll = true;

            CheckBox cb = new CheckBox();
            cb.Text = string.Format("{0} ({1})", data.DeviceID, data.Name);
            cb.Checked = true;
            cb.AutoSize = true;

            // associate the fileType object with this tickbox.
            cb.Tag = data;

            // wire up the event handler when someone ticks/unticks the box.
            //cb.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);

            flowLayoutPanel1.Controls.Add(cb);
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            m_driveLettersToScan = new List<string>();

            foreach (var control in flowLayoutPanel1.Controls)
            {
                CheckBox cb = (CheckBox)control;
                if ( cb.Checked == true )
                {
                    DrivePartitionData partition = (DrivePartitionData)cb.Tag;
                    m_driveLettersToScan.Add(partition.DeviceID);
                }
            }
        }

        private void SelectDrivePartition_Shown(object sender, EventArgs e)
        {
            if (FileExplorer.CheckIfDriveAvailableToScan(m_data) == false)
            {
                labelStatus.Text = "Drive not available for scanning";
                buttonOK.Enabled = false;
            }
        }
    }
}
