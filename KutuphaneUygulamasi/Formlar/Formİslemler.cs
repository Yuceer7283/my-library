using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneUygulamasi.Formlar
{
    public partial class Formİslemler : Form
    {
        public Formİslemler()
        {
            InitializeComponent();
        }
        private void btnTurleriYonet_Click(object sender, EventArgs e)
        {
            Formlar.FormTurEkleme fs = new FormTurEkleme();
            fs.ShowDialog();
        }

        private void btnKitapGoruntule_Click(object sender, EventArgs e)
        {
            Formlar.FormKitaplariGoruntule fs = new FormKitaplariGoruntule();
            fs.ShowDialog();
        }

        private void btnKitapİslemleri_Click(object sender, EventArgs e)
        {
            Formlar.FormKitapİslemleri fs = new FormKitapİslemleri();
            fs.ShowDialog();
        }

        private void btnOdunKitapİslemleri_Click(object sender, EventArgs e)
        {
            Formlar.FormOduncKitap fs = new FormOduncKitap();
            fs.ShowDialog();
        }

        private void btnOduncGoruntule_Click(object sender, EventArgs e)
        {
            Formlar.FormOduncKitaplariGoruntule fs = new FormOduncKitaplariGoruntule();
            fs.ShowDialog();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            Formlar.FormLog fs = new FormLog();
            fs.ShowDialog();
        }

        private void btnGecmisKitap_Click(object sender, EventArgs e)
        {
            Formlar.FormTarihiGecmisOdunc fs = new FormTarihiGecmisOdunc();
            fs.ShowDialog();
        }
    }
}
