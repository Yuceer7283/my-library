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
    public partial class FormTarihiGecmisOdunc : Form
    {
        public FormTarihiGecmisOdunc()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(BaglantiDizesi.baglanti);
        #region Kod
        void TarihiGecmisOduncleriListele()
        {
            try
            {
                con.Open();

                string sorgu = "SELECT * FROM oduncTbl WHERE vermetarihi < '" + DateTime.Now + "'";
                SqlCommand komut = new SqlCommand(sorgu, con);

                SqlDataReader oku = komut.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(oku);
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].HeaderText = "Ödünç Kodu";
                dataGridView1.Columns[1].HeaderText = "Kitap Kodu";
                dataGridView1.Columns[2].HeaderText = "Alan TC";
                dataGridView1.Columns[3].HeaderText = "Alan Ad-Soyad";
                dataGridView1.Columns[4].HeaderText = "Alan Numara";
                dataGridView1.Columns[5].HeaderText = "Kitap Adı";
                dataGridView1.Columns[6].HeaderText = "Teslim Eden Yetkili";
                dataGridView1.Columns[7].HeaderText = "Alma Tarihi";
                dataGridView1.Columns[8].HeaderText = "Teslim Etme Tarihi";
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
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

        void IadeEt()
        {
            string oduncID = dataGridView1.SelectedRows[0].Cells["oduncID"].Value.ToString();
            string kitapKodu = dataGridView1.SelectedRows[0].Cells["kitapid"].Value.ToString();

            try
            {
                string stokGuncellemeSorgusu = "UPDATE kitapTbl SET kitapstok = kitapstok + 1 WHERE kitapid = @kitapKodu";
                using (SqlCommand stokGuncellemeKomutu = new SqlCommand(stokGuncellemeSorgusu, con))
                {
                    stokGuncellemeKomutu.Parameters.AddWithValue("@kitapKodu", kitapKodu);
                    con.Open();
                    stokGuncellemeKomutu.ExecuteNonQuery();
                    con.Close();
                }
                string oduncSilmeSorgusu = "DELETE FROM oduncTbl WHERE oduncID = @oduncID";
                using (SqlCommand oduncSilmeKomutu = new SqlCommand(oduncSilmeSorgusu, con))
                {
                    oduncSilmeKomutu.Parameters.AddWithValue("@oduncID", oduncID);
                    con.Open();
                    oduncSilmeKomutu.ExecuteNonQuery();
                    con.Close();
                }

                MessageBox.Show("Kitap başarıyla iade edildi ve stok güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                EkleGuncel ms = new EkleGuncel();
                string sorguu = "insert into logTbl values('" + yetkili + "','" + "Kitap İadesi Alma" + "','" + dataGridView1.SelectedRows[0].Cells["kitapadi"].Value.ToString() + "','" + "Kitap İade Edildi" + "')";
                ms.Ekleme(sorguu);
                TarihiGecmisOduncleriListele();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }
#endregion
        private void FormTarihiGecmisOdunc_Load(object sender, EventArgs e)
        {
            TarihiGecmisOduncleriListele();
        }
        private void btnİade_Click(object sender, EventArgs e)
        {
            IadeEt();
        }
    }
}
