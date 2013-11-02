using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using FF_TRPG_ClassLibrary;

namespace FF_TRPG_Database_Management_Service
{
    /// <summary>
    /// Basic database class for TRPG
    /// </summary>
    public class TRPG_Database
    {
        const string start_item_tag = "<trpg_item>";
        const string close_item_tag = "</trpg_item>";
        const string item_number_tag = "<trpg_key=";

        const string start_magic_section_tag = "<trpg_magicsec>";
        const string close_magic_section_tag = "</trpg_magicsec>";

        private string _filepath; //bath to database file
        private int _magiccategorystartindex;
        private int _magiccategorynextindex;

        private FileStream streamcontrol;

        public void OpenConnection()
        {
            streamcontrol = new FileStream(_filepath, FileMode.OpenOrCreate,
                FileAccess.ReadWrite, FileShare.None);

            /*
             * opens connection to a database.
             * 
             * If _filepath is a database file, then do not create a new database. 
             * 
             * Else, create database tables.
             * For now, we will assume that only magic is contained in the database.
             * Items in database are bracketed by <trpg_item> </trpg_item>
             * database key is contained immedately after <trpg_key=#####>
             * 
             * key numbers are seperated by database categories, ie magic, skills, monsters, ect.
             * 
             * index in the database refers to the number at which the magic category starts
             */

        }

        public void WriteMagicToDabase(Magic magictowrite)
        {
           
        }

        public void OpenConnection(string filepath)
        {
            _filepath = filepath;
            OpenConnection();
        }
    }
}
