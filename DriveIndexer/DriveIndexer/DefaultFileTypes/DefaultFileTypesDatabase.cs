﻿using DriveIndexer.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveIndexer.Database
{
    public class DefaultFileTypesDatabase
    {
        // http://fileinfo.com/filetypes/video
        public static List<FileTypeData> DefaultTypes()
        {
            List<FileTypeData> fileTypes = new List<FileTypeData>();

            fileTypes.Add(new FileTypeData(".sqlitedb", "SQLite Database"));
            fileTypes.Add(new FileTypeData(".sdb", "ServerBoss Database File"));
            fileTypes.Add(new FileTypeData(".qvd", "QlikView Data File"));
            fileTypes.Add(new FileTypeData(".idb", "IDA Database File"));
            fileTypes.Add(new FileTypeData(".pdm", "PowerDesigner Database File"));
            fileTypes.Add(new FileTypeData(".nyf", "myBase Database File"));
            fileTypes.Add(new FileTypeData(".cdb", "Symbian Phonebook Database"));
            fileTypes.Add(new FileTypeData(".dp1", "DataPower Database File"));
            fileTypes.Add(new FileTypeData(".fic", "WinDev Hyper File Database"));
            fileTypes.Add(new FileTypeData(".adf", "ACT! Data File"));
            fileTypes.Add(new FileTypeData(".sdb", "MonKey Office SQLite Database File"));
            fileTypes.Add(new FileTypeData(".mdf", "SQL Server Database File"));
            fileTypes.Add(new FileTypeData(".dsn", "Database Source Name File"));
            fileTypes.Add(new FileTypeData(".edb", "Exchange Information Store Database"));
            fileTypes.Add(new FileTypeData(".gdb", "GPS Database File"));
            fileTypes.Add(new FileTypeData(".sdf", "SQL Server Compact Database File"));
            fileTypes.Add(new FileTypeData(".sqlite", "SQLite Database File"));
            fileTypes.Add(new FileTypeData(".db", "Mobile Device Database File"));
            fileTypes.Add(new FileTypeData(".adp", "Access Project"));
            fileTypes.Add(new FileTypeData(".fp7", "FileMaker Pro 7+ Database"));
            fileTypes.Add(new FileTypeData(".mwb", "MySQL Workbench Document"));
            fileTypes.Add(new FileTypeData(".te", "Textease CT Database File"));
            fileTypes.Add(new FileTypeData(".accdt", "Microsoft Access Database Template"));
            fileTypes.Add(new FileTypeData(".alf", "ACT! Lookup File"));
            fileTypes.Add(new FileTypeData(".ask", "askSam Database"));
            fileTypes.Add(new FileTypeData(".dbc", "FoxPro Database"));
            fileTypes.Add(new FileTypeData(".fpt", "FileMaker Pro Database Memo File"));
            fileTypes.Add(new FileTypeData(".ib", "InterBase Database"));
            fileTypes.Add(new FileTypeData(".lgc", "SimpleK Database File"));
            fileTypes.Add(new FileTypeData(".maq", "Microsoft Access Query"));
            fileTypes.Add(new FileTypeData(".mav", "Access View File"));
            fileTypes.Add(new FileTypeData(".pan", "Panorama Database File"));
            fileTypes.Add(new FileTypeData(".sdb", "SparkleDB Database File"));
            fileTypes.Add(new FileTypeData(".sqlite3", "SQLite 3 Database File"));
            fileTypes.Add(new FileTypeData(".crypt7", "WhatsApp Encrypted Database File"));
            fileTypes.Add(new FileTypeData(".frm", "MySQL Database Format File"));
            fileTypes.Add(new FileTypeData(".wmdb", "Windows Media Database File"));
            fileTypes.Add(new FileTypeData(".db", "Database File"));
            fileTypes.Add(new FileTypeData(".pdb", "Program Database"));
            fileTypes.Add(new FileTypeData(".fdb", "Microsoft Dynamics NAV Database File"));
            fileTypes.Add(new FileTypeData(".sdb", "OpenOffice.org Base Database File"));
            fileTypes.Add(new FileTypeData(".accdb", "Access 2007 Database File"));
            fileTypes.Add(new FileTypeData(".sis", "Sisma Database File"));
            fileTypes.Add(new FileTypeData(".nsf", "Lotus Notes Database"));
            fileTypes.Add(new FileTypeData(".mdb", "Microsoft Access Database"));
            fileTypes.Add(new FileTypeData(".cdb", "CardScan Contacts Database"));
            fileTypes.Add(new FileTypeData(".udl", "Microsoft Universal Data Link File"));
            fileTypes.Add(new FileTypeData(".gdb", "InterBase Database File"));
            fileTypes.Add(new FileTypeData(".v12", "All The Right Type Database File"));
            fileTypes.Add(new FileTypeData(".sql", "Structured Query Language Data File"));
            fileTypes.Add(new FileTypeData(".wdb", "Microsoft Works Database"));
            fileTypes.Add(new FileTypeData(".dbf", "Database File"));
            fileTypes.Add(new FileTypeData(".4dd", "4th Dimension Database Data File"));
            fileTypes.Add(new FileTypeData(".$er", "GroupWise Database"));
            fileTypes.Add(new FileTypeData(".dbs", "SQLBase Database File"));
            fileTypes.Add(new FileTypeData(".ddl", "Data Definition Language File"));
            fileTypes.Add(new FileTypeData(".dtsx", "DTS Settings File"));
            fileTypes.Add(new FileTypeData(".ecx", "ECCO Corrupted Database File"));
            fileTypes.Add(new FileTypeData(".4dl", "4th Dimension Database Log File"));
            fileTypes.Add(new FileTypeData(".abs", "Absolute Database File"));
            fileTypes.Add(new FileTypeData(".accdw", "Microsoft Access Database Link File"));
            fileTypes.Add(new FileTypeData(".crypt6", "WhatsApp Encrypted Database File"));
            fileTypes.Add(new FileTypeData(".d", "-wal	SQLite Database Write-Ahead Log File"));
            fileTypes.Add(new FileTypeData(".dsk", "Simple IDs Database"));
            fileTypes.Add(new FileTypeData(".rbf", "Redatam Binary File"));
            fileTypes.Add(new FileTypeData(".rod", "RIB office Database File"));
            fileTypes.Add(new FileTypeData(".fp3", "FileMaker Pro 3 Database"));
            fileTypes.Add(new FileTypeData(".ndf", "SQL Server Secondary Database File"));
            fileTypes.Add(new FileTypeData(".crypt8", "WhatsApp Encrypted Database File"));
            fileTypes.Add(new FileTypeData(".fmp12", "FileMaker Pro 12 Database"));
            fileTypes.Add(new FileTypeData(".itdb", "iTunes Database File"));
            fileTypes.Add(new FileTypeData(".tps", "Clarion TopSpeed Data File"));
            fileTypes.Add(new FileTypeData(".ora", "Oracle Database Configuration File"));
            fileTypes.Add(new FileTypeData(".accdc", "Microsoft Access Signed Package"));
            fileTypes.Add(new FileTypeData(".accde", "Access Execute Only Database"));
            fileTypes.Add(new FileTypeData(".accdr", "Access Runtime Application"));
            fileTypes.Add(new FileTypeData(".accft", "Microsoft Access Data Type Template"));
            fileTypes.Add(new FileTypeData(".adb", "Alpha Five Database File"));
            fileTypes.Add(new FileTypeData(".cdb", "Pocket Access Database"));
            fileTypes.Add(new FileTypeData(".ckp", "SQL Server Checkpoint File"));
            fileTypes.Add(new FileTypeData(".cpd", "RoboHelp Cache Project Database"));
            fileTypes.Add(new FileTypeData(".daconnections", "RemObjects Data Abstract Connections File"));
            fileTypes.Add(new FileTypeData(".dacpac", "SQL Server Data Tier Application Package"));
            fileTypes.Add(new FileTypeData(".daschema", "RemObjects Data Abstract Schema File"));
            fileTypes.Add(new FileTypeData(".dbv", "Database Variable Field"));
            fileTypes.Add(new FileTypeData(".dcb", "Concordance Database File"));
            fileTypes.Add(new FileTypeData(".dxl", "Domino XML Language File"));
            fileTypes.Add(new FileTypeData(".eco", "ECCO Database File"));
            fileTypes.Add(new FileTypeData(".epim", "EssentialPIM Database File"));
            fileTypes.Add(new FileTypeData(".fmpsl", "FileMaker Pro 12 Snapshot Link"));
            fileTypes.Add(new FileTypeData(".gwi", "GroupWise Database Shortcut File"));
            fileTypes.Add(new FileTypeData(".hdb", "HansaWorld Database File"));
            fileTypes.Add(new FileTypeData(".ihx", "IN-HEH Timeline Database"));
            fileTypes.Add(new FileTypeData(".itw", "InTouch With Database File"));
            fileTypes.Add(new FileTypeData(".kexi", "Kexi Database"));
            fileTypes.Add(new FileTypeData(".marshal", "Marshal Data Migration Model File"));
            fileTypes.Add(new FileTypeData(".myd", "MySQL Database Data File"));
            fileTypes.Add(new FileTypeData(".nrmlib", "Neat Cabinet File"));
            fileTypes.Add(new FileTypeData(".odb", "OpenDocument Database"));
            fileTypes.Add(new FileTypeData(".oqy", "Excel OLAP Query File"));
            fileTypes.Add(new FileTypeData(".p97", "Win97 Database File"));
            fileTypes.Add(new FileTypeData(".pnz", "Panorama Database Set"));
            fileTypes.Add(new FileTypeData(".spq", "SPSS Database Query File"));
            fileTypes.Add(new FileTypeData(".trc", "Oracle Trace File"));
            fileTypes.Add(new FileTypeData(".udb", "Dynamics AX User Database File"));
            fileTypes.Add(new FileTypeData(".usr", "FileMaker Pro Database File"));
            fileTypes.Add(new FileTypeData(".vis", "Visual Importer Script"));
            fileTypes.Add(new FileTypeData(".xdb", "PowerDesigner Database Definition File"));
            fileTypes.Add(new FileTypeData(".cma", "TM1 Exported Cube File"));
            fileTypes.Add(new FileTypeData(".mdt", "GeoMedia Access Database Template"));
            fileTypes.Add(new FileTypeData(".orx", "RadiantOne VDS Database Schema"));
            fileTypes.Add(new FileTypeData(".rpd", "RIB Project Database File"));
            fileTypes.Add(new FileTypeData(".trc", "SQL Server Trace File"));
            fileTypes.Add(new FileTypeData(".db2", "dBASE II Database"));
            fileTypes.Add(new FileTypeData(".mdbhtml", "Microsoft Access Database HTML File"));
            fileTypes.Add(new FileTypeData(".kdb", "Keypass Database File"));
            fileTypes.Add(new FileTypeData(".dcx", "FoxPro Database Index"));
            fileTypes.Add(new FileTypeData(".cat", "Advanced Disk Catalog Database"));
            fileTypes.Add(new FileTypeData(".maf", "Microsoft Access Form"));
            fileTypes.Add(new FileTypeData(".xld", "Excel Database File"));
            fileTypes.Add(new FileTypeData(".rsd", "RealSQLDatabase File"));
            fileTypes.Add(new FileTypeData(".dbt", "Database Text File"));
            fileTypes.Add(new FileTypeData(".nv2", "NewViews 2 Database File"));
            fileTypes.Add(new FileTypeData(".p96", "Win96 Database File"));
            fileTypes.Add(new FileTypeData(".adb", "Ability Database File"));
            fileTypes.Add(new FileTypeData(".nv", "NewViews Database File"));
            fileTypes.Add(new FileTypeData(".sbf", "Superbase Database File"));
            fileTypes.Add(new FileTypeData(".mpd", "Microsoft Project Database"));
            fileTypes.Add(new FileTypeData(".d", "-shm	SQLite Database Shared Memory File"));
            fileTypes.Add(new FileTypeData(".fp5", "FileMaker Pro 5 Database"));
            fileTypes.Add(new FileTypeData(".^^^	Pervasiv", ".SQL Database File"));
            fileTypes.Add(new FileTypeData(".pdb", "Palm Desktop Database File"));
            fileTypes.Add(new FileTypeData(".ade", "Access Project Extension"));
            fileTypes.Add(new FileTypeData(".qry", "Query File"));
            fileTypes.Add(new FileTypeData(".scx", "FoxPro Form"));
            fileTypes.Add(new FileTypeData(".abcddb", "Apple Address Book Contact List"));
            fileTypes.Add(new FileTypeData(".abx", "WordPerfect Address Book"));
            fileTypes.Add(new FileTypeData(".adn", "Access Blank Project Template"));
            fileTypes.Add(new FileTypeData(".btr", "Btrieve Database File"));
            fileTypes.Add(new FileTypeData(".crypt5", "WhatsApp Encrypted Database File"));
            fileTypes.Add(new FileTypeData(".dad", "RemObjects Data Abstract Driver File"));
            fileTypes.Add(new FileTypeData(".dadiagrams", "RemObjects Data Abstract Data Diagrams File"));
            fileTypes.Add(new FileTypeData(".dbx", "Visual FoxPro Table"));
            fileTypes.Add(new FileTypeData(".dct", "FoxPro Database Memo"));
            fileTypes.Add(new FileTypeData(".dqy", "Excel Query File"));
            fileTypes.Add(new FileTypeData(".flexolibrary", "Final Cut Pro Library Database"));
            fileTypes.Add(new FileTypeData(".his", "FindinSite Database Definition File"));
            fileTypes.Add(new FileTypeData(".jet", "JET Database File"));
            fileTypes.Add(new FileTypeData(".jtx", "ESE Transaction Log"));
            fileTypes.Add(new FileTypeData(".kexic", "Kexi Database Connection File"));
            fileTypes.Add(new FileTypeData(".kexis", "Kexi Database Shortcut File"));
            fileTypes.Add(new FileTypeData(".mar", "Microsoft Access Report"));
            fileTypes.Add(new FileTypeData(".mas", "Access Stored Procedures"));
            fileTypes.Add(new FileTypeData(".maw", "Access Data Access Page"));
            fileTypes.Add(new FileTypeData(".mrg", "MySQL Merge File"));
            fileTypes.Add(new FileTypeData(".mud", "Textease Multi User Database"));
            fileTypes.Add(new FileTypeData(".nnt", "Eudora Address Book File"));
            fileTypes.Add(new FileTypeData(".ns3", "Lotus Notes 3 Database"));
            fileTypes.Add(new FileTypeData(".ns4", "Lotus Notes 4 Database"));
            fileTypes.Add(new FileTypeData(".odb", "ABAQUS Database"));
            fileTypes.Add(new FileTypeData(".owc", "OutWit Catch Database"));
            fileTypes.Add(new FileTypeData(".rod", "Ancestry Genealogical Database File"));
            fileTypes.Add(new FileTypeData(".rodx", "Ancestry Genealogical Database File"));
            fileTypes.Add(new FileTypeData(".teacher", "SMART Response Teacher Database File"));
            fileTypes.Add(new FileTypeData(".tmd", "MySQL Temporary Database File"));
            fileTypes.Add(new FileTypeData(".trm", "Oracle Trace Map File"));
            fileTypes.Add(new FileTypeData(".vpd", "VoxPro Database File"));
            fileTypes.Add(new FileTypeData(".wrk", "SQL Server Log Shipping File"));
            fileTypes.Add(new FileTypeData(".ns2", "Lotus Notes 2 Database"));
            fileTypes.Add(new FileTypeData(".db3", "SQLite Database File"));
            fileTypes.Add(new FileTypeData(".fcd", "First Choice Database"));
            fileTypes.Add(new FileTypeData(".fm5", "FileMaker 5 Database"));
            fileTypes.Add(new FileTypeData(".fmp", "FileMaker Pro Database"));
            fileTypes.Add(new FileTypeData(".fol", "PFS First Choice Database File"));
            fileTypes.Add(new FileTypeData(".fp4", "FileMaker Pro 4 Database"));
            fileTypes.Add(new FileTypeData(".mdn", "Blank Access Database Template"));
            fileTypes.Add(new FileTypeData(".rctd", "RabbitCT Dataset"));


            return fileTypes;
        }
    }
}
