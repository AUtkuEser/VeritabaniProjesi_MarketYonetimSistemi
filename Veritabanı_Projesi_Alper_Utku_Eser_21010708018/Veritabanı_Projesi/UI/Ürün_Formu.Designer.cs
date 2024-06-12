namespace Veritabanı_Projesi.UI
{
    partial class Ürün_Formu
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
            this.components = new System.ComponentModel.Container();
            this.label5 = new System.Windows.Forms.Label();
            this.btnİptal = new System.Windows.Forms.Button();
            this.btnTamam = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtÜrünAdı = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtÜrünID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboKategori = new System.Windows.Forms.ComboBox();
            this.numericBirimFiyat = new System.Windows.Forms.NumericUpDown();
            this.numericStokMiktarı = new System.Windows.Forms.NumericUpDown();
            this.numericBarkodNumarası = new System.Windows.Forms.NumericUpDown();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericBirimFiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericStokMiktarı)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericBarkodNumarası)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(267, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Ürün";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnİptal
            // 
            this.btnİptal.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnİptal.Location = new System.Drawing.Point(377, 300);
            this.btnİptal.Name = "btnİptal";
            this.btnİptal.Size = new System.Drawing.Size(75, 23);
            this.btnİptal.TabIndex = 7;
            this.btnİptal.Text = "İptal";
            this.btnİptal.UseVisualStyleBackColor = true;
            this.btnİptal.Click += new System.EventHandler(this.btnİptal_Click);
            // 
            // btnTamam
            // 
            this.btnTamam.Location = new System.Drawing.Point(293, 300);
            this.btnTamam.Name = "btnTamam";
            this.btnTamam.Size = new System.Drawing.Size(75, 23);
            this.btnTamam.TabIndex = 6;
            this.btnTamam.Text = "Tamam";
            this.btnTamam.UseVisualStyleBackColor = true;
            this.btnTamam.Click += new System.EventHandler(this.btnTamam_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(137, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Birim Fiyat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(145, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Kategori";
            // 
            // txtÜrünAdı
            // 
            this.txtÜrünAdı.Location = new System.Drawing.Point(197, 151);
            this.txtÜrünAdı.Name = "txtÜrünAdı";
            this.txtÜrünAdı.Size = new System.Drawing.Size(255, 20);
            this.txtÜrünAdı.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ürün Adı";
            // 
            // txtÜrünID
            // 
            this.txtÜrünID.Location = new System.Drawing.Point(197, 125);
            this.txtÜrünID.Name = "txtÜrünID";
            this.txtÜrünID.ReadOnly = true;
            this.txtÜrünID.Size = new System.Drawing.Size(255, 20);
            this.txtÜrünID.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ürün ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(128, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Stok Miktarı";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(103, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Barkod Numarası";
            // 
            // comboKategori
            // 
            this.comboKategori.FormattingEnabled = true;
            this.comboKategori.Items.AddRange(new object[] {
            "Yiyecek",
            "İçecek",
            "Temizlik",
            "Kişisel Bakım",
            "Teknolojik"});
            this.comboKategori.Location = new System.Drawing.Point(197, 176);
            this.comboKategori.Name = "comboKategori";
            this.comboKategori.Size = new System.Drawing.Size(255, 21);
            this.comboKategori.TabIndex = 2;
            this.comboKategori.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // numericBirimFiyat
            // 
            this.numericBirimFiyat.Location = new System.Drawing.Point(197, 203);
            this.numericBirimFiyat.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericBirimFiyat.Name = "numericBirimFiyat";
            this.numericBirimFiyat.Size = new System.Drawing.Size(255, 20);
            this.numericBirimFiyat.TabIndex = 3;
            // 
            // numericStokMiktarı
            // 
            this.numericStokMiktarı.Location = new System.Drawing.Point(197, 229);
            this.numericStokMiktarı.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericStokMiktarı.Name = "numericStokMiktarı";
            this.numericStokMiktarı.Size = new System.Drawing.Size(255, 20);
            this.numericStokMiktarı.TabIndex = 4;
            // 
            // numericBarkodNumarası
            // 
            this.numericBarkodNumarası.Location = new System.Drawing.Point(197, 255);
            this.numericBarkodNumarası.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericBarkodNumarası.Name = "numericBarkodNumarası";
            this.numericBarkodNumarası.Size = new System.Drawing.Size(255, 20);
            this.numericBarkodNumarası.TabIndex = 5;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Ürün_Formu
            // 
            this.AcceptButton = this.btnTamam;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnİptal;
            this.ClientSize = new System.Drawing.Size(560, 450);
            this.Controls.Add(this.numericBarkodNumarası);
            this.Controls.Add(this.numericStokMiktarı);
            this.Controls.Add(this.numericBirimFiyat);
            this.Controls.Add(this.comboKategori);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnİptal);
            this.Controls.Add(this.btnTamam);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtÜrünAdı);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtÜrünID);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Ürün_Formu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ürün_Formu";
            ((System.ComponentModel.ISupportInitialize)(this.numericBirimFiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericStokMiktarı)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericBarkodNumarası)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnİptal;
        private System.Windows.Forms.Button btnTamam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtÜrünAdı;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtÜrünID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboKategori;
        private System.Windows.Forms.NumericUpDown numericBirimFiyat;
        private System.Windows.Forms.NumericUpDown numericStokMiktarı;
        private System.Windows.Forms.NumericUpDown numericBarkodNumarası;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}