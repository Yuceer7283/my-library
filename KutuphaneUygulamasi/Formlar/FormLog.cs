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
    public partial class FormLog : Form
    {
        public FormLog()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(BaglantiDizesi.baglanti);
        #region Kod
        void Yetkili()
        {
                con.Open();
                SqlCommand komut = new SqlCommand("select * from kullaniciTbl", con);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    cmbYetkili.Items.Add(oku["k_adi"]).ToString();
                }
                con.Close();
        }
        void İslemTuru()
        {
            if (cmbTur.SelectedIndex == 0)
            {
                SqlDataAdapter adapter = new SqlDataAdapter(selectCommandText: "SELECT * FROM logTbl", con);
                DataTable tablo = new DataTable();
                adapter.Fill(tablo);
                dataGridView1.DataSource = tablo;
            }
            else
            {
                SqlDataAdapter adapter = new SqlDataAdapter(selectCommandText: "SELECT * FROM logTbl where islemTuru='" + cmbTur.Text + "'", con);
                DataTable tablo = new DataTable();
                adapter.Fill(tablo);
                dataGridView1.DataSource = tablo;
            }
        }
        void Sil()
        {
            string sorgu = "Delete From logTbl";
            SqlCommand komut = new SqlCommand(sorgu, con);
            con.Open();
            var uyari = MessageBox.Show("İşlem Kayıtlarını Silmek İstediğinize Emin misiniz?", "Sistem", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (uyari == DialogResult.Yes)
            {
                komut.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("İşlem Kayıtları Başarıyla Silindi.", "Sistem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listele();
            }
        }
        void Listele()
        {
            con.Open();
            SqlDataAdapter cmd = new SqlDataAdapter("select * from logTbl", con);
            DataSet ds = new DataSet();
            cmd.Fill(ds, "logTbl");
            dataGridView1.DataSource = ds.Tables["logTbl"];
            dataGridView1.Columns[0].HeaderText = "Log ID";
            dataGridView1.Columns[1].HeaderText = "İşlemi Yapan Yetkili";
            dataGridView1.Columns[2].HeaderText = "İşlem Türü";
            dataGridView1.Columns[3].HeaderText = "İşlem Gören Kitap";
            dataGridView1.Columns[4].HeaderText = "İşlem Sonrası";
            con.Close();
        }
        #endregion
        private void FormLog_Load(object sender, EventArgs e)
        {
            Listele();
            Yetkili();
        }

        private void cmbTur_SelectedIndexChanged(object sender, EventArgs e)
        {
            İslemTuru();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Sil();
        }

        private void cmbYetkili_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(selectCommandText: "SELECT * FROM logTbl where yapanyetkili='"+cmbYetkili.Text+"'", con);
            DataTable tablo = new DataTable();
            adapter.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }
    }
}
