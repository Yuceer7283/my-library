using StokTakip.Sınıflar;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.Sınıflar
{
    internal class EkleGuncel
    {
        public void Ekleme(string sorgu)
        {
            ConnectionString MyConnection = new ConnectionString();
            SqlConnection con = MyConnection.GetCon();
            SqlCommand komut = new SqlCommand();
            komut.Connection = con;
            con.Open();
            komut.CommandText = sorgu;
            komut.ExecuteNonQuery();
            con.Close();
        }
        public void Guncelleme(string sorgu)
        {
            ConnectionString MyConnection = new ConnectionString();
            SqlConnection con = MyConnection.GetCon();
            SqlCommand komut = new SqlCommand();
            komut.Connection = con;
            con.Open();
            komut.CommandText = sorgu;
            komut.ExecuteNonQuery();
            con.Close();
        }
    }
}
