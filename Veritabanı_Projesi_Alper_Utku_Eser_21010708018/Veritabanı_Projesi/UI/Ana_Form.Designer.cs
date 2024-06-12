namespace Veritabanı_Projesi.UI
{
    partial class Ana_Form
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripTextBox4 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btnSiparişDüzenle = new System.Windows.Forms.ToolStripButton();
            this.btnSiparişSil = new System.Windows.Forms.ToolStripButton();
            this.btnSiparişBul = new System.Windows.Forms.ToolStripButton();
            this.btnMüşteriler = new System.Windows.Forms.ToolStripButton();
            this.btnÜrünler = new System.Windows.Forms.ToolStripButton();
            this.btnÇalışanlar = new System.Windows.Forms.ToolStripButton();
            this.btnSiparişler = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 539);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(934, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMüşteriler,
            this.toolStripSeparator1,
            this.btnÜrünler,
            this.toolStripSeparator2,
            this.btnÇalışanlar,
            this.toolStripSeparator3,
            this.btnSiparişler,
            this.toolStripSeparator4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(934, 39);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 39);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 39);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(934, 500);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView4);
            this.tabPage1.Controls.Add(this.toolStrip2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(926, 474);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "SİPARİŞLER";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.AllowUserToDeleteRows = false;
            this.dataGridView4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView4.Location = new System.Drawing.Point(3, 28);
            this.dataGridView4.MultiSelect = false;
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView4.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView4.Size = new System.Drawing.Size(920, 443);
            this.dataGridView4.TabIndex = 1;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSiparişDüzenle,
            this.btnSiparişSil,
            this.btnSiparişBul,
            this.toolStripTextBox4,
            this.toolStripLabel1});
            this.toolStrip2.Location = new System.Drawing.Point(3, 3);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(920, 25);
            this.toolStrip2.TabIndex = 0;
            this.toolStrip2.Text = "Düzenle";
            // 
            // toolStripTextBox4
            // 
            this.toolStripTextBox4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripTextBox4.AutoSize = false;
            this.toolStripTextBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStripTextBox4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox4.Name = "toolStripTextBox4";
            this.toolStripTextBox4.Size = new System.Drawing.Size(80, 23);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripLabel1.Size = new System.Drawing.Size(25, 22);
            this.toolStripLabel1.Text = "Ara";
            // 
            // btnSiparişDüzenle
            // 
            this.btnSiparişDüzenle.Image = global::Veritabanı_Projesi.Properties.Resources.Düzenle_png;
            this.btnSiparişDüzenle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSiparişDüzenle.Name = "btnSiparişDüzenle";
            this.btnSiparişDüzenle.Size = new System.Drawing.Size(69, 22);
            this.btnSiparişDüzenle.Text = "Düzenle";
            this.btnSiparişDüzenle.Click += new System.EventHandler(this.btnSiparişDüzenle_Click);
            // 
            // btnSiparişSil
            // 
            this.btnSiparişSil.Image = global::Veritabanı_Projesi.Properties.Resources.Sil_png;
            this.btnSiparişSil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSiparişSil.Name = "btnSiparişSil";
            this.btnSiparişSil.Size = new System.Drawing.Size(39, 22);
            this.btnSiparişSil.Text = "Sil";
            this.btnSiparişSil.Click += new System.EventHandler(this.btnSiparişSil_Click);
            // 
            // btnSiparişBul
            // 
            this.btnSiparişBul.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnSiparişBul.Image = global::Veritabanı_Projesi.Properties.Resources.Bul_png;
            this.btnSiparişBul.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSiparişBul.Name = "btnSiparişBul";
            this.btnSiparişBul.Size = new System.Drawing.Size(44, 22);
            this.btnSiparişBul.Text = "Bul";
            this.btnSiparişBul.Click += new System.EventHandler(this.btnSiparişBul_Click);
            // 
            // btnMüşteriler
            // 
            this.btnMüşteriler.Image = global::Veritabanı_Projesi.Properties.Resources.Müşteri_png;
            this.btnMüşteriler.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMüşteriler.Name = "btnMüşteriler";
            this.btnMüşteriler.Size = new System.Drawing.Size(109, 36);
            this.btnMüşteriler.Text = "MÜŞTERİLER";
            this.btnMüşteriler.Click += new System.EventHandler(this.btnMüşteriler_Click);
            // 
            // btnÜrünler
            // 
            this.btnÜrünler.Image = global::Veritabanı_Projesi.Properties.Resources.Ürünler_png;
            this.btnÜrünler.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnÜrünler.Name = "btnÜrünler";
            this.btnÜrünler.Size = new System.Drawing.Size(94, 36);
            this.btnÜrünler.Text = "ÜRÜNLER";
            this.btnÜrünler.Click += new System.EventHandler(this.btnÜrünler_Click);
            // 
            // btnÇalışanlar
            // 
            this.btnÇalışanlar.Image = global::Veritabanı_Projesi.Properties.Resources.pngegg;
            this.btnÇalışanlar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnÇalışanlar.Name = "btnÇalışanlar";
            this.btnÇalışanlar.Size = new System.Drawing.Size(112, 36);
            this.btnÇalışanlar.Text = "ÇALIŞANLAR";
            this.btnÇalışanlar.Click += new System.EventHandler(this.btnÇalışanlar_Click);
            // 
            // btnSiparişler
            // 
            this.btnSiparişler.Image = global::Veritabanı_Projesi.Properties.Resources.Siparişler_png;
            this.btnSiparişler.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSiparişler.Name = "btnSiparişler";
            this.btnSiparişler.Size = new System.Drawing.Size(101, 36);
            this.btnSiparişler.Text = "SİPARİŞLER";
            this.btnSiparişler.Click += new System.EventHandler(this.btnSiparişler_Click);
            // 
            // Ana_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Ana_Form";
            this.Text = "Market Yönetim Sistemi";
            this.Load += new System.EventHandler(this.Ana_Form_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnMüşteriler;
        private System.Windows.Forms.ToolStripButton btnÜrünler;
        private System.Windows.Forms.ToolStripButton btnÇalışanlar;
        private System.Windows.Forms.ToolStripButton btnSiparişler;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btnSiparişDüzenle;
        private System.Windows.Forms.ToolStripButton btnSiparişSil;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox4;
        private System.Windows.Forms.ToolStripButton btnSiparişBul;
    }
}