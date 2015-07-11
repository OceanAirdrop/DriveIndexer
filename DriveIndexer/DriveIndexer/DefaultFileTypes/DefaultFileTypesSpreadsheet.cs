using DriveIndexer.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveIndexer.Database
{
    public class DefaultFileTypesSpreadsheet
    {
        // http://fileinfo.com/filetypes/video
        public static List<FileTypeData> DefaultTypes()
        {
            List<FileTypeData> fileTypes = new List<FileTypeData>();

            fileTypes.Add(new FileTypeData(".nb", "Mathematica Notebook"));
            fileTypes.Add(new FileTypeData(".xltx", "Excel Open XML Spreadsheet Template"));
            fileTypes.Add(new FileTypeData(".xlsm", "Excel Open XML Macro-Enabled Spreadsheet"));
            fileTypes.Add(new FileTypeData(".xlsb", "Excel Binary Spreadsheet"));
            fileTypes.Add(new FileTypeData(".xltm", "Excel Open XML Macro-Enabled Spreadsheet Template"));
            fileTypes.Add(new FileTypeData(".ots", "OpenDocument Spreadsheet Template"));
            fileTypes.Add(new FileTypeData(".xls", "Excel Spreadsheet"));
            fileTypes.Add(new FileTypeData(".edx", "Edraw XML FIle"));
            fileTypes.Add(new FileTypeData(".gnumeric", "Gnumeric Spreadsheet"));
            fileTypes.Add(new FileTypeData(".dex", "Excel Spreadsheet"));
            fileTypes.Add(new FileTypeData(".xlsx", "Microsoft Excel Open XML Spreadsheet"));
            fileTypes.Add(new FileTypeData(".rdf", "Report Definition File"));
            fileTypes.Add(new FileTypeData(".gsheet", "Google Drive Spreadsheet"));
            fileTypes.Add(new FileTypeData(".xlr", "Works Spreadsheet"));
            fileTypes.Add(new FileTypeData(".sdc", "Apache OpenOffice Calc Spreadsheet"));
            fileTypes.Add(new FileTypeData(".fp", "FileMaker Pro Spreadsheet"));
            fileTypes.Add(new FileTypeData(".ods", "OpenDocument Spreadsheet"));
            fileTypes.Add(new FileTypeData(".pmd", "PlanMaker Spreadsheet"));
            fileTypes.Add(new FileTypeData(".numbers", "Numbers Spreadsheet File"));
            fileTypes.Add(new FileTypeData(".xl", "Excel Spreadsheet"));
            fileTypes.Add(new FileTypeData("0", "123	Lotus 1-2-3 Spreadsheet"));
            fileTypes.Add(new FileTypeData(".qpw", "Quattro Pro Spreadsheet"));
            fileTypes.Add(new FileTypeData(".tmv", "TimeMap Visual"));
            fileTypes.Add(new FileTypeData(".aws", "Ability Spreadsheet File"));
            fileTypes.Add(new FileTypeData(".edxz", "Edraw Compressed XML FIle"));
            fileTypes.Add(new FileTypeData(".fods", "OpenDocument Flat XML Spreadsheet"));
            fileTypes.Add(new FileTypeData(".gnm", "Gnumeric Spreadsheet"));
            fileTypes.Add(new FileTypeData(".ncss", "NCSS Dataset File"));
            fileTypes.Add(new FileTypeData(".number", "-tef	Numbers iCloud Document"));
            fileTypes.Add(new FileTypeData(".uos", "Uniform Office Spreadsheet"));
            fileTypes.Add(new FileTypeData(".xar", "Excel Auto-Recovery File"));
            fileTypes.Add(new FileTypeData(".wks", "Lotus 1-2-3 Spreadsheet"));
            fileTypes.Add(new FileTypeData(".ess", "EasySpreadsheet Spreadsheet"));
            fileTypes.Add(new FileTypeData(".imp", "Improv Spreadsheet"));
            fileTypes.Add(new FileTypeData(".xlshtml", "Microsoft Excel HTML Spreadsheet"));
            fileTypes.Add(new FileTypeData(".sxc", "StarOffice Calc Spreadsheet"));
            fileTypes.Add(new FileTypeData(".ast", "Ability Spreadsheet Template"));
            fileTypes.Add(new FileTypeData(".bks", "Microsoft Works Spreadsheet Backup File"));
            fileTypes.Add(new FileTypeData(".def", "SmartWare II Data File"));
            fileTypes.Add(new FileTypeData(".dfg", "Data Flask Grid File"));
            fileTypes.Add(new FileTypeData(".fm", "FileMaker Database"));
            fileTypes.Add(new FileTypeData(".mar", "Mariner Calc Spreadsheet"));
            fileTypes.Add(new FileTypeData(".nmbtemplate", "Numbers Spreadsheet Template"));
            fileTypes.Add(new FileTypeData(".pmv", "PlanMaker Spreadsheet Template"));
            fileTypes.Add(new FileTypeData(".stc", "StarOffice Calc Spreadsheet Template"));
            fileTypes.Add(new FileTypeData(".tmvt", "TimeMap Template"));
            fileTypes.Add(new FileTypeData(".fcs", "First Choice Spreadsheet"));
            fileTypes.Add(new FileTypeData(".xlsmhtml", "Microsoft Excel MIME HTML Spreadsheet"));
            fileTypes.Add(new FileTypeData(".wks", "Works Spreadsheet"));
            fileTypes.Add(new FileTypeData(".dis", "Oracle Discoverer Workbook"));
            fileTypes.Add(new FileTypeData(".wki", "Lotus 2 Worksheet"));
            fileTypes.Add(new FileTypeData(".wku", "Lotus 1-2-3 Spreadsheet"));
            fileTypes.Add(new FileTypeData(".wq1", "Quattro Pro for DOS Spreadsheet File"));
            fileTypes.Add(new FileTypeData(".wq2", "Quattro Pro for DOS Spreadsheet File"));
            fileTypes.Add(new FileTypeData(".xlthtml", "Microsoft Excel HTML Spreadsheet Template"));


            return fileTypes;
        }
    }
}
