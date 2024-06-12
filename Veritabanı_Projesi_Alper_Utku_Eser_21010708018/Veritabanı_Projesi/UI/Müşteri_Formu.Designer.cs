namespace Veritabanı_Projesi.UI
{
    partial class Müşteri_Formu
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMüşteriID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMüşteriAdı = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMüşteriSoyadı = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMüşteriTelefon = new System.Windows.Forms.MaskedTextBox();
            this.btnTamam = new System.Windows.Forms.Button();
            this.btnİptal = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Müşteri ID";
            this.label1.Click += new System.EventHandler(this.btnİptal_Click);
            // 
            // txtMüşteriID
            // 
            this.txtMüşteriID.Location = new System.Drawing.Point(196, 147);
            this.txtMüşteriID.MaxLength = 64;
            this.txtMüşteriID.Name = "txtMüşteriID";
            this.txtMüşteriID.ReadOnly = true;
            this.txtMüşteriID.Size = new System.Drawing.Size(232, 20);
            this.txtMüşteriID.TabIndex = 0;
            this.txtMüşteriID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Adı";
            this.label2.Click += new System.EventHandler(this.btnİptal_Click);
            // 
            // txtMüşteriAdı
            // 
            this.txtMüşteriAdı.Location = new System.Drawing.Point(196, 173);
            this.txtMüşteriAdı.Name = "txtMüşteriAdı";
            this.txtMüşteriAdı.Size = new System.Drawing.Size(232, 20);
            this.txtMüşteriAdı.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(142, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Soyadı";
            this.label3.Click += new System.EventHandler(this.btnİptal_Click);
            // 
            // txtMüşteriSoyadı
            // 
            this.txtMüşteriSoyadı.Location = new System.Drawing.Point(196, 199);
            this.txtMüşteriSoyadı.Name = "txtMüşteriSoyadı";
            this.txtMüşteriSoyadı.Size = new System.Drawing.Size(232, 20);
            this.txtMüşteriSoyadı.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(119, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Telefon No";
            this.label4.Click += new System.EventHandler(this.btnİptal_Click);
            // 
            // txtMüşteriTelefon
            // 
            this.txtMüşteriTelefon.Location = new System.Drawing.Point(196, 225);
            this.txtMüşteriTelefon.Mask = "\\0(599) 000-0000";
            this.txtMüşteriTelefon.Name = "txtMüşteriTelefon";
            this.txtMüşteriTelefon.Size = new System.Drawing.Size(232, 20);
            this.txtMüşteriTelefon.TabIndex = 3;
            this.txtMüşteriTelefon.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtTelefon_MaskInputRejected);
            // 
            // btnTamam
            // 
            this.btnTamam.Location = new System.Drawing.Point(269, 309);
            this.btnTamam.Name = "btnTamam";
            this.btnTamam.Size = new System.Drawing.Size(75, 23);
            this.btnTamam.TabIndex = 4;
            this.btnTamam.Text = "Tamam";
            this.btnTamam.UseVisualStyleBackColor = true;
            this.btnTamam.Click += new System.EventHandler(this.btnTamam_Click);
            // 
            // btnİptal
            // 
            this.btnİptal.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnİptal.Location = new System.Drawing.Point(353, 309);
            this.btnİptal.Name = "btnİptal";
            this.btnİptal.Size = new System.Drawing.Size(75, 23);
            this.btnİptal.TabIndex = 5;
            this.btnİptal.Text = "İptal";
            this.btnİptal.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(266, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Müşteri";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Müşteri_Formu
            // 
            this.AcceptButton = this.btnTamam;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnİptal;
            this.ClientSize = new System.Drawing.Size(563, 452);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnİptal);
            this.Controls.Add(this.btnTamam);
            this.Controls.Add(this.txtMüşteriTelefon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMüşteriSoyadı);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMüşteriAdı);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMüşteriID);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Müşteri_Formu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Müşteri";
            this.Load += new System.EventHandler(this.Müşteri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMüşteriID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMüşteriAdı;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMüşteriSoyadı;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtMüşteriTelefon;
        private System.Windows.Forms.Button btnTamam;
        private System.Windows.Forms.Button btnİptal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}