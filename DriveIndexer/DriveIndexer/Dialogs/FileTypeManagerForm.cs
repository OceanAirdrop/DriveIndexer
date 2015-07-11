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
        public FileTypeManagerForm()
        {
            InitializeComponent();
        }

        private void FileTypeManagerForm_Load(object sender, EventArgs e)
        {

        }

        private void treeViewFileTypes_AfterSelect(object sender, TreeViewEventArgs e)
        {
            switch (e.Node.Name)
            {
                case "Everything":
                    AddCheckBoxes("Everything");
                    break;

                default:
                    break;
            }
        }

        private void AddCheckBoxes(string area)
        {
            flowLayoutPanel1.Controls.Clear();

            AddCheckBoxControl("one", true);
            AddCheckBoxControl("two", true);
            AddCheckBoxControl("three", false);
            AddCheckBoxControl("four", false);


            //foreach (var section in ECPManager.currentReport_.sectionList_)
            //{
            //    AddCheckBoxControl(section.SectionName, true);
            //}
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
    }
}
