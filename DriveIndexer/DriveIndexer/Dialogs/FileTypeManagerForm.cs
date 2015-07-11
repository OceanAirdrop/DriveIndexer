using DriveIndexer.Data;
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
    public partial class FileTypeManagerForm : Form
    {
        List<string> m_treeSelections = new List<string>();

        List<string> m_sqlToExecute = new List<string>();

        public FileTypeManagerForm()
        {
            InitializeComponent();
        }

        private void FileTypeManagerForm_Load(object sender, EventArgs e)
        {
            treeViewFileTypes.Nodes.Clear();

            DoubleBuffered = true;

            List<FileGroupData> list = DBHelper.ReadFileGroupList( false, "" );

            foreach( var fileGroup in list)
            {
                System.Windows.Forms.TreeNode treeNode = new System.Windows.Forms.TreeNode(fileGroup.m_fileGroupName);
                treeNode.Name = fileGroup.m_fileGroupName.Replace(" ", "");
                treeNode.Text = fileGroup.m_fileGroupName;

                treeViewFileTypes.Nodes.Add(treeNode);

                m_treeSelections.Add(fileGroup.m_fileGroupName);

                if (fileGroup.m_fileGroupName.ToLower() == "documents")
                    AddCheckBoxes(fileGroup.m_fileGroupName);
            }
        }

        private void treeViewFileTypes_AfterSelect(object sender, TreeViewEventArgs e)
        {
            AddCheckBoxes(e.Node.Text);
           
        }

        private void AddCheckBoxes(string area)
        {
            flowLayoutPanel1.Controls.Clear();

            List<FileGroupData> list = DBHelper.ReadFileGroupList(true, area);

            foreach (var fileGroup in list)
            {
                foreach (var fileType in fileGroup.m_fileTypeList)
                {
                    AddCheckBoxControl(fileType);
                    //AddCheckBoxControl( string.Format("{0} ({1})",fileType.m_fileType, fileType.m_fileTypeDesc), true);

                    //break;
                }
            }

            //AddCheckBoxControl("one", true);
            //AddCheckBoxControl("two", true);
            //AddCheckBoxControl("three", false);
            //AddCheckBoxControl("four", false);


            //foreach (var section in ECPManager.currentReport_.sectionList_)
            //{
            //    AddCheckBoxControl(section.SectionName, true);
            //}
        }

        private void AddCheckBoxControl(FileTypeData fileType )
        {
            flowLayoutPanel1.AutoScroll = true;

            CheckBox cb = new CheckBox();
            cb.Text = string.Format("{0} ({1})", fileType.m_fileType, fileType.m_fileTypeDesc);
            cb.Checked = Convert.ToBoolean(Convert.ToInt32( fileType.m_includeInDriveScan) );
            cb.AutoSize = true;

            // associate the fileType object with this tickbox.
            cb.Tag = fileType;

            // wire up the event handler when someone ticks/unticks the box.
            cb.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);

            flowLayoutPanel1.Controls.Add(cb);
        }

        private void AddCheckBoxControl(string name, bool isVisible)
        {
            flowLayoutPanel1.AutoScroll = true;

            CheckBox cb = new CheckBox();
            cb.Text = name;
            cb.Checked = isVisible;
            cb.AutoSize = true;

            flowLayoutPanel1.Controls.Add(cb);
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;

            FileTypeData fileType = (FileTypeData)cb.Tag;

            string sql = string.Format("UPDATE FileType set IncludeInDriveScan = '{0}' where FileTypeId = '{1}'", Convert.ToInt32(cb.Checked), fileType.m_fileTypeId);

            m_sqlToExecute.Add(sql);
            //LocalSqllite.ExecSQLCommand(sql);
        }

        private void checkBoxEverything_CheckedChanged(object sender, EventArgs e)
        {
            foreach( var control in flowLayoutPanel1.Controls)
            {
                CheckBox cb = (CheckBox)control;
                cb.Checked = checkBoxEverything.Checked;
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            foreach (var sql in m_sqlToExecute)
            {
                LocalSqllite.ExecSQLCommand(sql);
            }

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
