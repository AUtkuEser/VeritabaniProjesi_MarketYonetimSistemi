namespace Veritabanı_Projesi.UI
{
    partial class Çalışan_Formu
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
            this.numericMaaşı = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnİptal = new System.Windows.Forms.Button();
            this.btnTamam = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtÇalışanAdı = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtÇalışanID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtÇalışanSoyadı = new System.Windows.Forms.TextBox();
            this.comboCinsiyeti = new System.Windows.Forms.ComboBox();
            this.txtÇalışanTelefon = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMaili = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericMaaşı)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // numericMaaşı
            // 
            this.numericMaaşı.Location = new System.Drawing.Point(195, 225);
            this.numericMaaşı.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericMaaşı.Name = "numericMaaşı";
            this.numericMaaşı.Size = new System.Drawing.Size(255, 20);
            this.numericMaaşı.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(143, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Maaşı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(265, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 30;
            this.label5.Text = "Çalışan";
            // 
            // btnİptal
            // 
            this.btnİptal.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnİptal.Location = new System.Drawing.Point(375, 331);
            this.btnİptal.Name = "btnİptal";
            this.btnİptal.Size = new System.Drawing.Size(75, 23);
            this.btnİptal.TabIndex = 8;
            this.btnİptal.Text = "İptal";
            this.btnİptal.UseVisualStyleBackColor = true;
            this.btnİptal.Click += new System.EventHandler(this.btnİptal_Click);
            // 
            // btnTamam
            // 
            this.btnTamam.Location = new System.Drawing.Point(291, 331);
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
            this.label4.Location = new System.Drawing.Point(133, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Cinsiyeti";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(139, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Soyadı";
            // 
            // txtÇalışanAdı
            // 
            this.txtÇalışanAdı.Location = new System.Drawing.Point(195, 147);
            this.txtÇalışanAdı.Name = "txtÇalışanAdı";
            this.txtÇalışanAdı.Size = new System.Drawing.Size(255, 20);
            this.txtÇalışanAdı.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Adı";
            // 
            // txtÇalışanID
            // 
            this.txtÇalışanID.Location = new System.Drawing.Point(195, 121);
            this.txtÇalışanID.Name = "txtÇalışanID";
            this.txtÇalışanID.ReadOnly = true;
            this.txtÇalışanID.Size = new System.Drawing.Size(255, 20);
            this.txtÇalışanID.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Çalışan ID";
            // 
            // txtÇalışanSoyadı
            // 
            this.txtÇalışanSoyadı.Location = new System.Drawing.Point(195, 173);
            this.txtÇalışanSoyadı.Name = "txtÇalışanSoyadı";
            this.txtÇalışanSoyadı.Size = new System.Drawing.Size(255, 20);
            this.txtÇalışanSoyadı.TabIndex = 2;
            // 
            // comboCinsiyeti
            // 
            this.comboCinsiyeti.FormattingEnabled = true;
            this.comboCinsiyeti.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.comboCinsiyeti.Location = new System.Drawing.Point(195, 198);
            this.comboCinsiyeti.Name = "comboCinsiyeti";
            this.comboCinsiyeti.Size = new System.Drawing.Size(255, 21);
            this.comboCinsiyeti.TabIndex = 3;
            // 
            // txtÇalışanTelefon
            // 
            this.txtÇalışanTelefon.Location = new System.Drawing.Point(195, 251);
            this.txtÇalışanTelefon.Mask = "\\0(599) 000-0000";
            this.txtÇalışanTelefon.Name = "txtÇalışanTelefon";
            this.txtÇalışanTelefon.Size = new System.Drawing.Size(255, 20);
            this.txtÇalışanTelefon.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(118, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "Telefon No";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(150, 280);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Maili";
            // 
            // txtMaili
            // 
            this.txtMaili.Location = new System.Drawing.Point(195, 277);
            this.txtMaili.Name = "txtMaili";
            this.txtMaili.Size = new System.Drawing.Size(255, 20);
            this.txtMaili.TabIndex = 6;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Çalışan_Formu
            // 
            this.AcceptButton = this.btnTamam;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnİptal;
            this.ClientSize = new System.Drawing.Size(560, 450);
            this.Controls.Add(this.txtÇalışanTelefon);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboCinsiyeti);
            this.Controls.Add(this.numericMaaşı);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnİptal);
            this.Controls.Add(this.btnTamam);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtÇalışanSoyadı);
            this.Controls.Add(this.txtMaili);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtÇalışanAdı);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtÇalışanID);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Çalışan_Formu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Çalışan_Formu";
            this.Load += new System.EventHandler(this.Çalışan_Formu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericMaaşı)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown numericMaaşı;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnİptal;
        private System.Windows.Forms.Button btnTamam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtÇalışanAdı;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtÇalışanID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtÇalışanSoyadı;
        private System.Windows.Forms.ComboBox comboCinsiyeti;
        private System.Windows.Forms.MaskedTextBox txtÇalışanTelefon;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMaili;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}