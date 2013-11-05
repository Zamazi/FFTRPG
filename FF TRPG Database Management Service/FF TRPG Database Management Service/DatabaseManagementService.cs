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
        private string filepath; //bath to database file
        private int magiccategorystartindex;
        private int magiccategorynextindex;

        private FileStream filestream;

        public void OpenConnection()
        {
            filestream = new FileStream(filepath, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None);


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
             * index in the database refers to the number at which the 
             */

        }

        public void CreateNewDatabase(string DatabaseName)
        {
            using (StreamWriter _streamwriter = new StreamWriter("..\\..\\TestData\\" + DatabaseName + ".TDB"))
            {
                filepath = ((FileStream)(_streamwriter.BaseStream)).Name;
        
            }
            Magic test = new Magic();      
            WriteMagicToDabase(test);
        }

        public void WriteMagicToDabase(Magic MagicToWrite)
        {
            using (StreamWriter _streamwriter = new StreamWriter(filepath))
            {
                _streamwriter.WriteLine(MagicToWrite.ReturnTextOutput());
            }
        }

        public void OpenConnection(string FilepathIn)
        {
            filepath = FilepathIn;
            OpenConnection();
        }
    }
}
