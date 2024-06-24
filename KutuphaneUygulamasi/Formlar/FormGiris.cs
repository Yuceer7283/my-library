using StokTakip.Sınıflar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneUygulamasi.Formlar
{
    public partial class FormGiris : Form
    {
        public FormGiris()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(BaglantiDizesi.baglanti);
        #region Kod
        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true) { txtSifre.PasswordChar = '\0'; }
            else { txtSifre.PasswordChar = '*'; }
        }

        void GirisYap()
        {
            try
            {
                string ad = txtKadi.Text;
                string sifre = txtSifre.Text;
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from kullaniciTbl where k_adi=@kad and sifre=@sifre", con);
                da.SelectCommand.Parameters.AddWithValue("kad", txtKadi.Text);
                da.SelectCommand.Parameters.AddWithValue("sifre", txtSifre.Text);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    GirisYapan.id = dt.Rows[0]["id"].ToString();
                    MessageBox.Show("Sayın " + txtKadi.Text + " hoş geldiniz", "Sistem", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Formlar.Formİslemler fs = new Formİslemler();
                    fs.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı!", "Sistem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Sistem");
            }
            finally
            {
                if (con != null && con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }

        }
        #endregion
        private void btnGiris_Click(object sender, EventArgs e)
        {
            GirisYap();
        }    
    }
}
