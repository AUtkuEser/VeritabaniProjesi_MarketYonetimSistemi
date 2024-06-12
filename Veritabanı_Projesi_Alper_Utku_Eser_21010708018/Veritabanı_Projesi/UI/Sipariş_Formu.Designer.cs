namespace Veritabanı_Projesi.UI
{
    partial class Sipariş_Formu
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
            this.numericTutar = new System.Windows.Forms.NumericUpDown();
            this.comboÖdemeTürü = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnİptal = new System.Windows.Forms.Button();
            this.btnTamam = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSiparişID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSiparişlerMüşteriID = new System.Windows.Forms.TextBox();
            this.txtSiparişlerÇalışanID = new System.Windows.Forms.TextBox();
            this.txtSiparişlerÜrünID = new System.Windows.Forms.TextBox();
            this.dtTarih = new System.Windows.Forms.DateTimePicker();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnÇalışanSeç = new System.Windows.Forms.Button();
            this.btnMüşteriSeç = new System.Windows.Forms.Button();
            this.btnÜrünSeç = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericTutar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // numericTutar
            // 
            this.numericTutar.Location = new System.Drawing.Point(150, 275);
            this.numericTutar.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericTutar.Name = "numericTutar";
            this.numericTutar.Size = new System.Drawing.Size(255, 20);
            this.numericTutar.TabIndex = 6;
            // 
            // comboÖdemeTürü
            // 
            this.comboÖdemeTürü.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboÖdemeTürü.FormattingEnabled = true;
            this.comboÖdemeTürü.Items.AddRange(new object[] {
            "Kredi Kartı",
            "Banka Kartı",
            "Nakit"});
            this.comboÖdemeTürü.Location = new System.Drawing.Point(150, 169);
            this.comboÖdemeTürü.Name = "comboÖdemeTürü";
            this.comboÖdemeTürü.Size = new System.Drawing.Size(255, 21);
            this.comboÖdemeTürü.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(98, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Müşteri";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(290, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 30;
            this.label5.Text = "Siparişler";
            // 
            // btnİptal
            // 
            this.btnİptal.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnİptal.Location = new System.Drawing.Point(330, 343);
            this.btnİptal.Name = "btnİptal";
            this.btnİptal.Size = new System.Drawing.Size(75, 23);
            this.btnİptal.TabIndex = 8;
            this.btnİptal.Text = "İptal";
            this.btnİptal.UseVisualStyleBackColor = true;
            this.btnİptal.Click += new System.EventHandler(this.btnİptal_Click);
            // 
            // btnTamam
            // 
            this.btnTamam.Location = new System.Drawing.Point(246, 343);
            this.btnTamam.Name = "btnTamam";
            this.btnTamam.Size = new System.Drawing.Size(75, 23);
            this.btnTamam.TabIndex = 7;
            this.btnTamam.Text = "Tamam";
            this.btnTamam.UseVisualStyleBackColor = true;
            this.btnTamam.Click += new System.EventHandler(this.btnTamam_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Ödeme Türü";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Tutar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Tarih";
            // 
            // txtSiparişID
            // 
            this.txtSiparişID.Location = new System.Drawing.Point(150, 118);
            this.txtSiparişID.Name = "txtSiparişID";
            this.txtSiparişID.ReadOnly = true;
            this.txtSiparişID.Size = new System.Drawing.Size(255, 20);
            this.txtSiparişID.TabIndex = 0;
            this.txtSiparişID.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Sipariş ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(109, 198);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Ürün";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(98, 251);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "Çalışan";
            // 
            // txtSiparişlerMüşteriID
            // 
            this.txtSiparişlerMüşteriID.Location = new System.Drawing.Point(150, 223);
            this.txtSiparişlerMüşteriID.Name = "txtSiparişlerMüşteriID";
            this.txtSiparişlerMüşteriID.ReadOnly = true;
            this.txtSiparişlerMüşteriID.Size = new System.Drawing.Size(255, 20);
            this.txtSiparişlerMüşteriID.TabIndex = 4;
            this.txtSiparişlerMüşteriID.TabStop = false;
            // 
            // txtSiparişlerÇalışanID
            // 
            this.txtSiparişlerÇalışanID.Location = new System.Drawing.Point(150, 248);
            this.txtSiparişlerÇalışanID.Name = "txtSiparişlerÇalışanID";
            this.txtSiparişlerÇalışanID.ReadOnly = true;
            this.txtSiparişlerÇalışanID.Size = new System.Drawing.Size(255, 20);
            this.txtSiparişlerÇalışanID.TabIndex = 3;
            this.txtSiparişlerÇalışanID.TabStop = false;
            // 
            // txtSiparişlerÜrünID
            // 
            this.txtSiparişlerÜrünID.Location = new System.Drawing.Point(150, 195);
            this.txtSiparişlerÜrünID.Name = "txtSiparişlerÜrünID";
            this.txtSiparişlerÜrünID.ReadOnly = true;
            this.txtSiparişlerÜrünID.Size = new System.Drawing.Size(255, 20);
            this.txtSiparişlerÜrünID.TabIndex = 5;
            this.txtSiparişlerÜrünID.TabStop = false;
            // 
            // dtTarih
            // 
            this.dtTarih.Location = new System.Drawing.Point(150, 143);
            this.dtTarih.Name = "dtTarih";
            this.dtTarih.Size = new System.Drawing.Size(255, 20);
            this.dtTarih.TabIndex = 1;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnÇalışanSeç
            // 
            this.btnÇalışanSeç.Location = new System.Drawing.Point(425, 248);
            this.btnÇalışanSeç.Name = "btnÇalışanSeç";
            this.btnÇalışanSeç.Size = new System.Drawing.Size(117, 20);
            this.btnÇalışanSeç.TabIndex = 33;
            this.btnÇalışanSeç.Text = "Çalışan Seç";
            this.btnÇalışanSeç.UseVisualStyleBackColor = true;
            this.btnÇalışanSeç.Click += new System.EventHandler(this.btnÇalışanSeç_Click);
            // 
            // btnMüşteriSeç
            // 
            this.btnMüşteriSeç.Location = new System.Drawing.Point(425, 223);
            this.btnMüşteriSeç.Name = "btnMüşteriSeç";
            this.btnMüşteriSeç.Size = new System.Drawing.Size(117, 20);
            this.btnMüşteriSeç.TabIndex = 33;
            this.btnMüşteriSeç.Text = "Müşteri Seç";
            this.btnMüşteriSeç.UseVisualStyleBackColor = true;
            this.btnMüşteriSeç.Click += new System.EventHandler(this.btnMüşteriSeç_Click);
            // 
            // btnÜrünSeç
            // 
            this.btnÜrünSeç.Location = new System.Drawing.Point(425, 195);
            this.btnÜrünSeç.Name = "btnÜrünSeç";
            this.btnÜrünSeç.Size = new System.Drawing.Size(117, 20);
            this.btnÜrünSeç.TabIndex = 33;
            this.btnÜrünSeç.Text = "Ürün Seç";
            this.btnÜrünSeç.UseVisualStyleBackColor = true;
            this.btnÜrünSeç.Click += new System.EventHandler(this.btnÜrünSeç_Click);
            // 
            // Sipariş_Formu
            // 
            this.AcceptButton = this.btnTamam;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnİptal;
            this.ClientSize = new System.Drawing.Size(644, 458);
            this.Controls.Add(this.btnÜrünSeç);
            this.Controls.Add(this.btnMüşteriSeç);
            this.Controls.Add(this.btnÇalışanSeç);
            this.Controls.Add(this.dtTarih);
            this.Controls.Add(this.numericTutar);
            this.Controls.Add(this.comboÖdemeTürü);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnİptal);
            this.Controls.Add(this.btnTamam);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSiparişlerMüşteriID);
            this.Controls.Add(this.txtSiparişlerÇalışanID);
            this.Controls.Add(this.txtSiparişlerÜrünID);
            this.Controls.Add(this.txtSiparişID);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Sipariş_Formu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sipariş_Formu";
            this.Load += new System.EventHandler(this.Sipariş_Formu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericTutar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown numericTutar;
        private System.Windows.Forms.ComboBox comboÖdemeTürü;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnİptal;
        private System.Windows.Forms.Button btnTamam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSiparişID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSiparişlerMüşteriID;
        private System.Windows.Forms.TextBox txtSiparişlerÇalışanID;
        private System.Windows.Forms.TextBox txtSiparişlerÜrünID;
        private System.Windows.Forms.DateTimePicker dtTarih;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnÜrünSeç;
        private System.Windows.Forms.Button btnMüşteriSeç;
        private System.Windows.Forms.Button btnÇalışanSeç;
    }
}