using DriveIndexer.Data;
using DriveIndexer.Database;
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
    public partial class AddFileTypeForm : Form
    {
        string m_groupSelected;

        public AddFileTypeForm(string group)
        {
            InitializeComponent();
            m_groupSelected = group;
        }

        private void AddFileTypeForm_Load(object sender, EventArgs e)
        {
            PopulateListBox();
        }

        private void PopulateListBox()
        {
            listBoxTypes.Items.Clear();
            var list = SetupDefaultFileTypes(m_groupSelected);
            foreach (var type in list)
            {
                if (string.IsNullOrEmpty(textBoxSearchTypes.Text) == true)
                {
                    listBoxTypes.Items.Add(string.Format("{0}\t\t({1})", type.m_fileType, type.m_fileTypeDesc));
                }
                else
                {
                    if ( type.m_fileType.Contains(textBoxSearchTypes.Text) == true )
                        listBoxTypes.Items.Add(string.Format("{0}\t\t({1})", type.m_fileType, type.m_fileTypeDesc));
                }
            }
        }

        public static List<FileTypeData> SetupDefaultFileTypes(string fileGroup)
        {
            List<FileTypeData> fileTypes = new List<FileTypeData>();

            switch (fileGroup)
            {
                case "Documents":
                    return DefaultFileTypesText.AllKnownTypes();
                case "Spreadsheet":
                    return DefaultFileTypesSpreadsheet.AllKnownTypes();
                case "Ebook":
                    return DefaulFileTypesEbook.AllKnownTypes();
                case "Code":
                    return DefaultFileTypesCode.AllKnownTypes();
                case "Movies":
                    return DefaultFileTypesVideo.AllKnownTypes();
                case "Audio":
                    return DefaulFileTypesAudio.AllKnownTypes();
                case "Image":
                    return DefaultFileTypesImage.AllKnownTypes();
                case "Database":
                    return DefaultFileTypesDatabase.AllKnownTypes();
                case "Compressed":
                    return DefaultFileTypesCompressed.AllKnownTypes();
                case "Games":
                    return DefaultFileTypesGame.AllKnownTypes();
                case "System":
                    return DefaultFileTypesSystem.AllKnownTypes();
                case "Executable":
                    return DefaultFileTypesExecutable.AllKnownTypes();
                default:
                    break;
            }

            return fileTypes;
        }

        private void textBoxSearchTypes_TextChanged(object sender, EventArgs e)
        {
            PopulateListBox();
        }
    }
}
