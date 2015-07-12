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
            var list = SetupDefaultFileTypes(m_groupSelected);
            foreach( var type in list )
            {
                listBoxTypes.Items.Add(string.Format("{0}\t({1})", type.m_fileType, type.m_fileTypeDesc));
            }
        }

        public static List<FileTypeData> SetupDefaultFileTypes(string fileGroup)
        {
            List<FileTypeData> fileTypes = new List<FileTypeData>();

            switch (fileGroup)
            {
                case "Documents":
                    return DefaultFileTypesText.AllKnownTypes();
                    break;
                case "Spreadsheet":
                    return DefaultFileTypesSpreadsheet.AllKnownTypes();
                    break;
                case "Ebook":
                    return DefaulFileTypesEbook.AllKnownTypes();
                    break;
                case "Code":
                    return DefaultFileTypesCode.AllKnownTypes();
                    break;
                case "Movies":
                    return DefaultFileTypesVideo.AllKnownTypes();
                    break;
                case "Audio":
                    return DefaulFileTypesAudio.AllKnownTypes();
                    break;
                case "Image":
                    return DefaultFileTypesImage.AllKnownTypes();
                    break;
                case "Database":
                    return DefaultFileTypesDatabase.AllKnownTypes();
                    break;
                case "Compressed":
                    return DefaultFileTypesCompressed.AllKnownTypes();
                    break;
                case "Games":
                    return DefaultFileTypesGame.AllKnownTypes();
                    break;
                case "System":
                    return DefaultFileTypesSystem.AllKnownTypes();
                    break;
                case "Executable":
                    return DefaultFileTypesExecutable.AllKnownTypes();
                    break;

                default:
                    break;
            }

            return fileTypes;
        }
    }
}
