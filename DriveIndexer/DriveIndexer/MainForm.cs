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
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileExplorer.ScanAll();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var physicalDriveList = DriveInfoScanner.ScanDrives();

            foreach( var drive in physicalDriveList )
            {
                foreach ( var logicalDrive in drive.m_drivePartitions )
                {
                    FileExplorer.ScanDrive(logicalDrive.Caption);
                }
            }
           

            GetAllDiskDrives();
        }

        private void GetAllDiskDrives()
        {
            var searcher = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive");

            foreach (ManagementObject wmi_HD in searcher.Get())
            {
                HardDrive hd = new HardDrive();
                hd.Model = wmi_HD["Model"].ToString();
                hd.InterfaceType = wmi_HD["InterfaceType"].ToString();
                hd.Caption = wmi_HD["Caption"].ToString();

                hd.SerialNo = wmi_HD.GetPropertyValue("SerialNumber").ToString();//get the serailNumber of diskdrive

                //hdCollection.Add(hd);
            }

        }


    }

    public class HardDrive
    {
        public string Model { get; set; }
        public string InterfaceType { get; set; }
        public string Caption { get; set; }
        public string SerialNo { get; set; }
    }
}
