using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DriveIndexer.Dialogs
{
    public partial class AboutBoxForm : Form
    {
        public AboutBoxForm()
        {
            InitializeComponent();
        }

        private void AboutBoxForm_Load(object sender, EventArgs e)
        {
            DateTime lastWriteTime = new FileInfo(Assembly.GetExecutingAssembly().Location).LastWriteTime;
            string buildDate = string.Format("Build Date: {0}", lastWriteTime);

            labelBuildDate.Text = buildDate;
        }

        private void linkLabelGithub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/OceanAirdrop");
        }
    }
}
