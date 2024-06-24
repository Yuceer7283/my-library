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
    public partial class FormKitapİslemleri : Form
    {
        public FormKitapİslemleri()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(BaglantiDizesi.baglanti);
        #region Kod

        #region Ekleme
        void EkleListele()
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
        void EkleTurGetir()
        {
            con.Open();
            SqlCommand komut = new SqlCommand("select * from turTbl", con);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                cmbKitapTuru.Items.Add(oku["tur_adi"]);
            }
            con.Close();

        }
        void EkleTemizle()
        {
            foreach (Control item in tpKitapEkle.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                    cmbKitapTuru.Text = "";
                }
            }
        }
        private string yetkili;
        void YetkiGetir()
        {
            con.Open();
            SqlCommand komut = new SqlCommand("select * from kullaniciTbl where id='" + GirisYapan.id + "'", con);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                yetkili = (oku["k_adi"]).ToString();
            }
            con.Close();
        }
        void Ekle()
        {
            string sorgu = "insert into kitapTbl values(" +
                "'" + txtKitapKodu.Text + "'" +
                ",'" + txtKitapAdi.Text + "','" +
                "" + cmbKitapTuru.Text + "','"
                + txtYayinEvi.Text + "'," +
                "'" + txtKitapYazari.Text + "'," +
                "'" + txtBasimYili.Text + "'," +
                "'" + txtSayfaSayisi.Text + "'," +
                "'" + txtStokAdedi.Text + "','" +
                ""+yetkili+"')";
            EkleGuncel ms = new EkleGuncel();
            try
            {
                ms.Ekleme(sorgu);
                string sorguu = "insert into logTbl values('" + yetkili + "','" + "Kitap Ekleme" + "','" + txtKitapAdi.Text + "','" + "Kitap Eklendi" + "')";
                ms.Ekleme(sorguu);
                MessageBox.Show("Kitap Başarıyla Eklendi", "Sistem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                EkleListele();
                EkleTemizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        #region Guncelle
        void GuncelleListele()
        {
            con.Open();
            SqlDataAdapter cmd = new SqlDataAdapter("select * from kitapTbl", con);
            DataSet ds = new DataSet();
            cmd.Fill(ds, "kitapTbl");
            dgwGuncel.DataSource = ds.Tables["kitapTbl"];
            dgwGuncel.Columns[0].HeaderText = "Kitap Kodu";
            dgwGuncel.Columns[1].HeaderText = "Kitap Adı";
            dgwGuncel.Columns[2].HeaderText = "Kitap Türü";
            dgwGuncel.Columns[3].HeaderText = "Yayın Evi";
            dgwGuncel.Columns[4].HeaderText = "Kitap Yazarı";
            dgwGuncel.Columns[5].HeaderText = "Basım Yılı";
            dgwGuncel.Columns[6].HeaderText = "Sayfa Sayısı";
            dgwGuncel.Columns[7].HeaderText = "Stok Sayısı";
            dgwGuncel.Columns[8].HeaderText = "İşlemi Yapan Yetkili";
            con.Close();
        }
        void GuncelTurGetir()
        {
            con.Open();
            SqlCommand komut = new SqlCommand("select * from turTbl", con);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                cmbGunKitapTuru.Items.Add(oku["tur_adi"]);
                cmbUrunTurGun.Items.Add(oku["tur_adi"]);
            }
            con.Close();

        }
        void GuncelUrunAra()
        {
            if (cmbUrunTurGun.SelectedIndex == 0)
            {
                SqlCommand komut = new SqlCommand("select * from kitapTbl where kitapadi like '" + txtAraGun.Text + "%' ", con);
                SqlDataAdapter ks = new SqlDataAdapter(komut);
                DataTable tablo = new DataTable();
                ks.Fill(tablo);
                dgwGuncel.DataSource = tablo;
            }
            else
            {
                con.Open();
                SqlCommand komut = new SqlCommand("SELECT * FROM kitapTbl WHERE kitapturu = '" + cmbUrunTurGun.SelectedItem.ToString() + "' AND kitapadi LIKE '" + txtAraGun.Text + "' + '%'", con);
                SqlDataAdapter ks = new SqlDataAdapter(komut);
                DataTable tablo = new DataTable();
                ks.Fill(tablo);
                dgwGuncel.DataSource = tablo;
                con.Close();
            }
        }


        void GuncelTemizle()
        {
            foreach (Control item in tpKitapDuzenle.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                    cmbGunKitapTuru.Text = "";
                }
            }
        }
        int key = 0;
        void GuncelTextGetir()
        {
            txtGunKitapKodu.Text = dgwGuncel.SelectedRows[0].Cells[0].Value.ToString();
            txtGunKitapAdi.Text = dgwGuncel.SelectedRows[0].Cells[1].Value.ToString();
            cmbGunKitapTuru.Text = dgwGuncel.SelectedRows[0].Cells[2].Value.ToString();
            txtGunYayinevi.Text = dgwGuncel.SelectedRows[0].Cells[3].Value.ToString();
            txtGunKitapYazari.Text = dgwGuncel.SelectedRows[0].Cells[4].Value.ToString();
            txtGunBasimYili.Text = dgwGuncel.SelectedRows[0].Cells[5].Value.ToString();
            txtGunSayfaSayisi.Text = dgwGuncel.SelectedRows[0].Cells[6].Value.ToString();
            txtGunStok.Text = dgwGuncel.SelectedRows[0].Cells[7].Value.ToString();

            if (txtGunKitapKodu.Text == "")
            {
                key = 0;
            }
            else
            {
                key = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        void GuncelTurListele()
        {

            if (cmbUrunTurGun.SelectedIndex == 0)
            {
                SqlDataAdapter adapter = new SqlDataAdapter(selectCommandText: "SELECT * FROM kitapTbl", con);
                DataTable tablo = new DataTable();
                adapter.Fill(tablo);
                dgwGuncel.DataSource = tablo;
            }
            else
            {
                SqlDataAdapter adapter = new SqlDataAdapter(selectCommandText: "SELECT * FROM kitapTbl where kitapturu='" + cmbUrunTurGun.Text + "'", con);
                DataTable tablo = new DataTable();
                adapter.Fill(tablo);
                dgwGuncel.DataSource = tablo;
            }
        }

        void Guncelle()
        {
            EkleGuncel ms = new EkleGuncel();
            if (key == 0)
            {
                MessageBox.Show("Güncellenecek Kitabı Seçiniz");
            }
            else
            {
                try
                {
                    string sorgu = "UPDATE kitapTbl SET kitapid = '" + txtGunKitapKodu.Text + "', kitapadi = '" + txtGunKitapAdi.Text + "', kitapturu = '" + cmbGunKitapTuru.Text + "', yayinevi = '" + txtGunYayinevi.Text + "', yazar = '" + txtGunKitapYazari.Text + "', basimyili = '" + txtGunBasimYili.Text + "', sayfasayisi = '" + txtGunSayfaSayisi.Text + "', kitapstok = '" + txtGunStok.Text + "',yetkili='"+yetkili+"' WHERE kitapid = " + key;

                    string sorguu = "insert into logTbl values('" + yetkili + "','" + "Kitap Güncelleme" + "','" + dgwGuncel.SelectedRows[0].Cells[1].Value.ToString() + "','" + txtGunKitapAdi.Text + "')";
                    ms.Ekleme(sorguu);
                    ms.Guncelleme(sorgu);
                    MessageBox.Show("Kitap Başarıyla Güncellendi","Sistem",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                    GuncelleListele();
                    GuncelTemizle();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        #endregion
        #region Sil
        void SilListele()
        {
            con.Open();
            SqlDataAdapter cmd = new SqlDataAdapter("select * from kitapTbl", con);
            DataSet ds = new DataSet();
            cmd.Fill(ds, "kitapTbl");
            dgwSil.DataSource = ds.Tables["kitapTbl"];
            dgwSil.Columns[0].HeaderText = "Kitap Kodu";
            dgwSil.Columns[1].HeaderText = "Kitap Adı";
            dgwSil.Columns[2].HeaderText = "Kitap Türü";
            dgwSil.Columns[3].HeaderText = "Yayın Evi";
            dgwSil.Columns[4].HeaderText = "Kitap Yazarı";
            dgwSil.Columns[5].HeaderText = "Basım Yılı";
            dgwSil.Columns[6].HeaderText = "Sayfa Sayısı";
            dgwSil.Columns[7].HeaderText = "Stok Sayısı";
            dgwSil.Columns[8].HeaderText = "İşlemi Yapan Yetkili";
            con.Close();
        }


        void SilTurListele()
        {

            if (cmbKitapTurSil.SelectedIndex == 0)
            {
                SqlDataAdapter adapter = new SqlDataAdapter(selectCommandText: "SELECT * FROM kitapTbl", con);
                DataTable tablo = new DataTable();
                adapter.Fill(tablo);
                dgwSil.DataSource = tablo;
            }
            else
            {
                SqlDataAdapter adapter = new SqlDataAdapter(selectCommandText: "SELECT * FROM kitapTbl where kitapturu='" + cmbKitapTurSil.Text + "'", con);
                DataTable tablo = new DataTable();
                adapter.Fill(tablo);
                dgwSil.DataSource = tablo;
            }
        }

        void SilUrunAra()
        {
            if (cmbKitapTurSil.SelectedIndex == 0)
            {
                SqlCommand komut = new SqlCommand("select * from kitapTbl where kitapadi like '" + txtAraSil.Text + "%' ", con);
                SqlDataAdapter ks = new SqlDataAdapter(komut);
                DataTable tablo = new DataTable();
                ks.Fill(tablo);
                dgwSil.DataSource = tablo;
            }
            else
            {
                con.Open();
                SqlCommand komut = new SqlCommand("SELECT * FROM kitapTbl WHERE kitapturu = '" + cmbKitapTurSil.SelectedItem.ToString() + "' AND kitapadi LIKE '" + txtAraSil.Text + "' + '%'", con);
                SqlDataAdapter ks = new SqlDataAdapter(komut);
                DataTable tablo = new DataTable();
                ks.Fill(tablo);
                dgwSil.DataSource = tablo;
                con.Close();
            }
        }
        void SilTextGetir()
        {
            txtSilKitapKodu.Text = dgwSil.SelectedRows[0].Cells[0].Value.ToString();
            txtSilKitapAdi.Text = dgwSil.SelectedRows[0].Cells[1].Value.ToString();
            cmbSilKitapTuru.Text = dgwSil.SelectedRows[0].Cells[2].Value.ToString();
            txtSilYayinevi.Text = dgwSil.SelectedRows[0].Cells[3].Value.ToString();
            txtSilKitapYazari.Text = dgwSil.SelectedRows[0].Cells[4].Value.ToString();
            txtSilBasimYili.Text = dgwSil.SelectedRows[0].Cells[5].Value.ToString();
            txtSilSayfaSayisi.Text = dgwSil.SelectedRows[0].Cells[6].Value.ToString();
            txtSilStok.Text = dgwSil.SelectedRows[0].Cells[7].Value.ToString();

            if (txtSilKitapKodu.Text == "")
            {
                key = 0;
            }
            else
            {
                key = int.Parse(dgwSil.SelectedRows[0].Cells[0].Value.ToString());
            }
        }
        void SilKitapGetir()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from kitapTbl where kitapid like '" + txtSilKitapKodu.Text + "'", con);
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                txtSilKitapAdi.Text = read["kitapadi"].ToString();
                txtSilBasimYili.Text = read["basimyili"].ToString();
                txtSilYayinevi.Text = read["yayinevi"].ToString();
                txtSilStok.Text = read["kitapstok"].ToString();
                txtSilSayfaSayisi.Text = read["sayfasayisi"].ToString();
                cmbSilKitapTuru.Text = read["kitapturu"].ToString();
                txtSilKitapYazari.Text = read["yazar"].ToString();
            }
            con.Close();
        }
        void SilTemizle()
        {
            foreach (Control item in tpKitapSil.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                    cmbSilKitapTuru.Text = "";
                }
            }
        }

        void SilTurGetir()
        {
            cmbKitapTurSil.SelectedIndex = 0;
            con.Open();
            SqlCommand komut = new SqlCommand("select * from turTbl", con);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                cmbKitapTurSil.Items.Add(oku["tur_adi"]);
            }
            con.Close();
        }

        void Sil()  
        {
            string sorgu = "Delete From kitapTbl Where kitapid=@id";
                SqlCommand komut = new SqlCommand(sorgu, con);
                komut.Parameters.AddWithValue("@id", txtSilKitapKodu.Text);
                con.Open();
                var uyari = MessageBox.Show("Seçtiğiniz Ürünü Silmek İstediğinize Emin misiniz?", "Sistem", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (uyari == DialogResult.Yes)
                {
                EkleGuncel ms = new EkleGuncel();
                string sorguu = "insert into logTbl values('" + yetkili + "','" + "Kitap Silme" + "','" + dgwSil.SelectedRows[0].Cells[1].Value.ToString() + "','" +"Kitap Silindi"+ "')";
                ms.Ekleme(sorguu);
                komut.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Ürün Başarıyla Silindi.", "Sistem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {

                }
                SilTemizle();
                SilListele();
        }
        #endregion


        #endregion
        private void btnEkle_Click(object sender, EventArgs e)
        {
            Ekle();
        }

        private void FormKitapİslemleri_Load(object sender, EventArgs e)
        {
            EkleListele();
            GuncelleListele();
            EkleTurGetir();
            GuncelTurGetir();
            YetkiGetir();
            SilTurGetir();
        }

        private void dgwGuncel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GuncelTextGetir();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void tpKitapEkle_Enter(object sender, EventArgs e)
        {
            EkleListele();
            EkleTemizle();
        }

        private void tpKitapDuzenle_Enter(object sender, EventArgs e)
        {
            GuncelleListele();
            GuncelTemizle();
            
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Sil();
        }

        private void tpKitapSil_Enter(object sender, EventArgs e)
        {
            SilListele();
            SilTemizle();
        }

        private void dgwSil_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SilTextGetir();
        }

        private void txtSilKitapKodu_TextChanged(object sender, EventArgs e)
        {
            SilKitapGetir();
            if (txtSilKitapKodu.Text == "")
            {
                SilTemizle();
            }
        }

        private void txtAraGun_TextChanged(object sender, EventArgs e)
        {
            GuncelUrunAra();
        }

        private void cmbUrunTurGun_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtAraGun.Text = "";
            GuncelTurListele();
        }

        private void cmbKitapTurSil_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtAraSil.Text = "";
            SilTurListele();
        }

        private void txtAraSil_TextChanged(object sender, EventArgs e)
        {
            SilUrunAra();
        }
    }
}
