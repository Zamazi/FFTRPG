using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FF_TRPG_Database_Management_Service
{
    /// <summary>
    /// Basic database class for TRPG
    /// </summary>
    public class TRPG_Database
    {
        private string _filepath; //bath to database file
        private int _magiccategorystartindex

        public void OpenConnection()
        {
            StreamReader openConnectionReader = new StreamReader(_filepath);

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

        public void WriteMagicToDabase()
        {
            
        }

        public void OpenConnection(string filepath)
        {
            _filepath = filepath;
            OpenConnection();
        }
    }
}
