﻿using DriveIndexer.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveIndexer.Database
{
    public class DefaultFileTypesCompressed
    {
        // http://fileinfo.com/filetypes/video
        public static List<FileTypeData> DefaultTypes()
        {
            List<FileTypeData> fileTypes = new List<FileTypeData>();

            fileTypes.Add(new FileTypeData(".arc", "Compressed File Archive"));
            fileTypes.Add(new FileTypeData(".gzip", "Gnu Zipped File"));
            fileTypes.Add(new FileTypeData(".cbz", "Comic Book Zip Archive"));
            //fileTypes.Add(new FileTypeData(".pup", "PlayStation 3 Update File"));
            //fileTypes.Add(new FileTypeData(".cxarchive", "CrossOver Bottle Archive"));
            //fileTypes.Add(new FileTypeData(".dl_", "Compressed DLL File"));
            //fileTypes.Add(new FileTypeData(".nex", "Navigator Extension"));
            //fileTypes.Add(new FileTypeData(".war", "Java Web Archive"));
            //fileTypes.Add(new FileTypeData(".deb", "Debian Software Package"));
            fileTypes.Add(new FileTypeData(".7z", "7-Zip Compressed File"));
            fileTypes.Add(new FileTypeData(".sfx", "Windows Self-Extracting Archive"));
            fileTypes.Add(new FileTypeData(".zip", "Zipped File"));
            //fileTypes.Add(new FileTypeData(".par", "Parchive Index File"));
            //fileTypes.Add(new FileTypeData("0	Hacha", "Split Archive File"));
            fileTypes.Add(new FileTypeData(".zix", "WinZix Compressed File"));
            //fileTypes.Add(new FileTypeData(".mpkg", "Meta Package File"));
            //fileTypes.Add(new FileTypeData(".pet", "Puppy Linux Install Package"));
            //fileTypes.Add(new FileTypeData(".ba", "Scifer External Header Archive"));
            //fileTypes.Add(new FileTypeData(".dar", "DAR Disk Archive"));
            //fileTypes.Add(new FileTypeData(".ipk", "Itsy Package"));
            //fileTypes.Add(new FileTypeData(".ita", "IconTweaker Theme Archive"));
            fileTypes.Add(new FileTypeData(".lz", "Lzip Compressed File"));
            //fileTypes.Add(new FileTypeData(".lzm", "Slax Module"));
            //fileTypes.Add(new FileTypeData(".mint", "Linux Mint Installer File"));
            //fileTypes.Add(new FileTypeData(".par2", "Parchive 2 Index File"));
            //fileTypes.Add(new FileTypeData(".pf", "Private File"));
            //fileTypes.Add(new FileTypeData(".piz", "Zipped File"));
            //fileTypes.Add(new FileTypeData(".s00", "ZipSplitter Part 1 Archive"));
            //fileTypes.Add(new FileTypeData(".sea", "Self-Extracting Archive"));
            //fileTypes.Add(new FileTypeData(".ta", ".lzma	LZMA Compressed Tarball"));
            //fileTypes.Add(new FileTypeData(".tbz", "Bzip Compressed Tar Archive"));
            //fileTypes.Add(new FileTypeData(".z", "Unix Compressed File"));
            //fileTypes.Add(new FileTypeData(".a02", "ALZip Fourth Split Archive File"));
            //fileTypes.Add(new FileTypeData(".dd", "DiskDoubler Archive"));
            //fileTypes.Add(new FileTypeData(".r30", "WinRAR Split Archive Part 30"));
            fileTypes.Add(new FileTypeData(".cbr", "Comic Book RAR Archive"));
            fileTypes.Add(new FileTypeData(".gz", "Gnu Zipped Archive"));
            fileTypes.Add(new FileTypeData(".rar", "WinRAR Compressed Archive"));
            fileTypes.Add(new FileTypeData(".uha", "UHarc Compressed Archive"));
            //fileTypes.Add(new FileTypeData(".b1", "B1 Compressed Archive"));
            //fileTypes.Add(new FileTypeData(".zfsendtotarget", "Compressed Folder"));
            fileTypes.Add(new FileTypeData(".lzma", "LZMA Compressed File"));
            fileTypes.Add(new FileTypeData(".pak", "PAK (Packed) File"));
            fileTypes.Add(new FileTypeData(".z01", "WinZip First Split Zip File"));
            //fileTypes.Add(new FileTypeData("0	DoubleSpace", "Compressed File"));
            //fileTypes.Add(new FileTypeData(".bz", "Bzip Compressed File"));
            fileTypes.Add(new FileTypeData(".r00", "WinRAR Compressed Archive"));
            //fileTypes.Add(new FileTypeData(".dz", "Dzip File"));
            //fileTypes.Add(new FileTypeData(".sy_", "Compressed SYS File"));
            //fileTypes.Add(new FileTypeData(".c00", "WinAce Split Archive File"));
            //fileTypes.Add(new FileTypeData(".ta", ".xz	XZ Compressed Tar Archive"));
            //fileTypes.Add(new FileTypeData(".bz2", "Bzip2 Compressed File"));
            //fileTypes.Add(new FileTypeData(".sitx", "StuffIt X Archive"));
            fileTypes.Add(new FileTypeData(".7", ".002	7-Zip Split Archive Part 2 File"));
            //fileTypes.Add(new FileTypeData(".ar", "Unix Static Library"));
            //fileTypes.Add(new FileTypeData(".sit", "StuffIt Archive"));
            //fileTypes.Add(new FileTypeData(".zipx", "Extended Zip File"));
            //fileTypes.Add(new FileTypeData(".ace", "WinAce Compressed File"));
            //fileTypes.Add(new FileTypeData(".bndl", "Game Data Bundle File"));
            fileTypes.Add(new FileTypeData(".r01", "WinRAR Split Archive Part 1"));
            //fileTypes.Add(new FileTypeData(".shar", "Unix Shar Archive"));
            //fileTypes.Add(new FileTypeData(".hpk", "HPack Compressed Archive"));
            //fileTypes.Add(new FileTypeData(".zpi", "Zipped File"));
            //fileTypes.Add(new FileTypeData(".rpm", "Red Hat Package Manager File"));
            //fileTypes.Add(new FileTypeData(".pea", "PEA File Archive"));
            //fileTypes.Add(new FileTypeData(".rev", "RAR Recovery Volume Set"));
            //fileTypes.Add(new FileTypeData(".pkg", "Mac OS X Installer Package"));
            //fileTypes.Add(new FileTypeData(".f", "Freeze Compressed File"));
            //fileTypes.Add(new FileTypeData(".czip", "ZipGenius CryptoZip File"));
            //fileTypes.Add(new FileTypeData(".pwa", "Password Agent File"));
            //fileTypes.Add(new FileTypeData(".sdc", "Secure Download Cabinet"));
            //fileTypes.Add(new FileTypeData(".arj", "ARJ Compressed File Archive"));
            //fileTypes.Add(new FileTypeData(".bh", "BlakHole Archive"));
            //fileTypes.Add(new FileTypeData(".cdz", "Compressed CD Image File"));
            //fileTypes.Add(new FileTypeData(".lemon", "LemonShare.net Download"));
            fileTypes.Add(new FileTypeData(".r03", "WinRAR Split Archive Part 3"));
            //fileTypes.Add(new FileTypeData(".rnc", "RNC ProPack Archive"));
            //fileTypes.Add(new FileTypeData(".sbx", "GLBasic Shoebox File"));
            //fileTypes.Add(new FileTypeData(".sdn", "Shareware Distributors Network File"));
            //fileTypes.Add(new FileTypeData(".hyp", "HYPER Compressed Archive"));
            //fileTypes.Add(new FileTypeData(".package", "Linux Autopackage File"));
            //fileTypes.Add(new FileTypeData(".cpgz", "Compressed CPIO Archive"));
            //fileTypes.Add(new FileTypeData(".pup", "Puppy Linux DotPup Installer Package"));
            //fileTypes.Add(new FileTypeData(".shr", "Unix Shell Archive File"));
            //fileTypes.Add(new FileTypeData(".snb", "S Note File"));
            //fileTypes.Add(new FileTypeData(".xz", "XZ Compressed Archive"));
            //fileTypes.Add(new FileTypeData(".tgz", "Gzipped Tar File"));
            fileTypes.Add(new FileTypeData(".7", ".001	7-Zip Split Archive Part 1 File"));
            //fileTypes.Add(new FileTypeData(".xx", "XXEncoded File"));
            //fileTypes.Add(new FileTypeData(".mzp", "MAXScript Zip Package"));
            fileTypes.Add(new FileTypeData(".sh", "Unix Shell Archive"));
            //fileTypes.Add(new FileTypeData(".txz", "XZ Compressed Tar Archive"));
            //fileTypes.Add(new FileTypeData(".alz", "ALZip Archive"));
            //fileTypes.Add(new FileTypeData(".apz", "Autoplay Media Studio Exported Project"));
            //fileTypes.Add(new FileTypeData(".archiver", "Archiver Compressed File Archive"));
            //fileTypes.Add(new FileTypeData(".asr", "Audio Streaming Resource Archive"));
            //fileTypes.Add(new FileTypeData(".b64", "Base64 MIME-Encoded File"));
            //fileTypes.Add(new FileTypeData(".c01", "WinAce Split Archive Part 1 File"));
            //fileTypes.Add(new FileTypeData(".cbt", "Comic Book TAR File"));
            //fileTypes.Add(new FileTypeData(".comppk", ".hauptwerk.rar	Hauptwerk Component Package"));
            //fileTypes.Add(new FileTypeData(".cp9", "ChoicePoint Encrypted File"));
            //fileTypes.Add(new FileTypeData(".dgc", "DGCA File Archive"));
            //fileTypes.Add(new FileTypeData(".ecs", "Sony Ericsson Phone Backup File"));
            //fileTypes.Add(new FileTypeData(".efw", "Renamed Zip or Executable File"));
            //fileTypes.Add(new FileTypeData(".gca", "GCA File Archive"));
            //fileTypes.Add(new FileTypeData(".gmz", "Compressed GameMaker File"));
            //fileTypes.Add(new FileTypeData(".hbc", "HyperBac Compressed Archive"));
            //fileTypes.Add(new FileTypeData(".hki", "WinHKI Archive"));
            //fileTypes.Add(new FileTypeData(".hki1", "WinHKI HKI1 Archive"));
            //fileTypes.Add(new FileTypeData(".hki2", "WinHKI HKI2 Archive"));
            //fileTypes.Add(new FileTypeData(".hki3", "WinHKI HKI3 Archive"));
            //fileTypes.Add(new FileTypeData(".ice", "ICE File Archive"));
            //fileTypes.Add(new FileTypeData(".ipg", "iPod Game File"));
            //fileTypes.Add(new FileTypeData(".jic", "Java Icon File"));
            //fileTypes.Add(new FileTypeData(".kgb", "KGB Archive File"));
            //fileTypes.Add(new FileTypeData(".lha", "LHARC Compressed Archive"));
            //fileTypes.Add(new FileTypeData(".lnx", "Commodore 64 Lynx Archive"));
            //fileTypes.Add(new FileTypeData(".lqr", "SQ Compressed LBR Archive"));
            //fileTypes.Add(new FileTypeData(".lzo", "LZO Compressed File"));
            //fileTypes.Add(new FileTypeData(".mzp", "WinArchiver Mountable Archive"));
            //fileTypes.Add(new FileTypeData(".pbi", "PC BSD Installer Package"));
            //fileTypes.Add(new FileTypeData(".psz", "Compressed PostScript File"));
            //fileTypes.Add(new FileTypeData(".qda", "Quadruple D Archive"));
            //fileTypes.Add(new FileTypeData(".rp9", "RetroPlatform Disk Image Archive"));
            //fileTypes.Add(new FileTypeData(".rte", "RTE Encoded File"));
            //fileTypes.Add(new FileTypeData(".s02", "ZipSplitter Part 3 Archive"));
            fileTypes.Add(new FileTypeData(".s7z", "Mac OS X 7-Zip File"));
            //fileTypes.Add(new FileTypeData(".smpf", "Sprite Monkey Project"));
            //fileTypes.Add(new FileTypeData(".sqx", "SQX Archive"));
            //fileTypes.Add(new FileTypeData(".ta", ".bz2	Compressed Tarball File"));
            //fileTypes.Add(new FileTypeData(".taz", "Tar Zipped File"));
            //fileTypes.Add(new FileTypeData(".vsi", "Visual Studio Content Installer File"));
            //fileTypes.Add(new FileTypeData(".xar", "Extensible Archive Format File"));
            //fileTypes.Add(new FileTypeData(".xef", "WinAce Encrypted File"));
            //fileTypes.Add(new FileTypeData(".xmcdz", "Mathcad Compressed Worksheet File"));
            //fileTypes.Add(new FileTypeData(".a00", "ALZip Second Split Archive File"));
            //fileTypes.Add(new FileTypeData(".a01", "ALZip Third Split Archive File"));
            //fileTypes.Add(new FileTypeData(".jsonlz4", "Compressed Firefox Bookmarks Backup File"));
            //fileTypes.Add(new FileTypeData(".pax", "PAX Archive"));
            //fileTypes.Add(new FileTypeData(".pcv", "MozBackup Profile Backup"));
            //fileTypes.Add(new FileTypeData(".rk", "WinRK File Archive"));
            //fileTypes.Add(new FileTypeData(".trs", "Linear Saw Component Information Archive"));
            //fileTypes.Add(new FileTypeData(".tx_", "Compressed Text File"));
            //fileTypes.Add(new FileTypeData(".z03", "WinZip Third Split Zip File"));
            //fileTypes.Add(new FileTypeData(".ari", "ARI Compressed File Archive"));
            //fileTypes.Add(new FileTypeData(".md", "MDCD Compressed Archive"));
            //fileTypes.Add(new FileTypeData(".pit", "PackIt Compressed Archive"));
            //fileTypes.Add(new FileTypeData(".uc2", "UltraCompressor 2 Archive"));
            //fileTypes.Add(new FileTypeData(".z02", "WinZip Second Split Zip File"));
            //fileTypes.Add(new FileTypeData(".zz", "Zzip Compressed Archive"));
            //fileTypes.Add(new FileTypeData(".zoo", "Zoo Compressed File"));
            //fileTypes.Add(new FileTypeData(".s01", "ZipSplitter Part 2 Archive"));
            //fileTypes.Add(new FileTypeData(".c02", "WinAce Split Archive Part 1 File"));
            //fileTypes.Add(new FileTypeData(".r02", "WinRAR Split Archive Part 2"));
            //fileTypes.Add(new FileTypeData(".ta", ".gz	Compressed Tarball File"));
            //fileTypes.Add(new FileTypeData(".bzip", "Bzip Compressed Archive"));
            //fileTypes.Add(new FileTypeData(".jgz", "Gzipped Javascript File"));
            //fileTypes.Add(new FileTypeData(".lbr", "LU Library Archive"));
            //fileTypes.Add(new FileTypeData(".pae", "PowerArchiver Encrypted Archive"));
            //fileTypes.Add(new FileTypeData(".sfs", "Squashfs File Archive"));
            //fileTypes.Add(new FileTypeData(".tz", "Zipped Tar Archive"));
            //fileTypes.Add(new FileTypeData(".zw", "Zooper Widget Template"));
            //fileTypes.Add(new FileTypeData(".cpt", "Compact Pro Archive"));
            //fileTypes.Add(new FileTypeData(".fp8", "FP8 (= Fast PAQ8) Compressed File"));
            //fileTypes.Add(new FileTypeData(".lzh", "LZH Compressed File"));
            //fileTypes.Add(new FileTypeData(".puz", "Packed Publisher File"));
            //fileTypes.Add(new FileTypeData(".j", "JAR Archive"));
            //fileTypes.Add(new FileTypeData(".yz", "YAC Compressed File"));
            //fileTypes.Add(new FileTypeData(".bundle", "Game Data Bundle File"));
            //fileTypes.Add(new FileTypeData(".layout", "LayOut Document"));
            //fileTypes.Add(new FileTypeData(".egg", "ALZip Archive"));
            //fileTypes.Add(new FileTypeData(".cba", "Comic Book ACE Archive"));
            //fileTypes.Add(new FileTypeData(".dist", "Mac OS X Distribution Script"));
            //fileTypes.Add(new FileTypeData(".paq6", "PAQ6 Data Archive"));
            //fileTypes.Add(new FileTypeData(".paq7", "PAQ7 Data Archive"));
            //fileTypes.Add(new FileTypeData(".rz", "Rzip Compressed File"));
            //fileTypes.Add(new FileTypeData(".sar", "Service Archive File"));
            //fileTypes.Add(new FileTypeData(".vem", "Virtual Expander Compressed File"));
            //fileTypes.Add(new FileTypeData(".agg", "Bulk Data File"));
            //fileTypes.Add(new FileTypeData(".arh", "ProTool Compressed Project File"));
            //fileTypes.Add(new FileTypeData(".boo", "Booasm Compressed Archive"));
            //fileTypes.Add(new FileTypeData(".c10", "WinAce Split Archive Part 10"));
            //fileTypes.Add(new FileTypeData(".cb7", "Comic Book 7-Zip Archive"));
            //fileTypes.Add(new FileTypeData(".comppkg_hauptwerk_rar", "Hauptwerk Component Package"));
            //fileTypes.Add(new FileTypeData(".epi", "EclipsePackager2000 Compressed File"));
            //fileTypes.Add(new FileTypeData(".fdp", "MySafe Encrypted Data"));
            //fileTypes.Add(new FileTypeData(".fzbz", "Fritzing Bundled Bin File"));
            //fileTypes.Add(new FileTypeData(".fzpz", "Fritzing Bundled Part File"));
            //fileTypes.Add(new FileTypeData(".gz2", "Misnamed BZ2 File"));
            //fileTypes.Add(new FileTypeData(".gzi", "Unix Gzip File"));
            //fileTypes.Add(new FileTypeData(".hbc2", "HyperBac Compressed File Archive"));
            //fileTypes.Add(new FileTypeData(".hbe", "HyperBac Compressed and Encrypted Archive"));
            //fileTypes.Add(new FileTypeData(".lzx", "Amiga LZX Compressed File"));
            //fileTypes.Add(new FileTypeData(".oar", "OpenSimulator Archive"));
            //fileTypes.Add(new FileTypeData(".oz", "Opera Job Management Compressed File"));
            //fileTypes.Add(new FileTypeData(".p01", "Parchive Recovery Volume"));
            //fileTypes.Add(new FileTypeData(".p19", "Parchive Recovery Volume"));
            //fileTypes.Add(new FileTypeData(".pac", ".gz	Pack200 Compressed Archive"));
            //fileTypes.Add(new FileTypeData(".paq8", "PAQ8 Data Archive"));
            //fileTypes.Add(new FileTypeData(".paq8l", "PAQ8L Data Archive"));
            //fileTypes.Add(new FileTypeData(".r1", "WinRAR Multi-Volume Archive Part 1"));
            //fileTypes.Add(new FileTypeData(".r2", "WinRAR Multi-Volume Archive Part 2"));
            //fileTypes.Add(new FileTypeData(".r21", "WinRAR Split Archive Part 21"));
            //fileTypes.Add(new FileTypeData(".sen", "Scifer Internal Header Archive"));
            //fileTypes.Add(new FileTypeData(".snappy", "Snappy Compressed File"));
            //fileTypes.Add(new FileTypeData(".tbz2", "Tar BZip 2 Compressed File"));
            //fileTypes.Add(new FileTypeData(".tlz", "Tar LZMA Compressed File"));
            //fileTypes.Add(new FileTypeData(".tlzma", "LZMA Compressed Tar Archive"));
            //fileTypes.Add(new FileTypeData(".uf", ".uzip	Compressed Unix File System File"));
            //fileTypes.Add(new FileTypeData(".uzip", "FreeBSD Compressed Disk Image"));
            //fileTypes.Add(new FileTypeData(".wa", "Windows Addon Archive"));
            //fileTypes.Add(new FileTypeData(".waff", "Internet Explorer for Mac Web Archive"));
            //fileTypes.Add(new FileTypeData(".wlb", "WinList Protocol Bundle"));
            //fileTypes.Add(new FileTypeData(".xzm", "Porteus Module"));
            //fileTypes.Add(new FileTypeData(".y", "Amiga Yabba Compressed File"));
            //fileTypes.Add(new FileTypeData(".z04", "WinZip Fourth Split Zip File"));
            //fileTypes.Add(new FileTypeData(".zsplit", "Archiver Compressed Split File"));
            //fileTypes.Add(new FileTypeData(".ize", "IZArc Archive"));
            //fileTypes.Add(new FileTypeData(".r0", "WinRAR Compressed Archive"));
            //fileTypes.Add(new FileTypeData(".kz", "KuaiZip Compressed File"));
            //fileTypes.Add(new FileTypeData(".srep", "SuperREP Compressed File"));
            //fileTypes.Add(new FileTypeData(".ark", "PowerDesk Pro Archive"));
            //fileTypes.Add(new FileTypeData(".ja", ".pack	Pack200 Packed Jar File"));
            //fileTypes.Add(new FileTypeData(".yz1", "Yamazaki ZIPPER File"));
            //fileTypes.Add(new FileTypeData(".mou", "WinMount Compressed File"));
            //fileTypes.Add(new FileTypeData(".ta", ".gz2	Misnamed BZ2 Tarball"));
            //fileTypes.Add(new FileTypeData(".ain", "AIN Compressed File Archive"));
            //fileTypes.Add(new FileTypeData(".bza", "IZArc BGA Archive"));
            //fileTypes.Add(new FileTypeData(".bzip2", "Bzip2 Compressed Archive"));
            //fileTypes.Add(new FileTypeData(".car", "CAR Archive"));
            //fileTypes.Add(new FileTypeData(".gza", "IZArc BGA Archive File"));
            //fileTypes.Add(new FileTypeData(".ha", "HA Compressed Archive"));
            //fileTypes.Add(new FileTypeData(".ish", "ISH Compressed Archive"));
            //fileTypes.Add(new FileTypeData(".paq8f", "PAQ8F Compressed Archive"));
            //fileTypes.Add(new FileTypeData(".paq8p", "PAQ8P Data Archive"));
            //fileTypes.Add(new FileTypeData(".pim", "PIM Archive"));
            //fileTypes.Add(new FileTypeData(".shk", "ShrinkIt Archive"));
            //fileTypes.Add(new FileTypeData(".spt", "TM File Packer Compressed Archive"));
            //fileTypes.Add(new FileTypeData(".tg", "Gzip Compressed Tar Archive"));
            //fileTypes.Add(new FileTypeData(".wot", "Web Of Trust File"));
            //fileTypes.Add(new FileTypeData(".xez", "eManager Template Package"));
            //fileTypes.Add(new FileTypeData(".zap", "FileWrangler Archive"));
            //fileTypes.Add(new FileTypeData(".zi", "Renamed Zip File"));
            //fileTypes.Add(new FileTypeData(".zl", "Zlib Compressed File"));


            return fileTypes;
        }
    }
}
