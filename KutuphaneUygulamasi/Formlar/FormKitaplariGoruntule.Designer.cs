namespace KutuphaneUygulamasi.Formlar
{
    partial class FormKitaplariGoruntule
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
            this.label2 = new System.Windows.Forms.Label();
            this.cmbUrunTur = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "Kitap Türü :";
            // 
            // cmbUrunTur
            // 
            this.cmbUrunTur.FormattingEnabled = true;
            this.cmbUrunTur.Items.AddRange(new object[] {
            "Hepsi"});
            this.cmbUrunTur.Location = new System.Drawing.Point(112, 6);
            this.cmbUrunTur.Name = "cmbUrunTur";
            this.cmbUrunTur.Size = new System.Drawing.Size(121, 29);
            this.cmbUrunTur.TabIndex = 8;
            this.cmbUrunTur.SelectedIndexChanged += new System.EventHandler(this.cmbUrunTur_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(253, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Kitap Adı :";
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(347, 6);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(161, 29);
            this.txtAra.TabIndex = 6;
            this.txtAra.TextChanged += new System.EventHandler(this.txtAra_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1027, 529);
            this.dataGridView1.TabIndex = 5;
            // 
            // FormKitaplariGoruntule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1027, 566);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbUrunTur);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormKitaplariGoruntule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitapları Görüntüleme Formu";
            this.Load += new System.EventHandler(this.FormKitaplariGoruntule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbUrunTur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}