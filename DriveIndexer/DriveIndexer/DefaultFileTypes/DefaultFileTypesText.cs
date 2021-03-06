﻿using DriveIndexer.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveIndexer.Database
{
    public class DefaultFileTypesText
    {
        public static List<FileTypeData> AllKnownTypes()
        {
            List<FileTypeData> fileTypes = new List<FileTypeData>();
            fileTypes.Add(new FileTypeData(".save", "Nano Temporary Save File"));
            fileTypes.Add(new FileTypeData(".sub", "Subtitle File"));
            fileTypes.Add(new FileTypeData(".err", "Error Log File"));
            fileTypes.Add(new FileTypeData(".sty", "LaTeX Style"));
            fileTypes.Add(new FileTypeData(".log", "Log File"));
            fileTypes.Add(new FileTypeData(".mbox", "E-mail Mailbox File"));
            fileTypes.Add(new FileTypeData(".fdx", "Final Draft Document"));
            fileTypes.Add(new FileTypeData(".lst", "Data List"));
            fileTypes.Add(new FileTypeData(".wpd", "WordPerfect Document"));
            fileTypes.Add(new FileTypeData(".wtt", "Write! Document"));
            fileTypes.Add(new FileTypeData(".bad", "Exchange Badmail File"));
            fileTypes.Add(new FileTypeData(".bdr", "Exchange Non-Delivery Report Body File"));
            fileTypes.Add(new FileTypeData(".btd", "Business-in-a-Box Document"));
            fileTypes.Add(new FileTypeData(".docm", "Word Open XML Macro-Enabled Document"));
            fileTypes.Add(new FileTypeData(".dvi", "Device Independent Format File"));
            fileTypes.Add(new FileTypeData(".emlx", "Mail Message"));
            fileTypes.Add(new FileTypeData(".fadein", "Fade In Document"));
            fileTypes.Add(new FileTypeData(".fdr", "Final Draft Document"));
            fileTypes.Add(new FileTypeData(".flr", "Flare Decompiled ActionScript File"));
            fileTypes.Add(new FileTypeData(".frt", "FoxPro Report Memo"));
            fileTypes.Add(new FileTypeData(".kes", "Kurzweil 3000 Document"));
            fileTypes.Add(new FileTypeData(".klg", "Log File"));
            fileTypes.Add(new FileTypeData(".knt", "KeyNote Note File"));
            fileTypes.Add(new FileTypeData(".kon", "Yahoo! Widget XML File"));
            fileTypes.Add(new FileTypeData(".lis", "SQR Output File"));
            fileTypes.Add(new FileTypeData(".lxfml", "LEGO Digital Designer XML File"));
            fileTypes.Add(new FileTypeData(".mellel", "Mellel Word Processing Document"));
            fileTypes.Add(new FileTypeData(".mnt", "FoxPro Menu Memo"));
            fileTypes.Add(new FileTypeData(".mwd", "MarinerWrite Document"));
            fileTypes.Add(new FileTypeData(".mwp", "Lotus Word Pro SmartMaster File"));
            fileTypes.Add(new FileTypeData(".nfo", "Warez Information File"));
            fileTypes.Add(new FileTypeData(".safetext", "SafeText File"));
            fileTypes.Add(new FileTypeData(".apt", "Almost Plain Text File"));
            fileTypes.Add(new FileTypeData(".dsv", "DeSmuME Save File"));
            fileTypes.Add(new FileTypeData(".sam", "LMHOSTS Sample File"));
            fileTypes.Add(new FileTypeData(".wri", "Windows Write Document"));
            fileTypes.Add(new FileTypeData(".man", "Unix Manual"));
            fileTypes.Add(new FileTypeData(".saf", "SafeText File"));
            fileTypes.Add(new FileTypeData(".fbl", "CADfix Command Level Log File"));
            fileTypes.Add(new FileTypeData(".aim", "AIMMS ASCII Model File"));
            fileTypes.Add(new FileTypeData(".dropbox", "Dropbox Shared Folder Tracker"));
            fileTypes.Add(new FileTypeData(".lst", "FoxPro Documenting Wizard List"));
            fileTypes.Add(new FileTypeData(".dwd", "DavkaWriter File"));
            fileTypes.Add(new FileTypeData(".ans", "ANSI Text File"));
            fileTypes.Add(new FileTypeData(".gpd", "Generic Printer Description File"));
            fileTypes.Add(new FileTypeData(".hs", "Java HelpSet File"));
            fileTypes.Add(new FileTypeData(".rtfd", "Rich Text Format Directory File"));
            fileTypes.Add(new FileTypeData(".me", "Readme Text File"));
            fileTypes.Add(new FileTypeData(".upd", "Program Update Information"));
            fileTypes.Add(new FileTypeData(".diz", "Description in Zip File"));
            fileTypes.Add(new FileTypeData(".hht", "Help and Support Center HHT File"));
            fileTypes.Add(new FileTypeData(".prt", "Printer Output File"));
            fileTypes.Add(new FileTypeData(".doc", "WordPad Document"));
            fileTypes.Add(new FileTypeData(".dotm", "Word Open XML Macro-Enabled Document Template"));
            fileTypes.Add(new FileTypeData(".pwi", "Pocket Word Document"));
            fileTypes.Add(new FileTypeData(".qdl", "QDL Program"));
            fileTypes.Add(new FileTypeData(".tab", "Guitar Tablature File"));
            fileTypes.Add(new FileTypeData(".xdl", "Oracle Expert Definition Language File"));
            fileTypes.Add(new FileTypeData(".eit", "Yozo Office Template File"));
            fileTypes.Add(new FileTypeData(".epp", "EditPad Pro Project"));
            fileTypes.Add(new FileTypeData(".jp1", "Japanese (Romaji) Text File"));
            fileTypes.Add(new FileTypeData(".wps", "Microsoft Works Word Processor Document"));
            fileTypes.Add(new FileTypeData(".ris", "Research Information Systems Citation File"));
            fileTypes.Add(new FileTypeData(".vnt", "Mobile Phone vNote File"));
            fileTypes.Add(new FileTypeData(".asc", "Autodesk ASCII Export File"));
            fileTypes.Add(new FileTypeData(".cod", "Atlantis Word Processor Encrypted Document"));
            fileTypes.Add(new FileTypeData(".sig", "Signature File"));
            fileTypes.Add(new FileTypeData(".bdp", "Exchange Diagnostic Message"));
            fileTypes.Add(new FileTypeData(".boc", "EasyWord Big Document"));
            fileTypes.Add(new FileTypeData(".dx", "DEC WPS Plus File"));
            fileTypes.Add(new FileTypeData(".fpt", "FoxPro Table Memo"));
            fileTypes.Add(new FileTypeData(".ltx", "LaTeX Document"));
            fileTypes.Add(new FileTypeData(".pwd", "Pocket Word Document"));
            fileTypes.Add(new FileTypeData(".rpt", "Generic Report"));
            fileTypes.Add(new FileTypeData(".template", "Apple Pages Template"));
            fileTypes.Add(new FileTypeData(".wpd", "ACT! 2 Word Processing Document"));
            fileTypes.Add(new FileTypeData(".fadei", ".template	Fade In Template"));
            fileTypes.Add(new FileTypeData(".pfs", "PhotoFiltre Studio Saved Selection File"));
            fileTypes.Add(new FileTypeData(".pvm", "Photo Video Manifest File"));
            fileTypes.Add(new FileTypeData(".rtx", "Rich Text Document"));
            fileTypes.Add(new FileTypeData(".tpc", "Topic Connection Placeholder"));
            fileTypes.Add(new FileTypeData(".pages", "Pages Document"));
            fileTypes.Add(new FileTypeData(".abw", "AbiWord Document"));
            fileTypes.Add(new FileTypeData(".psw", "Pocket Word Document"));
            fileTypes.Add(new FileTypeData(".1st", "Readme File"));
            fileTypes.Add(new FileTypeData(".run", "Runscanner Scan File"));
            fileTypes.Add(new FileTypeData(".odt", "OpenDocument Text Document"));
            fileTypes.Add(new FileTypeData(".dotx", "Word Open XML Document Template"));
            fileTypes.Add(new FileTypeData(".lp2", "iLEAP Word Processing Document"));
            fileTypes.Add(new FileTypeData(".wpt", "WordPerfect Template"));
            fileTypes.Add(new FileTypeData(".tmd", "TextMaker Document"));
            fileTypes.Add(new FileTypeData(".xwp", "Xerox Writer Text Document"));
            fileTypes.Add(new FileTypeData(".odm", "OpenDocument Master Document"));
            fileTypes.Add(new FileTypeData(".se", "Shuttle Document"));
            fileTypes.Add(new FileTypeData(".latex", "LaTeX Document"));
            fileTypes.Add(new FileTypeData(".wps", "Kingsoft Writer Document"));
            fileTypes.Add(new FileTypeData(".tab", "Tab Separated Data File"));
            fileTypes.Add(new FileTypeData(".prt", "Crypt Edit Protected Text Format File"));
            fileTypes.Add(new FileTypeData(".wpl", "DEC WPS Plus Text Document"));
            fileTypes.Add(new FileTypeData(".rst", "reStructuredText File"));
            fileTypes.Add(new FileTypeData(".bib", "BibTeX Bibliography Database"));
            fileTypes.Add(new FileTypeData(".adoc", "AsciiDoc File"));
            fileTypes.Add(new FileTypeData(".ase", "Autodesk ASCII Scene Export File"));
            fileTypes.Add(new FileTypeData(".aww", "Ability Write Document"));
            fileTypes.Add(new FileTypeData(".bean", "Bean Rich Text Document"));
            fileTypes.Add(new FileTypeData(".bib", "Bibliography Document"));
            fileTypes.Add(new FileTypeData(".bna", "Barna Word Processor Document"));
            fileTypes.Add(new FileTypeData(".bzabw", "Compressed AbiWord Document"));
            fileTypes.Add(new FileTypeData(".calca", "Calca Document"));
            fileTypes.Add(new FileTypeData(".charset", "Character Set"));
            fileTypes.Add(new FileTypeData(".chord", "Song Chords File"));
            fileTypes.Add(new FileTypeData(".cyi", "Clustify Input File"));
            fileTypes.Add(new FileTypeData(".dne", "Netica Text File"));
            fileTypes.Add(new FileTypeData(".eio", "Yozo Office File"));
            fileTypes.Add(new FileTypeData(".etf", "ENIGMA Transportable File"));
            fileTypes.Add(new FileTypeData(".fcf", "Final Draft Converter File"));
            fileTypes.Add(new FileTypeData(".fdt", "Final Draft 5-7 Template"));
            fileTypes.Add(new FileTypeData(".fdxt", "Final Draft 8 Template"));
            fileTypes.Add(new FileTypeData(".fodt", "OpenDocument Flat XML Document"));
            fileTypes.Add(new FileTypeData(".fountain", "Fountain Script File"));
            fileTypes.Add(new FileTypeData(".fwd", "RollerCoaster Tycoon 3 Fireworks Display"));
            fileTypes.Add(new FileTypeData(".gsd", "General Station Description File"));
            fileTypes.Add(new FileTypeData(".gthr", "Gather Log File"));
            fileTypes.Add(new FileTypeData(".gv", "Graphviz DOT File"));
            fileTypes.Add(new FileTypeData(".ipspot", "iPhoto Spot File"));
            fileTypes.Add(new FileTypeData(".klg", "KOFIA Log"));
            fileTypes.Add(new FileTypeData(".kwd", "KWord Document"));
            fileTypes.Add(new FileTypeData(".lbt", "FoxPro Label Memo"));
            fileTypes.Add(new FileTypeData(".luf", "Lipikar Uniform Format File"));
            fileTypes.Add(new FileTypeData(".lyx", "LyX Document"));
            fileTypes.Add(new FileTypeData(".md", ".txt	Message Digest 5 Hash File"));
            fileTypes.Add(new FileTypeData(".mell", "Mellel Word Processing File"));
            fileTypes.Add(new FileTypeData(".nb", "Nota Bene File"));
            fileTypes.Add(new FileTypeData(".njx", "NJStar Document"));
            fileTypes.Add(new FileTypeData(".nwp", "Now Contact WP Document"));
            fileTypes.Add(new FileTypeData(".ofl", "Ots File List"));
            fileTypes.Add(new FileTypeData(".ott", "OpenDocument Document Template"));
            fileTypes.Add(new FileTypeData(".page", "-tef	Pages iCloud Document"));
            fileTypes.Add(new FileTypeData(".pjt", "FoxPro Project Memo"));
            fileTypes.Add(new FileTypeData(".plantuml", "PlantUML File"));
            fileTypes.Add(new FileTypeData(".pu", "PlantUML File"));
            fileTypes.Add(new FileTypeData(".qpf", "QuickPad Encrypted Document"));
            fileTypes.Add(new FileTypeData(".readme", "Readme File"));
            fileTypes.Add(new FileTypeData(".rzk", "File Crypt Password File"));
            fileTypes.Add(new FileTypeData(".rzn", "Red Zion Notes File"));
            fileTypes.Add(new FileTypeData(".scriv", "Scrivener Document"));
            fileTypes.Add(new FileTypeData(".scrivx", "Scrivener XML Document"));
            fileTypes.Add(new FileTypeData(".sct", "FoxPro Form Memo"));
            fileTypes.Add(new FileTypeData(".scw", "Movie Magic Screenwriter Document"));
            fileTypes.Add(new FileTypeData(".sgm", "SGML File"));
            fileTypes.Add(new FileTypeData(".sl", ".gz	Scribus Compressed Document"));
            fileTypes.Add(new FileTypeData(".story", "Storyist Document"));
            fileTypes.Add(new FileTypeData(".strings", "Text Strings File"));
            fileTypes.Add(new FileTypeData(".sublim", "-project	Sublime Text Project File"));
            fileTypes.Add(new FileTypeData(".sublim", "-workspace	Sublime Text Workspace File"));
            fileTypes.Add(new FileTypeData(".tdf", "Guide Text Definition File"));
            fileTypes.Add(new FileTypeData(".tdf", "Xserve Test Definition File"));
            fileTypes.Add(new FileTypeData(".textclipping", "Mac OS X Text Clipping File"));
            fileTypes.Add(new FileTypeData(".u3i", "U3 Application Information File"));
            fileTypes.Add(new FileTypeData(".unauth", "SiteMinder Unauthorized Message File"));
            fileTypes.Add(new FileTypeData(".unx", "Unix Text File"));
            fileTypes.Add(new FileTypeData(".utf8", "Unicode UTF8-Encoded Text Document"));
            fileTypes.Add(new FileTypeData(".utxt", "Unicode Text File"));
            fileTypes.Add(new FileTypeData(".wpa", "ACT! Word Processing Document"));
            fileTypes.Add(new FileTypeData(".xbdoc", "Xiosis Scribe Document"));
            fileTypes.Add(new FileTypeData(".xdl", "XML Schema File"));
            fileTypes.Add(new FileTypeData(".xy3", "XYWrite III Document"));
            fileTypes.Add(new FileTypeData(".xyp", "XYWrite Plus Document"));
            fileTypes.Add(new FileTypeData(".xyw", "XYWrite for Windows Document"));
            fileTypes.Add(new FileTypeData(".zabw", "Compressed AbiWord Document File"));
            fileTypes.Add(new FileTypeData(".zrtf", "Nisus Compressed Rich Text File"));
            fileTypes.Add(new FileTypeData(".tlb", "VAX Text Library"));
            fileTypes.Add(new FileTypeData(".ascii", "ASCII Text File"));
            fileTypes.Add(new FileTypeData(".docz", "ThinkFree Online Note Document"));
            fileTypes.Add(new FileTypeData(".jarvis", "Jarvis Subscriber File"));
            fileTypes.Add(new FileTypeData(".lyt", "TurboTax Install Log File"));
            fileTypes.Add(new FileTypeData(".now", "Readme File"));
            fileTypes.Add(new FileTypeData(".openbsd", "OpenBSD Readme File"));
            fileTypes.Add(new FileTypeData(".rad", "Radar ViewPoint Radar Data"));
            fileTypes.Add(new FileTypeData(".wtx", "Text Document"));
            fileTypes.Add(new FileTypeData(".xy", "XYWrite Document"));
            fileTypes.Add(new FileTypeData(".sla", "Scribus Document"));
            fileTypes.Add(new FileTypeData(".sxw", "StarOffice Writer Document"));
            fileTypes.Add(new FileTypeData(".asc", "ASCII Text File"));
            fileTypes.Add(new FileTypeData(".cnm", "NoteMap Outline File"));
            fileTypes.Add(new FileTypeData(".emulecollection", "eMule Data File"));
            fileTypes.Add(new FileTypeData(".hwp", "Hanword Document"));
            fileTypes.Add(new FileTypeData(".p7s", "Digitally Signed Email Message"));
            fileTypes.Add(new FileTypeData(".xwp", "XMLwriter Project"));
            fileTypes.Add(new FileTypeData(".hbk", "Mathcad Handbook File"));
            fileTypes.Add(new FileTypeData(".odo", "Online Operating System Write Document"));
            fileTypes.Add(new FileTypeData(".apkg", "Exported Anki Flashcard Deck"));
            fileTypes.Add(new FileTypeData(".idx", "Outlook Express Mailbox Index File"));
            fileTypes.Add(new FileTypeData(".fdf", "Acrobat Forms Data Format"));
            fileTypes.Add(new FileTypeData(".notes", "Memento Notes File"));
            fileTypes.Add(new FileTypeData(".rtd", "RagTime Document"));
            fileTypes.Add(new FileTypeData(".sdw", "StarOffice Writer Text Document"));
            fileTypes.Add(new FileTypeData(".sms", "Exported SMS Text Message"));
            fileTypes.Add(new FileTypeData(".ssa", "Sub Station Alpha Subtitle File"));
            fileTypes.Add(new FileTypeData(".sam", "Ami Pro Document"));
            fileTypes.Add(new FileTypeData(".scc", "Scenarist Closed Caption File"));
            fileTypes.Add(new FileTypeData(".dca", "DisplayWrite Document"));
            fileTypes.Add(new FileTypeData(".wp6", "WordPerfect 6 Document"));
            fileTypes.Add(new FileTypeData(".lwp", "Lotus Word Pro Document"));
            fileTypes.Add(new FileTypeData(".crwl", "Windows Crawl File"));
            fileTypes.Add(new FileTypeData(".lnt", "Laego Note Taker File"));
            fileTypes.Add(new FileTypeData(".uot", "Uniform Office Document"));
            fileTypes.Add(new FileTypeData(".vct", "Visual Class Library Memo"));
            fileTypes.Add(new FileTypeData(".webdoc", "Box.net Web Document"));
            fileTypes.Add(new FileTypeData(".act", "FoxPro Documenting Wizard Action Diagram"));
            fileTypes.Add(new FileTypeData(".aty", "Association Type Placeholder"));
            fileTypes.Add(new FileTypeData(".awp", "Ability Write Template"));
            fileTypes.Add(new FileTypeData(".bbs", "Bulletin Board System Text"));
            fileTypes.Add(new FileTypeData(".bml", "Braille 2000 Braille File"));
            fileTypes.Add(new FileTypeData(".brx", "Beam Report Document"));
            fileTypes.Add(new FileTypeData(".cws", "Claris Works Template"));
            fileTypes.Add(new FileTypeData(".dgs", "Dagesh Pro Document"));
            fileTypes.Add(new FileTypeData(".dxb", "Duxbury Braille File"));
            fileTypes.Add(new FileTypeData(".dxp", "Duxbury Print File"));
            fileTypes.Add(new FileTypeData(".err", "FoxPro Compilation Error"));
            fileTypes.Add(new FileTypeData(".fds", "Final Draft Secure Copy"));
            fileTypes.Add(new FileTypeData(".gpn", "GlidePlan Map Document"));
            fileTypes.Add(new FileTypeData(".jis", "Japanese Industry Standard Text"));
            fileTypes.Add(new FileTypeData(".min", "Mint Source File"));
            fileTypes.Add(new FileTypeData(".mw", "MacWrite Text Document"));
            fileTypes.Add(new FileTypeData(".ndoc", "Naver Word"));
            fileTypes.Add(new FileTypeData(".ngloss", "Nisus Writer Glossary"));
            fileTypes.Add(new FileTypeData(".nwctxt", "NoteWorthy Composer Text File"));
            fileTypes.Add(new FileTypeData(".nwm", "Nisus Macro"));
            fileTypes.Add(new FileTypeData(".ocr", "FAXGrapper Fax Text File"));
            fileTypes.Add(new FileTypeData(".ort", "Rich Text Editor Document"));
            fileTypes.Add(new FileTypeData(".pdpcmd", "Pdplayer Command File"));
            fileTypes.Add(new FileTypeData(".pfx", "First Choice Word Processing Document"));
            fileTypes.Add(new FileTypeData(".pmo", "Pegasus Saved Message File"));
            fileTypes.Add(new FileTypeData(".pvj", "ProofVision Job Ticket"));
            fileTypes.Add(new FileTypeData(".pwdp", "Password Pad Document"));
            fileTypes.Add(new FileTypeData(".pwdpl", "Password Pad Lite Document"));
            fileTypes.Add(new FileTypeData(".pwr", "PowerWrite Document"));
            fileTypes.Add(new FileTypeData(".scm", "Schema File"));
            fileTypes.Add(new FileTypeData(".sdm", "StarOffice Mail Message"));
            fileTypes.Add(new FileTypeData(".session", "Mozilla Firefox Session File"));
            fileTypes.Add(new FileTypeData(".skcard", "Starfish Sidekick Card File"));
            fileTypes.Add(new FileTypeData(".smf", "StarMath Formula File"));
            fileTypes.Add(new FileTypeData(".stw", "StarOffice Document Template"));
            fileTypes.Add(new FileTypeData(".sxg", "Apache OpenOffice Master Document"));
            fileTypes.Add(new FileTypeData(".tm", "TeXmacs Document"));
            fileTypes.Add(new FileTypeData(".tmv", "TextMaker Template"));
            fileTypes.Add(new FileTypeData(".trelby", "Trelby File"));
            fileTypes.Add(new FileTypeData(".tvj", "TrueView Job Ticket"));
            fileTypes.Add(new FileTypeData(".uof", "Uniform Office Document"));
            fileTypes.Add(new FileTypeData(".wbk", "WordPerfect Workbook"));
            fileTypes.Add(new FileTypeData(".wp", "WordPerfect Document"));
            fileTypes.Add(new FileTypeData(".wp4", "WordPerfect 4 Document"));
            fileTypes.Add(new FileTypeData(".wp5", "WordPerfect 5 Document"));
            fileTypes.Add(new FileTypeData(".wp7", "WordPerfect 7 Document"));
            fileTypes.Add(new FileTypeData(".wpt", "Kingsoft Writer Template"));
            fileTypes.Add(new FileTypeData(".xbplate", "Xiosis Scribe Template"));
            fileTypes.Add(new FileTypeData(".hwp", "Hangul (Korean) Text Document"));
            fileTypes.Add(new FileTypeData(".wpd", "602Text Word Processing Document"));
            fileTypes.Add(new FileTypeData(".zw", "Chinese Text File"));
            fileTypes.Add(new FileTypeData(".awt", "AbiWord Template"));
            fileTypes.Add(new FileTypeData(".chart", "Feedback Chart File"));
            fileTypes.Add(new FileTypeData(".emf", "Jasspa MicroEmacs Macro File"));
            fileTypes.Add(new FileTypeData(".gmd", "GroupMail Message"));
            fileTypes.Add(new FileTypeData(".hz", "Chinese (Hanzi) Text"));
            fileTypes.Add(new FileTypeData(".xwp", "Crosstalk Session File"));
            fileTypes.Add(new FileTypeData(".dox", "MultiMate Document"));
            fileTypes.Add(new FileTypeData(".dsc", "Text Description File"));
            fileTypes.Add(new FileTypeData(".etx", "Structure Enhanced Text (Setext) File"));
            fileTypes.Add(new FileTypeData(".euc", "Extended Unix Code File"));
            fileTypes.Add(new FileTypeData(".faq", "Frequently Asked Questions Document"));
            fileTypes.Add(new FileTypeData(".fft", "Final Form Text File"));
            fileTypes.Add(new FileTypeData(".fwdn", "fWriter Document"));
            fileTypes.Add(new FileTypeData(".iil", "CleanSweep Installation Log"));
            fileTypes.Add(new FileTypeData(".ipf", "OS/2 Help File"));
            fileTypes.Add(new FileTypeData(".joe", "JOE Document"));
            fileTypes.Add(new FileTypeData(".jrtf", "JAmes OS Rich Text File"));
            fileTypes.Add(new FileTypeData(".ltr", "Letter File"));
            fileTypes.Add(new FileTypeData(".lue", "Norton LiveUpdate Log File"));
            fileTypes.Add(new FileTypeData(".mcw", "MacWrite II Document"));
            fileTypes.Add(new FileTypeData(".odif", "Open Document Interchange Format"));
            fileTypes.Add(new FileTypeData(".rft", "Revisable Form Text Document"));
            fileTypes.Add(new FileTypeData(".sdoc", "Satra Khmer Document"));
            fileTypes.Add(new FileTypeData(".thp", "TurboTax Text String"));
            fileTypes.Add(new FileTypeData(".vw", "Volkswriter Text File"));
            fileTypes.Add(new FileTypeData(".wn", "WriteNow Text Document"));
            fileTypes.Add(new FileTypeData(".wpw", "WP Works Word Processor File"));
            fileTypes.Add(new FileTypeData(".wsd", "WordStar Document"));

            return fileTypes;
        }

        // http://fileinfo.com/filetypes/text
        public static List<FileTypeData> DefaultTypes()
        {
            List<FileTypeData> fileTypes = new List<FileTypeData>();
            fileTypes.Add(new FileTypeData(".txt", "Plain Text File"));
            fileTypes.Add(new FileTypeData(".docx", "Microsoft Word Open XML Document"));
            fileTypes.Add(new FileTypeData(".gdoc", "Google Drive Document"));
            fileTypes.Add(new FileTypeData(".text", "Plain Text File"));
            fileTypes.Add(new FileTypeData(".rtf", "Rich Text Format File"));
            fileTypes.Add(new FileTypeData(".doc", "Microsoft Word Document"));
            fileTypes.Add(new FileTypeData(".msg", "Outlook Mail Message"));
            fileTypes.Add(new FileTypeData(".eml", "E-Mail Message"));
            fileTypes.Add(new FileTypeData(".docxml", "Microsoft Word XML Document"));
            fileTypes.Add(new FileTypeData(".tex", "LaTeX Source Document"));

            return fileTypes;
        }
    }
}
