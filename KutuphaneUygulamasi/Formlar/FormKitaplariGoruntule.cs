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
    public partial class FormKitaplariGoruntule : Form
    {
        public FormKitaplariGoruntule()
        {
            InitializeComponent();
        }
        #region Kod  
        SqlConnection con = new SqlConnection(BaglantiDizesi.baglanti);
        void Listele()
        {
            con.Open();
            SqlDataAdapter cmd = new SqlDataAdapter("select * from kitapTbl", con);
            DataSet ds = new DataSet();
            cmd.Fill(ds, "kitapTbl");
            dataGridView1.DataSource = ds.Tables["kitapTbl"];
            dataGridView1.Columns[0].HeaderText = "Kitap Kodu";
            dataGridView1.Columns[1].HeaderText = "Kitap Adı";
            dataGridView1.Columns[2].HeaderText = "Kitap Türü";
            dataGridView1.Columns[3].HeaderText = "Yayın Evi";
            dataGridView1.Columns[4].HeaderText = "Kitap Yazarı";
            dataGridView1.Columns[5].HeaderText = "Basım Yılı";
            dataGridView1.Columns[6].HeaderText = "Sayfa Sayısı";
            dataGridView1.Columns[7].HeaderText = "Stok Sayısı";
            dataGridView1.Columns[8].HeaderText = "İşlemi Yapan Yetkili";
            con.Close();
        }

        void TurGetir()
        {
            cmbUrunTur.SelectedIndex = 0;
            con.Open();
            SqlCommand komut = new SqlCommand("select * from turTbl", con);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                cmbUrunTur.Items.Add(oku["tur_adi"]);
            }
            con.Close();

        }
        void UrunAra()
        {
            if (cmbUrunTur.SelectedIndex == 0)
            {
                SqlCommand komut = new SqlCommand("select * from kitapTbl where kitapadi like '" + txtAra.Text + "%' ", con);
                SqlDataAdapter ks = new SqlDataAdapter(komut);
                DataTable tablo = new DataTable();
                ks.Fill(tablo);
                dataGridView1.DataSource = tablo;
            }
            else
            {
                con.Open();
                SqlCommand komut = new SqlCommand("SELECT * FROM kitapTbl WHERE kitapturu = '" + cmbUrunTur.SelectedItem.ToString() + "' AND kitapadi LIKE '" + txtAra.Text + "' + '%'", con);
                SqlDataAdapter ks = new SqlDataAdapter(komut);
                DataTable tablo = new DataTable();
                ks.Fill(tablo);
                dataGridView1.DataSource = tablo;
                con.Close();
            }
        }
        void TurListele()
        {

            if (cmbUrunTur.SelectedIndex == 0)
            {
                SqlDataAdapter adapter = new SqlDataAdapter(selectCommandText: "SELECT * FROM kitapTbl", con);
                DataTable tablo = new DataTable();
                adapter.Fill(tablo);
                dataGridView1.DataSource = tablo;
            }
            else
            {
                SqlDataAdapter adapter = new SqlDataAdapter(selectCommandText: "SELECT * FROM kitapTbl where kitapturu='" + cmbUrunTur.Text + "'", con);
                DataTable tablo = new DataTable();
                adapter.Fill(tablo);
                dataGridView1.DataSource = tablo;
            }
        }
        #endregion
        private void cmbUrunTur_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtAra.Text = "";
            TurListele();
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            UrunAra();
        }

        private void FormKitaplariGoruntule_Load(object sender, EventArgs e)
        {
            Listele();
            TurGetir();
        }
    }
}
