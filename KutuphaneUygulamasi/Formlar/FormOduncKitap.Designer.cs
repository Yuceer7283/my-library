namespace KutuphaneUygulamasi.Formlar
{
    partial class FormOduncKitap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gpTUR = new System.Windows.Forms.GroupBox();
            this.dpSecme = new System.Windows.Forms.DateTimePicker();
            this.label18 = new System.Windows.Forms.Label();
            this.cmbKitapAdi = new System.Windows.Forms.ComboBox();
            this.txtKitapYazari = new System.Windows.Forms.TextBox();
            this.txtKitapKodu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSayfaSayisi = new System.Windows.Forms.TextBox();
            this.txtStokAdedi = new System.Windows.Forms.TextBox();
            this.cmbKitapTuru = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtYayinEvi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBasimYili = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gpID = new System.Windows.Forms.GroupBox();
            this.dtpID = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.kitapturu = new System.Windows.Forms.TextBox();
            this.KitapAdi = new System.Windows.Forms.TextBox();
            this.yazar = new System.Windows.Forms.TextBox();
            this.txtKitapID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.sayfasayisi = new System.Windows.Forms.TextBox();
            this.stokadedi = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Yayinevi = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.basimyili = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btnID = new System.Windows.Forms.Button();
            this.btnTur = new System.Windows.Forms.Button();
            this.btnOduncVer = new System.Windows.Forms.Button();
            this.gpAlici = new System.Windows.Forms.GroupBox();
            this.txtTCKİMLİK = new System.Windows.Forms.TextBox();
            this.txtADSOYAD = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtNUMARA = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gpTUR.SuspendLayout();
            this.gpID.SuspendLayout();
            this.gpAlici.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 243);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1234, 383);
            this.dataGridView1.TabIndex = 6;
            // 
            // gpTUR
            // 
            this.gpTUR.BackColor = System.Drawing.Color.Gray;
            this.gpTUR.Controls.Add(this.dpSecme);
            this.gpTUR.Controls.Add(this.label18);
            this.gpTUR.Controls.Add(this.cmbKitapAdi);
            this.gpTUR.Controls.Add(this.txtKitapYazari);
            this.gpTUR.Controls.Add(this.txtKitapKodu);
            this.gpTUR.Controls.Add(this.label1);
            this.gpTUR.Controls.Add(this.txtSayfaSayisi);
            this.gpTUR.Controls.Add(this.txtStokAdedi);
            this.gpTUR.Controls.Add(this.cmbKitapTuru);
            this.gpTUR.Controls.Add(this.label5);
            this.gpTUR.Controls.Add(this.txtYayinEvi);
            this.gpTUR.Controls.Add(this.label6);
            this.gpTUR.Controls.Add(this.label7);
            this.gpTUR.Controls.Add(this.label8);
            this.gpTUR.Controls.Add(this.txtBasimYili);
            this.gpTUR.Controls.Add(this.label4);
            this.gpTUR.Controls.Add(this.label3);
            this.gpTUR.Controls.Add(this.label2);
            this.gpTUR.ForeColor = System.Drawing.Color.White;
            this.gpTUR.Location = new System.Drawing.Point(814, 584);
            this.gpTUR.Name = "gpTUR";
            this.gpTUR.Size = new System.Drawing.Size(736, 225);
            this.gpTUR.TabIndex = 7;
            this.gpTUR.TabStop = false;
            this.gpTUR.Text = "Kitap Bilgileri Seçmece";
            this.gpTUR.Visible = false;
            // 
            // dpSecme
            // 
            this.dpSecme.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpSecme.Location = new System.Drawing.Point(592, 107);
            this.dpSecme.Name = "dpSecme";
            this.dpSecme.Size = new System.Drawing.Size(134, 29);
            this.dpSecme.TabIndex = 57;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(614, 83);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(90, 21);
            this.label18.TabIndex = 56;
            this.label18.Text = "İade Tarihi";
            // 
            // cmbKitapAdi
            // 
            this.cmbKitapAdi.Enabled = false;
            this.cmbKitapAdi.FormattingEnabled = true;
            this.cmbKitapAdi.Items.AddRange(new object[] {
            "Kitap Türü Seçin"});
            this.cmbKitapAdi.Location = new System.Drawing.Point(124, 75);
            this.cmbKitapAdi.Name = "cmbKitapAdi";
            this.cmbKitapAdi.Size = new System.Drawing.Size(165, 29);
            this.cmbKitapAdi.TabIndex = 52;
            this.cmbKitapAdi.SelectedIndexChanged += new System.EventHandler(this.cmbKitapAdi_SelectedIndexChanged);
            // 
            // txtKitapYazari
            // 
            this.txtKitapYazari.Enabled = false;
            this.txtKitapYazari.Location = new System.Drawing.Point(410, 32);
            this.txtKitapYazari.Name = "txtKitapYazari";
            this.txtKitapYazari.Size = new System.Drawing.Size(166, 29);
            this.txtKitapYazari.TabIndex = 51;
            // 
            // txtKitapKodu
            // 
            this.txtKitapKodu.Enabled = false;
            this.txtKitapKodu.Location = new System.Drawing.Point(410, 162);
            this.txtKitapKodu.Name = "txtKitapKodu";
            this.txtKitapKodu.Size = new System.Drawing.Size(166, 29);
            this.txtKitapKodu.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(299, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 21);
            this.label1.TabIndex = 36;
            this.label1.Text = "Kitap Kodu :";
            // 
            // txtSayfaSayisi
            // 
            this.txtSayfaSayisi.Enabled = false;
            this.txtSayfaSayisi.Location = new System.Drawing.Point(410, 120);
            this.txtSayfaSayisi.Name = "txtSayfaSayisi";
            this.txtSayfaSayisi.Size = new System.Drawing.Size(166, 29);
            this.txtSayfaSayisi.TabIndex = 50;
            // 
            // txtStokAdedi
            // 
            this.txtStokAdedi.Enabled = false;
            this.txtStokAdedi.Location = new System.Drawing.Point(123, 162);
            this.txtStokAdedi.Name = "txtStokAdedi";
            this.txtStokAdedi.Size = new System.Drawing.Size(166, 29);
            this.txtStokAdedi.TabIndex = 48;
            // 
            // cmbKitapTuru
            // 
            this.cmbKitapTuru.FormattingEnabled = true;
            this.cmbKitapTuru.Items.AddRange(new object[] {
            "Hepsi"});
            this.cmbKitapTuru.Location = new System.Drawing.Point(124, 32);
            this.cmbKitapTuru.Name = "cmbKitapTuru";
            this.cmbKitapTuru.Size = new System.Drawing.Size(165, 29);
            this.cmbKitapTuru.TabIndex = 49;
            this.cmbKitapTuru.SelectedIndexChanged += new System.EventHandler(this.cmbKitapTuru_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 21);
            this.label5.TabIndex = 46;
            this.label5.Text = "Stok Adedi :";
            // 
            // txtYayinEvi
            // 
            this.txtYayinEvi.Enabled = false;
            this.txtYayinEvi.Location = new System.Drawing.Point(123, 120);
            this.txtYayinEvi.Name = "txtYayinEvi";
            this.txtYayinEvi.Size = new System.Drawing.Size(166, 29);
            this.txtYayinEvi.TabIndex = 47;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(294, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 21);
            this.label6.TabIndex = 45;
            this.label6.Text = "Sayfa Sayısı :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(34, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 21);
            this.label7.TabIndex = 44;
            this.label7.Text = "Yayınevi :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(22, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 21);
            this.label8.TabIndex = 43;
            this.label8.Text = "Kitap Türü :";
            // 
            // txtBasimYili
            // 
            this.txtBasimYili.Enabled = false;
            this.txtBasimYili.Location = new System.Drawing.Point(410, 75);
            this.txtBasimYili.Name = "txtBasimYili";
            this.txtBasimYili.Size = new System.Drawing.Size(166, 29);
            this.txtBasimYili.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(309, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 21);
            this.label4.TabIndex = 39;
            this.label4.Text = "Basım Yılı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(299, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 21);
            this.label3.TabIndex = 38;
            this.label3.Text = "Kitap Yazarı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(30, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 21);
            this.label2.TabIndex = 37;
            this.label2.Text = "Kitap Adı :";
            // 
            // gpID
            // 
            this.gpID.BackColor = System.Drawing.Color.Gray;
            this.gpID.Controls.Add(this.dtpID);
            this.gpID.Controls.Add(this.label17);
            this.gpID.Controls.Add(this.kitapturu);
            this.gpID.Controls.Add(this.KitapAdi);
            this.gpID.Controls.Add(this.yazar);
            this.gpID.Controls.Add(this.txtKitapID);
            this.gpID.Controls.Add(this.label9);
            this.gpID.Controls.Add(this.sayfasayisi);
            this.gpID.Controls.Add(this.stokadedi);
            this.gpID.Controls.Add(this.label10);
            this.gpID.Controls.Add(this.Yayinevi);
            this.gpID.Controls.Add(this.label11);
            this.gpID.Controls.Add(this.label12);
            this.gpID.Controls.Add(this.label13);
            this.gpID.Controls.Add(this.basimyili);
            this.gpID.Controls.Add(this.label14);
            this.gpID.Controls.Add(this.label15);
            this.gpID.Controls.Add(this.label16);
            this.gpID.ForeColor = System.Drawing.Color.White;
            this.gpID.Location = new System.Drawing.Point(12, 565);
            this.gpID.Name = "gpID";
            this.gpID.Size = new System.Drawing.Size(736, 225);
            this.gpID.TabIndex = 53;
            this.gpID.TabStop = false;
            this.gpID.Text = "Kitap Bilgileri ID";
            this.gpID.Visible = false;
            // 
            // dtpID
            // 
            this.dtpID.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpID.Location = new System.Drawing.Point(596, 105);
            this.dtpID.Name = "dtpID";
            this.dtpID.Size = new System.Drawing.Size(134, 29);
            this.dtpID.TabIndex = 55;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(618, 81);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(90, 21);
            this.label17.TabIndex = 54;
            this.label17.Text = "İade Tarihi";
            // 
            // kitapturu
            // 
            this.kitapturu.Enabled = false;
            this.kitapturu.Location = new System.Drawing.Point(410, 165);
            this.kitapturu.Name = "kitapturu";
            this.kitapturu.Size = new System.Drawing.Size(166, 29);
            this.kitapturu.TabIndex = 53;
            // 
            // KitapAdi
            // 
            this.KitapAdi.Enabled = false;
            this.KitapAdi.Location = new System.Drawing.Point(123, 75);
            this.KitapAdi.Name = "KitapAdi";
            this.KitapAdi.Size = new System.Drawing.Size(166, 29);
            this.KitapAdi.TabIndex = 52;
            // 
            // yazar
            // 
            this.yazar.Enabled = false;
            this.yazar.Location = new System.Drawing.Point(410, 32);
            this.yazar.Name = "yazar";
            this.yazar.Size = new System.Drawing.Size(166, 29);
            this.yazar.TabIndex = 51;
            // 
            // txtKitapID
            // 
            this.txtKitapID.Location = new System.Drawing.Point(123, 32);
            this.txtKitapID.Name = "txtKitapID";
            this.txtKitapID.Size = new System.Drawing.Size(166, 29);
            this.txtKitapID.TabIndex = 40;
            this.txtKitapID.TextChanged += new System.EventHandler(this.txtKitapID_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(12, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 21);
            this.label9.TabIndex = 36;
            this.label9.Text = "Kitap Kodu :";
            // 
            // sayfasayisi
            // 
            this.sayfasayisi.Enabled = false;
            this.sayfasayisi.Location = new System.Drawing.Point(410, 120);
            this.sayfasayisi.Name = "sayfasayisi";
            this.sayfasayisi.Size = new System.Drawing.Size(166, 29);
            this.sayfasayisi.TabIndex = 50;
            // 
            // stokadedi
            // 
            this.stokadedi.Enabled = false;
            this.stokadedi.Location = new System.Drawing.Point(123, 162);
            this.stokadedi.Name = "stokadedi";
            this.stokadedi.Size = new System.Drawing.Size(166, 29);
            this.stokadedi.TabIndex = 48;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(12, 165);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 21);
            this.label10.TabIndex = 46;
            this.label10.Text = "Stok Adedi :";
            // 
            // Yayinevi
            // 
            this.Yayinevi.Enabled = false;
            this.Yayinevi.Location = new System.Drawing.Point(123, 120);
            this.Yayinevi.Name = "Yayinevi";
            this.Yayinevi.Size = new System.Drawing.Size(166, 29);
            this.Yayinevi.TabIndex = 47;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(294, 123);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 21);
            this.label11.TabIndex = 45;
            this.label11.Text = "Sayfa Sayısı :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(34, 123);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 21);
            this.label12.TabIndex = 44;
            this.label12.Text = "Yayınevi :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(309, 168);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 21);
            this.label13.TabIndex = 43;
            this.label13.Text = "Kitap Türü :";
            // 
            // basimyili
            // 
            this.basimyili.Enabled = false;
            this.basimyili.Location = new System.Drawing.Point(410, 75);
            this.basimyili.Name = "basimyili";
            this.basimyili.Size = new System.Drawing.Size(166, 29);
            this.basimyili.TabIndex = 42;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(309, 78);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(93, 21);
            this.label14.TabIndex = 39;
            this.label14.Text = "Basım Yılı :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(299, 36);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(108, 21);
            this.label15.TabIndex = 38;
            this.label15.Text = "Kitap Yazarı :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(30, 78);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(88, 21);
            this.label16.TabIndex = 37;
            this.label16.Text = "Kitap Adı :";
            // 
            // btnID
            // 
            this.btnID.BackColor = System.Drawing.Color.DimGray;
            this.btnID.ForeColor = System.Drawing.Color.Black;
            this.btnID.Location = new System.Drawing.Point(46, 117);
            this.btnID.Name = "btnID";
            this.btnID.Size = new System.Drawing.Size(291, 75);
            this.btnID.TabIndex = 8;
            this.btnID.Text = "ID\'ye Göre Ara";
            this.btnID.UseVisualStyleBackColor = false;
            this.btnID.Click += new System.EventHandler(this.btnID_Click);
            // 
            // btnTur
            // 
            this.btnTur.BackColor = System.Drawing.Color.DimGray;
            this.btnTur.ForeColor = System.Drawing.Color.Black;
            this.btnTur.Location = new System.Drawing.Point(46, 36);
            this.btnTur.Name = "btnTur";
            this.btnTur.Size = new System.Drawing.Size(291, 75);
            this.btnTur.TabIndex = 9;
            this.btnTur.Text = "Türe Göre Ara";
            this.btnTur.UseVisualStyleBackColor = false;
            this.btnTur.Click += new System.EventHandler(this.btnTur_Click);
            // 
            // btnOduncVer
            // 
            this.btnOduncVer.BackColor = System.Drawing.Color.DimGray;
            this.btnOduncVer.ForeColor = System.Drawing.Color.Black;
            this.btnOduncVer.Location = new System.Drawing.Point(754, 90);
            this.btnOduncVer.Name = "btnOduncVer";
            this.btnOduncVer.Size = new System.Drawing.Size(153, 75);
            this.btnOduncVer.TabIndex = 54;
            this.btnOduncVer.Text = "Ödünç Ver";
            this.btnOduncVer.UseVisualStyleBackColor = false;
            this.btnOduncVer.Click += new System.EventHandler(this.btnOduncVer_Click);
            // 
            // gpAlici
            // 
            this.gpAlici.Controls.Add(this.txtTCKİMLİK);
            this.gpAlici.Controls.Add(this.txtADSOYAD);
            this.gpAlici.Controls.Add(this.label19);
            this.gpAlici.Controls.Add(this.txtNUMARA);
            this.gpAlici.Controls.Add(this.label20);
            this.gpAlici.Controls.Add(this.label21);
            this.gpAlici.ForeColor = System.Drawing.Color.White;
            this.gpAlici.Location = new System.Drawing.Point(913, 11);
            this.gpAlici.Name = "gpAlici";
            this.gpAlici.Size = new System.Drawing.Size(308, 226);
            this.gpAlici.TabIndex = 55;
            this.gpAlici.TabStop = false;
            this.gpAlici.Text = "Kitap Alıcısı";
            // 
            // txtTCKİMLİK
            // 
            this.txtTCKİMLİK.Location = new System.Drawing.Point(125, 104);
            this.txtTCKİMLİK.MaxLength = 11;
            this.txtTCKİMLİK.Name = "txtTCKİMLİK";
            this.txtTCKİMLİK.Size = new System.Drawing.Size(166, 29);
            this.txtTCKİMLİK.TabIndex = 58;
            // 
            // txtADSOYAD
            // 
            this.txtADSOYAD.Location = new System.Drawing.Point(125, 61);
            this.txtADSOYAD.Name = "txtADSOYAD";
            this.txtADSOYAD.Size = new System.Drawing.Size(166, 29);
            this.txtADSOYAD.TabIndex = 55;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(14, 64);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(90, 21);
            this.label19.TabIndex = 53;
            this.label19.Text = "Ad Soyad :";
            // 
            // txtNUMARA
            // 
            this.txtNUMARA.Location = new System.Drawing.Point(125, 147);
            this.txtNUMARA.MaxLength = 11;
            this.txtNUMARA.Name = "txtNUMARA";
            this.txtNUMARA.Size = new System.Drawing.Size(166, 29);
            this.txtNUMARA.TabIndex = 57;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(24, 149);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(80, 21);
            this.label20.TabIndex = 56;
            this.label20.Text = "Numara :";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(15, 107);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(89, 21);
            this.label21.TabIndex = 54;
            this.label21.Text = "TC Kimlik :";
            // 
            // FormOduncKitap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1234, 625);
            this.Controls.Add(this.gpAlici);
            this.Controls.Add(this.btnOduncVer);
            this.Controls.Add(this.gpID);
            this.Controls.Add(this.btnID);
            this.Controls.Add(this.gpTUR);
            this.Controls.Add(this.btnTur);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormOduncKitap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ödünç Kitap İşlemleri";
            this.Load += new System.EventHandler(this.FormOduncKitap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gpTUR.ResumeLayout(false);
            this.gpTUR.PerformLayout();
            this.gpID.ResumeLayout(false);
            this.gpID.PerformLayout();
            this.gpAlici.ResumeLayout(false);
            this.gpAlici.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox gpTUR;
        private System.Windows.Forms.TextBox txtKitapYazari;
        private System.Windows.Forms.TextBox txtSayfaSayisi;
        private System.Windows.Forms.ComboBox cmbKitapTuru;
        private System.Windows.Forms.TextBox txtStokAdedi;
        private System.Windows.Forms.TextBox txtYayinEvi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBasimYili;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKitapKodu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbKitapAdi;
        private System.Windows.Forms.GroupBox gpID;
        private System.Windows.Forms.TextBox kitapturu;
        private System.Windows.Forms.TextBox KitapAdi;
        private System.Windows.Forms.TextBox yazar;
        private System.Windows.Forms.TextBox txtKitapID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox sayfasayisi;
        private System.Windows.Forms.TextBox stokadedi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Yayinevi;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox basimyili;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnTur;
        private System.Windows.Forms.Button btnID;
        private System.Windows.Forms.DateTimePicker dpSecme;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DateTimePicker dtpID;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnOduncVer;
        private System.Windows.Forms.GroupBox gpAlici;
        private System.Windows.Forms.TextBox txtTCKİMLİK;
        private System.Windows.Forms.TextBox txtADSOYAD;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtNUMARA;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
    }
}