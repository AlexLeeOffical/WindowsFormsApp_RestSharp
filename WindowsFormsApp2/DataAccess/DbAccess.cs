using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp2.Controllers;
using WindowsFormsApp2.Models;

namespace WindowsFormsApp2.DataAccess
{
    internal class DbAccess
    {
        private static string _myDatabase = "PARK_DB";
        private static string _myUserID = "parkuser";
        private static string _myPassword = "Parking@Sunshine4U!";
        private static string _myServer = "192.168.103.11";
        private static string _mySetting = "Connection Timeout=10;";
        private static string _connectionString = $"Database={_myDatabase}; UID={_myUserID}; PWD={_myPassword}; Server={_myServer}; {_mySetting}";

        public SqlConnection Connection()
        {
            return new SqlConnection(_connectionString);
        }
        
    }
    
}
