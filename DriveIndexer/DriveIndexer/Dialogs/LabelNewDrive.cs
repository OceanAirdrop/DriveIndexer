﻿using System;
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
    public partial class LabelNewDrive : Form
    {
        public PhysicalDriveData m_driveData = null;
        public string m_userDescription = "";

        public LabelNewDrive()
        {
            InitializeComponent();
        }

        private void LabelNewDrive_Load(object sender, EventArgs e)
        {
            textBoxModel.Text = m_driveData.Model;
            textBoxPartitions.Text = m_driveData.Partitions;
            textBoxSerial.Text = m_driveData.SerialNumber;
            textBoxType.Text = m_driveData.InterfaceType;
            textBoxSize.Text = m_driveData.Size;

            if (m_driveData.InterfaceType == "IDE")
            {
                textBoxUserDescription.Text = "Internal computer harddisk";
            }
            else
            {
                foreach (var drivePartition in m_driveData.m_drivePartitions)
                {
                    if (string.IsNullOrEmpty(drivePartition.Name) == false)
                    {
                        textBoxUserDescription.Text = drivePartition.Name;
                        break;
                    }
                }
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            m_userDescription = textBoxUserDescription.Text;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {

        }
    }
}