namespace KutuphaneUygulamasi.Formlar
{
    partial class FormOduncKitaplariGoruntule
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
            this.btnİade = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTCKİMLİK = new System.Windows.Forms.TextBox();
            this.txtADSOYAD = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtNUMARA = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 172);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1050, 379);
            this.dataGridView1.TabIndex = 7;
            // 
            // btnİade
            // 
            this.btnİade.BackColor = System.Drawing.Color.DimGray;
            this.btnİade.ForeColor = System.Drawing.Color.White;
            this.btnİade.Location = new System.Drawing.Point(143, 43);
            this.btnİade.Name = "btnİade";
            this.btnİade.Size = new System.Drawing.Size(308, 83);
            this.btnİade.TabIndex = 8;
            this.btnİade.Text = "Seçilen Kitabı İade Et";
            this.btnİade.UseVisualStyleBackColor = false;
            this.btnİade.Click += new System.EventHandler(this.btnİade_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTCKİMLİK);
            this.groupBox1.Controls.Add(this.txtADSOYAD);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.txtNUMARA);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(719, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(319, 154);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Arama İşlemleri";
            // 
            // txtTCKİMLİK
            // 
            this.txtTCKİMLİK.Location = new System.Drawing.Point(130, 28);
            this.txtTCKİMLİK.MaxLength = 11;
            this.txtTCKİMLİK.Name = "txtTCKİMLİK";
            this.txtTCKİMLİK.Size = new System.Drawing.Size(166, 29);
            this.txtTCKİMLİK.TabIndex = 64;
            this.txtTCKİMLİK.TextChanged += new System.EventHandler(this.txtTCKİMLİK_TextChanged);
            // 
            // txtADSOYAD
            // 
            this.txtADSOYAD.Enabled = false;
            this.txtADSOYAD.Location = new System.Drawing.Point(130, 71);
            this.txtADSOYAD.Name = "txtADSOYAD";
            this.txtADSOYAD.Size = new System.Drawing.Size(166, 29);
            this.txtADSOYAD.TabIndex = 61;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(19, 74);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(90, 21);
            this.label19.TabIndex = 59;
            this.label19.Text = "Ad Soyad :";
            // 
            // txtNUMARA
            // 
            this.txtNUMARA.Enabled = false;
            this.txtNUMARA.Location = new System.Drawing.Point(130, 115);
            this.txtNUMARA.MaxLength = 11;
            this.txtNUMARA.Name = "txtNUMARA";
            this.txtNUMARA.Size = new System.Drawing.Size(166, 29);
            this.txtNUMARA.TabIndex = 63;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(29, 117);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(80, 21);
            this.label20.TabIndex = 62;
            this.label20.Text = "Numara :";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(20, 31);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(89, 21);
            this.label21.TabIndex = 60;
            this.label21.Text = "TC Kimlik :";
            // 
            // FormOduncKitaplariGoruntule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1050, 551);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnİade);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "FormOduncKitaplariGoruntule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ödünç Kitap Görüntüle";
            this.Load += new System.EventHandler(this.FormOduncKitaplariGoruntule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnİade;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTCKİMLİK;
        private System.Windows.Forms.TextBox txtADSOYAD;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtNUMARA;
    }
}