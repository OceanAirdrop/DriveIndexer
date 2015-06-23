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

        System.Diagnostics.Stopwatch m_stopWatch = null;


        private void IndexFilesForm_Load(object sender, EventArgs e)
        {

            try
            {
                labelDriveLabel.Text = string.Format("{0} ({1})", m_driveToIndex.UserComment, m_driveToIndex.Model);

                StartBlinkLabel();

                // start scanning drive
                m_bgWorker = new BackgroundWorker();
                m_bgWorker.DoWork += WorkerThread;
                m_bgWorker.RunWorkerAsync("");

                // Create new stopwatch.
                m_stopWatch = System.Diagnostics.Stopwatch.StartNew();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        void WorkerThread(object sender, DoWorkEventArgs e)
        {
            try
            {
                FileExplorer.Initialise();
                FileExplorer.InjectUserInterfaceManager(this);

                foreach (var logicalDrive in m_driveToIndex.m_drivePartitions)
                {
                    try
                    {
                        FileExplorer.ScanDrive(logicalDrive);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    
                }

                StopBlinkLabel();

                ThreadSafe(delegate
                {
                    //labelScanningFiles.Text = "Finished Scanning Drive!";
                    listBox1.Items.Insert(0, "Finished!");
                });

                MessageBox.Show("Finished Scan!");
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                //this.Invoke(new Action(this.buttonOK_Click()));

                //MessageBox.Show("Finished Scan!");
                //this.Close();

                m_stopWatch.Stop();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            
            
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
            try
            {
                ThreadSafe(delegate
                {
                    // do UI related work here
                    listBox1.Items.Insert(0, message);

                    if (listBox1.Items.Count > 1000)
                        listBox1.Items.RemoveAt(1000);

                    //Console.WriteLine("Time elapsed: {0}", m_stopWatch.Elapsed);
                    //m_stopWatch.Elapsed
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            
        }


        public void OutputFileIndexCount(UInt64 count)
        {
            try
            {
                ThreadSafe(delegate
                {
                    labelFileIndexCount.Text = string.Format("File Index Count: {0}", count.ToString("N0"));
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void OutputCurrentDirectoryBeingScanned(string dir)
        {
            try
            {
                ThreadSafe(delegate
                {
                    labelCurrentDirectory.Text = string.Format("Scanning: {0}", dir.Replace("\\", "\\ "));
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void StartBlinkLabel()
        {
            try
            {
                if (m_blankTimer != null)
                    m_blankTimer.Stop();

                m_blankTimer = new Timer();
                m_blankTimer.Tick += new EventHandler(BlinkFilterTextEvent);
                m_blankTimer.Interval = 1000;
                m_blankTimer.Enabled = true;
                m_blankTimer.Start();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void StopBlinkLabel()
        {
            try
            {
                if (m_blankTimer != null)
                    m_blankTimer.Stop();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        private void BlinkFilterTextEvent(object sender, EventArgs e)
        {
            try
            {
                //if (labelScanningFiles.ForeColor == Color.Red)
                //    labelScanningFiles.ForeColor = Color.White;
                //else
                //    labelScanningFiles.ForeColor = Color.Red;

                labelTimeElapsed.Text = string.Format("Time Elapsed: {0}:{1}:{2}", m_stopWatch.Elapsed.Hours.ToString("00"), m_stopWatch.Elapsed.Minutes.ToString("00"), m_stopWatch.Elapsed.Seconds.ToString("00"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
