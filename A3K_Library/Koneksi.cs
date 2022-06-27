using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace A3K_Library
{
    class Koneksi
    {
        public SqlConnection GetConn()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source = LENOVO\\AKMALAMRAN;database=A3K_Library;MultipleActiveResultSets=true;User ID=sa;Password=uzumaki";
            return conn;
        }
    }
}
