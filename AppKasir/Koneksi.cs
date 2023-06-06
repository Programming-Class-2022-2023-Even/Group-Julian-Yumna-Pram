using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AppKasir
{
    internal class Koneksi
    {
        public SqlConnection GetConn()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data source=app.dds.co.id;initial catalog=DB_KASIR;uid=sa;pwd=Dds4rv4!";
            return conn;
        }
    }
}
