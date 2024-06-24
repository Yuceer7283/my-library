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
    public partial class FormTurEkleme : Form
    {
        public FormTurEkleme()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(BaglantiDizesi.baglanti);
        #region Kod

        void Listele()
        {
            con.Open();
            SqlDataAdapter cmd = new SqlDataAdapter("select * from turTbl", con);
            DataSet ds = new DataSet();
            cmd.Fill(ds, "turTbl");
            dataGridView1.DataSource = ds.Tables["turTbl"];
            dataGridView1.Columns[0].HeaderText = "Tür ID";
            dataGridView1.Columns[1].HeaderText = "Tür Adı";
            con.Close();
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

        void Sil()
        {
            string sorgu = "Delete From turTbl Where id=@id";
            SqlCommand komut = new SqlCommand(sorgu, con);
            komut.Parameters.AddWithValue("@id", dataGridView1.CurrentRow.Cells[0].Value);
            con.Open();
            var uyari = MessageBox.Show("Seçtiğiniz Türü Silmek İstediğinize Emin misiniz?", "Sistem", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (uyari == DialogResult.Yes)
            {
                komut.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Tür Başarıyla Silindi.", "Sistem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                string sorguu = "insert into logTbl values('" + yetkili + "','" + "Tür Silme" + "','" + dataGridView1.SelectedRows[0].Cells[1].Value.ToString() + "','" + "Tür Silindi" + "')";
                EkleGuncel ms = new EkleGuncel();
                ms.Ekleme(sorguu);
            }
            else
            {

            }
            Listele();
        }

        void Ekle()
        {
            string sorgu = "insert into turTbl values('" + textBox1.Text + "')";
            EkleGuncel ms = new EkleGuncel();
            try
            {
                ms.Ekleme(sorgu);
                MessageBox.Show("Ürün Başarıyla Eklendi", "Sistem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                string sorguu = "insert into logTbl values('" + yetkili + "','" + "Tür Ekleme" + "','" + textBox1.Text + "','" + "Tür Eklendi" + "')";
                ms.Ekleme(sorguu);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Listele();
            textBox1.Text = "";
        }

        #endregion
        private void brnEkle_Click(object sender, EventArgs e)
        {
            Ekle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Sil();
        }

        private void FormTurEkleme_Load(object sender, EventArgs e)
        {

            Listele();
            YetkiGetir();
        }
    }
}
