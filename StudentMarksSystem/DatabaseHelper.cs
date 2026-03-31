
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;

namespace StudentMarksSystem
{
    public static class DatabaseHelper
    {
        private static string connectionString = "Data Source=192.168.1.3\\KMCSQL2; Initial Catalog=StudentMarksSystem; User ID=enadocsvc;Password=Sanjesi#123;";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}