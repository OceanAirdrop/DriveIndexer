using DriveIndexer.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveIndexer.Database
{
    public class DefaulFileTypesEbook
    {
        // http://fileinfo.com/filetypes/video
        public static List<FileTypeData> DefaultTypes()
        {
            List<FileTypeData> fileTypes = new List<FileTypeData>();

            fileTypes.Add(new FileTypeData(".ebk", "eBook Pro eBook File"));
            fileTypes.Add(new FileTypeData(".azw", "Amazon Kindle eBook File"));
            //fileTypes.Add(new FileTypeData(".tpz", "Kindle Topaz eBook File"));
            //fileTypes.Add(new FileTypeData(".apnx", "Amazon Page Number Index File"));
            //fileTypes.Add(new FileTypeData(".lrs", "Librie Reader Source File"));
            //fileTypes.Add(new FileTypeData(".ncx", "EPUB Navigation Control XML File"));
            //fileTypes.Add(new FileTypeData(".aep", "Activ E-Book Project"));
            //fileTypes.Add(new FileTypeData(".nva", "NVA Document"));
            fileTypes.Add(new FileTypeData(".mobi", "Mobipocket eBook"));
            fileTypes.Add(new FileTypeData(".fb2", "FictionBook 2.0 File"));
            fileTypes.Add(new FileTypeData(".lrf", "Sony Portable Reader File"));
            fileTypes.Add(new FileTypeData(".prc", "Mobipocket eBook File"));
            fileTypes.Add(new FileTypeData(".azw4", "Amazon Print Replica eBook"));
            fileTypes.Add(new FileTypeData(".azw3", "Amazon KF8 eBook File"));
            fileTypes.Add(new FileTypeData(".lit", "eBook File"));
            fileTypes.Add(new FileTypeData(".epub", "Open eBook File"));
            fileTypes.Add(new FileTypeData(".ibooks", "Multi-Touch iBook"));
            fileTypes.Add(new FileTypeData(".dnl", "DNAML eBook File"));
            fileTypes.Add(new FileTypeData(".phl", "Kindle Popular Highlights File"));
            fileTypes.Add(new FileTypeData(".cbc", "Comic Book Collection"));
            //fileTypes.Add(new FileTypeData(".html0", "Book Designer File"));
            fileTypes.Add(new FileTypeData(".webz", "WEBZ Compressed eBook File"));
            fileTypes.Add(new FileTypeData(".opf", "Open Packaging Format File"));
            fileTypes.Add(new FileTypeData(".mbp", "Mobipocket Notes File"));
            //fileTypes.Add(new FileTypeData(".acsm", "Adobe Content Server Message File"));
            fileTypes.Add(new FileTypeData(".ceb", "Apabi eBook File"));
            //fileTypes.Add(new FileTypeData(".bkk", "BookBuddi eBook File"));
            //fileTypes.Add(new FileTypeData(".etd", "Adobe Reader EBX Transfer Data File"));
            //fileTypes.Add(new FileTypeData(".lrx", "Sony Portable Reader File"));
            //fileTypes.Add(new FileTypeData(".mart", "MartView eBook File"));
            //fileTypes.Add(new FileTypeData(".rzb", "Red Zion Book File"));
            //fileTypes.Add(new FileTypeData(".rzs", "Red Zion Security File"));
            //fileTypes.Add(new FileTypeData(".tcr", "Psion Series 3 eBook File"));
            //fileTypes.Add(new FileTypeData(".tk3", "TK3 Multimedia eBook"));
            //fileTypes.Add(new FileTypeData(".tr3", "TomeRaider eBook File"));
            //fileTypes.Add(new FileTypeData(".vbk", "VitalSource eBook"));
            //fileTypes.Add(new FileTypeData(".ybk", "YanCEyWare eBook"));
            //fileTypes.Add(new FileTypeData(".htz4", "HyperMaker 4 Publication"));
            //fileTypes.Add(new FileTypeData(".azw1", "Amazon Topaz eBook"));
            //fileTypes.Add(new FileTypeData(".htmlz", "Zipped HTML eBook"));
            //fileTypes.Add(new FileTypeData(".bpnueb", "PNU eBook File"));
            //fileTypes.Add(new FileTypeData(".ea", "Kindle End Actions File"));
            //fileTypes.Add(new FileTypeData(".eal", "Kindle End Actions File"));
            //fileTypes.Add(new FileTypeData(".edn", "Adobe eBook Activation File"));
            //fileTypes.Add(new FileTypeData(".htxt", "Hanvon eBook File"));
            //fileTypes.Add(new FileTypeData(".htz5", "HyperMaker 5 Publication"));
            fileTypes.Add(new FileTypeData(".oeb", "Open eBook File"));
            fileTypes.Add(new FileTypeData(".oebzip", "Zipped Open eBook File"));
            //fileTypes.Add(new FileTypeData(".pef", "PEF Braille Book File"));
            //fileTypes.Add(new FileTypeData(".pmlz", "Zipped Palm Markup Language File"));
            //fileTypes.Add(new FileTypeData(".pobi", "Kindle Touch Periodical File"));
            //fileTypes.Add(new FileTypeData(".qmk", "YanCEyDesktop Quickmarks File"));
            //fileTypes.Add(new FileTypeData(".fkb", "Flipkart eBook File"));
            //fileTypes.Add(new FileTypeData(".snb", "Shanda Bambook eBook"));
            //fileTypes.Add(new FileTypeData(".pml", "Palm Markup Language File"));
            //fileTypes.Add(new FileTypeData(".ava", "AvaaBook eBook"));
            //fileTypes.Add(new FileTypeData(".koob", "Koob E-Book File"));


            return fileTypes;
        }
    }
}
