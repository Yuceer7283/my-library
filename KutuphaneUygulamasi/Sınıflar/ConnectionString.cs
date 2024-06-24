using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.Sınıflar
{
    internal class ConnectionString
    {
        public SqlConnection GetCon()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=DESKTOP-N1ST5EV\SQLEXPRESS;Initial Catalog=KutuphaneDB;Integrated Security=True;TrustServerCertificate=True";
            return con;

            // "Data Source=.;Initial Catalog=TeknikServis;Persist Security Info=True;User ID=sa;Password=123456"
        }
    }
}
