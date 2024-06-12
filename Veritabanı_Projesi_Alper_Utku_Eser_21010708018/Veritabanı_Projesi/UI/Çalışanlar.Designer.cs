namespace Veritabanı_Projesi.UI
{
    partial class Çalışanlar
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
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.btnİptal = new System.Windows.Forms.Button();
            this.btnTamam = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.btnÇalışanEkle = new System.Windows.Forms.ToolStripButton();
            this.btnÇalışanDüzenle = new System.Windows.Forms.ToolStripButton();
            this.btnÇalışanSil = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBox3 = new System.Windows.Forms.ToolStripTextBox();
            this.btnÇalışanBul = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tabControl3.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.toolStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl3
            // 
            this.tabControl3.Controls.Add(this.tabPage5);
            this.tabControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl3.Location = new System.Drawing.Point(0, 0);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(800, 488);
            this.tabControl3.TabIndex = 3;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.btnİptal);
            this.tabPage5.Controls.Add(this.btnTamam);
            this.tabPage5.Controls.Add(this.dataGridView3);
            this.tabPage5.Controls.Add(this.toolStrip3);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(792, 462);
            this.tabPage5.TabIndex = 0;
            this.tabPage5.Text = "Çalışanlar";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // btnİptal
            // 
            this.btnİptal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnİptal.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnİptal.Location = new System.Drawing.Point(711, 433);
            this.btnİptal.Name = "btnİptal";
            this.btnİptal.Size = new System.Drawing.Size(75, 23);
            this.btnİptal.TabIndex = 14;
            this.btnİptal.Text = "İptal";
            this.btnİptal.UseVisualStyleBackColor = true;
            this.btnİptal.Click += new System.EventHandler(this.btnİptal_Click);
            // 
            // btnTamam
            // 
            this.btnTamam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTamam.Location = new System.Drawing.Point(627, 433);
            this.btnTamam.Name = "btnTamam";
            this.btnTamam.Size = new System.Drawing.Size(75, 23);
            this.btnTamam.TabIndex = 13;
            this.btnTamam.Text = "Tamam";
            this.btnTamam.UseVisualStyleBackColor = true;
            this.btnTamam.Click += new System.EventHandler(this.btnTamam_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView3.Location = new System.Drawing.Point(3, 28);
            this.dataGridView3.MultiSelect = false;
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView3.Size = new System.Drawing.Size(786, 399);
            this.dataGridView3.TabIndex = 1;
            // 
            // toolStrip3
            // 
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnÇalışanEkle,
            this.toolStripSeparator1,
            this.btnÇalışanDüzenle,
            this.toolStripSeparator2,
            this.btnÇalışanSil,
            this.toolStripSeparator3,
            this.toolStripLabel3,
            this.toolStripTextBox3,
            this.btnÇalışanBul});
            this.toolStrip3.Location = new System.Drawing.Point(3, 3);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(786, 25);
            this.toolStrip3.TabIndex = 0;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // btnÇalışanEkle
            // 
            this.btnÇalışanEkle.Image = global::Veritabanı_Projesi.Properties.Resources.pngegg;
            this.btnÇalışanEkle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnÇalışanEkle.Name = "btnÇalışanEkle";
            this.btnÇalışanEkle.Size = new System.Drawing.Size(89, 22);
            this.btnÇalışanEkle.Text = "Çalışan Ekle";
            this.btnÇalışanEkle.Click += new System.EventHandler(this.btnÇalışanEkle_Click);
            // 
            // btnÇalışanDüzenle
            // 
            this.btnÇalışanDüzenle.Image = global::Veritabanı_Projesi.Properties.Resources.Düzenle_png;
            this.btnÇalışanDüzenle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnÇalışanDüzenle.Name = "btnÇalışanDüzenle";
            this.btnÇalışanDüzenle.Size = new System.Drawing.Size(69, 22);
            this.btnÇalışanDüzenle.Text = "Düzenle";
            this.btnÇalışanDüzenle.Click += new System.EventHandler(this.btnÇalışanDüzenle_Click);
            // 
            // btnÇalışanSil
            // 
            this.btnÇalışanSil.Image = global::Veritabanı_Projesi.Properties.Resources.Sil_png;
            this.btnÇalışanSil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnÇalışanSil.Name = "btnÇalışanSil";
            this.btnÇalışanSil.Size = new System.Drawing.Size(80, 22);
            this.btnÇalışanSil.Text = "Çalışan Sil";
            this.btnÇalışanSil.Click += new System.EventHandler(this.btnÇalışanSil_Click);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(25, 22);
            this.toolStripLabel3.Text = "Ara";
            // 
            // toolStripTextBox3
            // 
            this.toolStripTextBox3.AutoSize = false;
            this.toolStripTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStripTextBox3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox3.Name = "toolStripTextBox3";
            this.toolStripTextBox3.Size = new System.Drawing.Size(80, 23);
            // 
            // btnÇalışanBul
            // 
            this.btnÇalışanBul.Image = global::Veritabanı_Projesi.Properties.Resources.Bul_png;
            this.btnÇalışanBul.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnÇalışanBul.Name = "btnÇalışanBul";
            this.btnÇalışanBul.Size = new System.Drawing.Size(44, 22);
            this.btnÇalışanBul.Text = "Bul";
            this.btnÇalışanBul.Click += new System.EventHandler(this.btnÇalışanBul_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // Çalışanlar
            // 
            this.AcceptButton = this.btnTamam;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnİptal;
            this.ClientSize = new System.Drawing.Size(800, 488);
            this.Controls.Add(this.tabControl3);
            this.Name = "Çalışanlar";
            this.Text = "Çalışanlar";
            this.Load += new System.EventHandler(this.Çalışanlar_Load);
            this.tabControl3.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl3;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripButton btnÇalışanEkle;
        private System.Windows.Forms.ToolStripButton btnÇalışanDüzenle;
        private System.Windows.Forms.ToolStripButton btnÇalışanSil;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox3;
        private System.Windows.Forms.ToolStripButton btnÇalışanBul;
        private System.Windows.Forms.Button btnİptal;
        private System.Windows.Forms.Button btnTamam;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    }
}