using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FF_TRPG_Database_Management_Service;

namespace FF_TRPG_DatabaseTestUtility
{
    class TestEntry
    {
        static void Main(string[] args)
        {
            TRPG_Database testdatabase = new TRPG_Database();
            testdatabase.CreateNewDatabase("testdb");
        }
    }
}
