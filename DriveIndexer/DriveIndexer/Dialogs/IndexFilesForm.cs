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
    public partial class IndexFilesForm : Form, IFileExplorerUIManager
    {
        private BackgroundWorker m_bgWorker = null;

        PhysicalDriveData m_driveToIndex = null;

        private Timer m_blankTimer;

        public IndexFilesForm( PhysicalDriveData drive )
        {
            m_driveToIndex = drive;

            InitializeComponent();
        }
        
        // Helper function for any UI related work
        protected virtual void ThreadSafe(MethodInvoker method)
        {
            try
            {
                if (InvokeRequired)
                    Invoke(method);
                else
                    method();
            }
            catch (Exception)
            {
            }
        }

        private void IndexFilesForm_Load(object sender, EventArgs e)
        {
            labelDriveLabel.Text = m_driveToIndex.Model;

            StartBlinkLabel();

            // start scanning drive
            m_bgWorker = new BackgroundWorker();
            m_bgWorker.DoWork += WorkerThread;
            m_bgWorker.RunWorkerAsync("");
        }

        void WorkerThread(object sender, DoWorkEventArgs e)
        {
            FileExplorer.Initialise();
            FileExplorer.InjectUserInterfaceManager(this);

            foreach (var logicalDrive in m_driveToIndex.m_drivePartitions)
            {
                FileExplorer.ScanDrive(logicalDrive);
            }

            StopBlinkLabel();

            ThreadSafe(delegate
            {
                labelScanningFiles.Text = "Finished Scanning Drive!";
                listBox1.Items.Insert(0, "Finished!");
            });

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            //this.Invoke(new Action(this.buttonOK_Click()));

            //MessageBox.Show("Finished Scan!");
            //this.Close();
            
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult dlgRes = MessageBox.Show("Are you sure you want to cancel the drive scan", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlgRes == DialogResult.No)
            {
                this.DialogResult = System.Windows.Forms.DialogResult.None;
                return;
            }

            FileExplorer.bCancelProcess = true;


        }



        public void OutputFileScanned(string message)
        {
            ThreadSafe(delegate
            {
                // do UI related work here
                listBox1.Items.Insert(0,message);

                if (listBox1.Items.Count > 1000)
                    listBox1.Items.RemoveAt(1000);
            });
        }


        public void OutputFileIndexCount(UInt64 count)
        {
            ThreadSafe(delegate
            {
                labelFileIndexCount.Text = string.Format("File Index Count: {0}", count.ToString("N0"));
            });
        }

        public void OutputCurrentDirectoryBeingScanned(string dir)
        {
            ThreadSafe(delegate
            {
                labelCurrentDirectory.Text = string.Format("Current Directory: {0}", dir);
            });
        }

        private void StartBlinkLabel()
        {
            if (m_blankTimer != null)
                m_blankTimer.Stop();

            m_blankTimer = new Timer();
            m_blankTimer.Tick += new EventHandler(BlinkFilterTextEvent);
            m_blankTimer.Interval = 621;
            m_blankTimer.Enabled = true;
            m_blankTimer.Start();
        }

        private void StopBlinkLabel()
        {
            if (m_blankTimer != null)
                m_blankTimer.Stop();
        }


        private void BlinkFilterTextEvent(object sender, EventArgs e)
        {
            if (labelScanningFiles.ForeColor == Color.Red)
                labelScanningFiles.ForeColor = Color.White;
            else
                labelScanningFiles.ForeColor = Color.Red;
        }
    }
}
