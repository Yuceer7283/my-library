using StokTakip.Sınıflar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneUygulamasi.Formlar
{
    public partial class FormOduncKitap : Form
    {
        public FormOduncKitap()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(BaglantiDizesi.baglanti);
        #region Kod 

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
            
            con.Open();
            SqlCommand komut = new SqlCommand("select * from turTbl", con);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                cmbKitapTuru.Items.Add(oku["tur_adi"]);
            }
            con.Close();
        }

        void KitapGetir()
        {
            if (cmbKitapTuru.Text == "Hepsi")
            {
                con.Open();
                string queryy = "SELECT * FROM kitapTbl";
                SqlCommand komutt = new SqlCommand(queryy, con);
                SqlDataReader okuu = komutt.ExecuteReader();
                cmbKitapAdi.Items.Clear();
                while (okuu.Read())
                {
                    cmbKitapAdi.Items.Add(okuu["kitapadi"]);
                }
                con.Close();
            }
            else
            {
                con.Open();
                string queryy = "SELECT * FROM kitapTbl where kitapturu='" + cmbKitapTuru.Text + "'";
                SqlCommand komutt = new SqlCommand(queryy, con);
                SqlDataReader okuu = komutt.ExecuteReader();
                cmbKitapAdi.Items.Clear();
                while (okuu.Read())
                {
                    cmbKitapAdi.Items.Add(okuu["kitapadi"]);
                }
                con.Close();
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

        void gpTurTemizle()
        {
            foreach (Control item in gpTUR.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
                if(item is ComboBox) 
                {
                    item.Text = "";
                }
            }
        }

        void gpIDTemizle()
        {
            foreach (Control item in gpID.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
                if (item is ComboBox)
                {
                    item.Text = "";
                }
            }
        }





        void OduncVer()
        {
            string sorgu;
            string sorguu;
            EkleGuncel ms = new EkleGuncel();

            if (!gpID.Visible)
            {
                int verilenMiktar = 1;
                sorgu = "insert into oduncTbl values(" +
                        "'" + txtKitapKodu.Text + "'," +
                        "'" + txtTCKİMLİK.Text + "'," +
                        "'" + txtADSOYAD.Text + "'," +
                        "'" + txtNUMARA.Text + "'," +
                        "'" + cmbKitapAdi.Text + "'," +
                        "'" + yetkili + "'," +
                        "'" + DateTime.Now.ToString() + "'," +
                        "'" + dpSecme.Text + "')";

                sorguu = "insert into logTbl values('" + yetkili + "','" + "Ödünç Kitap Verme" + "','" + cmbKitapAdi.Text + "','" + "Kitap Ödünç Verildi" + "')";

                try
                {
                    string stok = "select kitapstok from kitapTbl where kitapadi = '" + cmbKitapAdi.Text + "'";
                    SqlCommand sss = new SqlCommand(stok, con);
                    con.Open();
                    object result = sss.ExecuteScalar();
                    con.Close();

                    int mevcutStok = (result != null) ? Convert.ToInt32(result) : 0;

                    if (mevcutStok <= 0)
                    {
                        MessageBox.Show("Stokta kitap kalmadı. Ödünç verilemez.", "Sistem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    DateTime secilenTarih = DateTime.Parse(dpSecme.Text);

                    if (secilenTarih < DateTime.Now)
                    {
                        MessageBox.Show("Seçilen tarih bugünden küçük olamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    string stokSorgusu = "update kitapTbl set kitapstok = kitapstok - " + verilenMiktar + " where kitapadi = '" + cmbKitapAdi.Text + "'";

                    ms.Ekleme(sorguu);
                    ms.Ekleme(stokSorgusu);
                    ms.Ekleme(sorgu);

                    MessageBox.Show("Ödünç Kitap Başarıyla Eklendi", "Sistem", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    gpTurTemizle();
                    Listele();
                    AlanSil();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                int verilenMiktar = 1;
                sorgu = "insert into oduncTbl values(" +
                        "'" + txtKitapID.Text + "'," +
                        "'" + txtTCKİMLİK.Text + "'," +
                        "'" + txtADSOYAD.Text + "'," +
                        "'" + txtNUMARA.Text + "'," +
                        "'" + KitapAdi.Text + "'," +
                        "'" + yetkili + "'," +
                        "'" + DateTime.Now.ToString() + "'," +
                        "'" + dtpID.Text + "')";

                sorguu = "insert into logTbl values('" + yetkili + "','" + "Ödünç Kitap Verme" + "','" + KitapAdi.Text + "','" + "Kitap Ödünç Verildi" + "')";

                try
                {
                    string stok = "select kitapstok from kitapTbl where kitapadi = '" + KitapAdi.Text + "'";
                    SqlCommand sss = new SqlCommand(stok, con);
                    con.Open();
                    object result = sss.ExecuteScalar();
                    con.Close();

                    int mevcutStok = (result != null) ? Convert.ToInt32(result) : 0;

                    if (mevcutStok <= 0)
                    {
                        MessageBox.Show("Stokta kitap kalmadı. Ödünç verilemez.", "Sistem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    DateTime secilenTarih = DateTime.Parse(dtpID.Text);

                    if (secilenTarih < DateTime.Now)
                    {
                        MessageBox.Show("Seçilen tarih bugünden küçük olamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    string stokSorgusu = "update kitapTbl set kitapstok = kitapstok - " + verilenMiktar + " where kitapadi = '" + KitapAdi.Text + "'";

                    ms.Ekleme(stokSorgusu);
                    ms.Ekleme(sorguu);
                    ms.Ekleme(sorgu);

                    MessageBox.Show("Ödünç Kitap Başarıyla Eklendi", "Sistem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AlanSil();
                    gpIDTemizle();
                    Listele();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


        void AlanSil()
        {
            foreach (Control item in gpAlici.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }





        void idyegore()
        {
            con.Open();
            string queryy = "SELECT * FROM kitapTbl where kitapid='" + txtKitapID.Text + "'";
            SqlCommand komutt = new SqlCommand(queryy, con);
            SqlDataReader okuu = komutt.ExecuteReader();
            while (okuu.Read())
            {
                Yayinevi.Text = okuu["yayinevi"].ToString();
                basimyili.Text = okuu["basimyili"].ToString();
                KitapAdi.Text = okuu["kitapadi"].ToString();
                yazar.Text = okuu["yazar"].ToString();
                sayfasayisi.Text = okuu["sayfasayisi"].ToString();
                stokadedi.Text = okuu["kitapstok"].ToString();
                kitapturu.Text = okuu["kitapturu"].ToString();

            }
            con.Close();          
        }
        void KitaplarıGetir()
        {
            con.Open();
            string queryy = "SELECT * FROM kitapTbl where kitapadi='" + cmbKitapAdi.Text + "'";
            SqlCommand komutt = new SqlCommand(queryy, con);
            SqlDataReader okuu = komutt.ExecuteReader();
            while (okuu.Read())
            {
                txtYayinEvi.Text=okuu["yayinevi"].ToString();
                txtBasimYili.Text = okuu["basimyili"].ToString();
                txtKitapKodu.Text = okuu["kitapid"].ToString();
                txtKitapYazari.Text = okuu["yazar"].ToString();
                txtSayfaSayisi.Text = okuu["sayfasayisi"].ToString();
                txtStokAdedi.Text = okuu["kitapstok"].ToString();

            }
            con.Close();
        }

        #endregion
        private void FormOduncKitap_Load(object sender, EventArgs e)
        {
            YetkiGetir();
            TurGetir();
            cmbKitapAdi.SelectedIndex = 0;
        }

        private void cmbKitapTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            KitapGetir();
            cmbKitapAdi.Text = "";
            cmbKitapAdi.Enabled = true;
        }

        private void cmbKitapAdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            KitaplarıGetir();
        }

        private void txtKitapID_TextChanged(object sender, EventArgs e)
        {
            Yayinevi.Text = "";
            basimyili.Text = "";
            KitapAdi.Text = "";
            yazar.Text = "";
            sayfasayisi.Text = "";
            stokadedi.Text = "";
            kitapturu.Text = "";
            idyegore();  
        }

        private void btnTur_Click(object sender, EventArgs e)
        {
            gpTUR.Location = new Point(5, 0);
            gpTUR.Visible = true;
            btnTur.Visible = false;
            btnID.Visible = false;
            Listele();
        }

        private void btnID_Click(object sender, EventArgs e)
        {
            gpID.Location = new Point(5, 0);
            Listele();
            gpID.Visible = true;
            btnID.Visible = false;
            btnTur.Visible = false;
        }

        private void btnOduncVer_Click(object sender, EventArgs e)
        {
            OduncVer();
        }
    }
}
