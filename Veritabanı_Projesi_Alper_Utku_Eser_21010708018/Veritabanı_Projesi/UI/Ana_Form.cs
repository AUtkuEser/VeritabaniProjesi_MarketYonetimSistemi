using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Veritabanı_Projesi.BL;
using Veritabanı_Projesi.UI;

namespace Veritabanı_Projesi.UI
{
    public partial class Ana_Form : Form
    {
        public Ana_Form()
        {
            InitializeComponent();
        }

        Müşteriler mf = new Müşteriler();

        Ürünler uf = new Ürünler();

        Çalışanlar çf = new Çalışanlar();
        
        public Siparis Siparişler { get; set; }

        private void btnMüşteriler_Click(object sender, EventArgs e)
        {
            mf.ShowDialog();
        }

        private void btnÜrünler_Click(object sender, EventArgs e)
        {
            uf.ShowDialog();
        }

        private void btnÇalışanlar_Click(object sender, EventArgs e)
        {
            çf.ShowDialog();
        }

        private void btnSiparişler_Click(object sender, EventArgs e)
        {
            Sipariş_Formu sipariş_formu = new Sipariş_Formu()
            {
                Text = "Sipariş Ver",
                Siparişler = new Siparis()
                {
                    Sipariş_ID = Guid.NewGuid(),
                }
            };

               
            tekrar:
                var sonuc = sipariş_formu.ShowDialog();
                if (sonuc == DialogResult.OK)
                {
                    bool b = BLogic.SiparişEkle(sipariş_formu.Siparişler);

                    if (b)
                    {
                        DataSet ds = BLogic.SiparişGetir("");
                        if (ds != null)
                            dataGridView4.DataSource = ds.Tables[0];

                    }
                    else
                        goto tekrar;

                
            }
            
        }

        private void Ana_Form_Load(object sender, EventArgs e)
        {
            DataSet ds = BLogic.SiparişGetir("");
            if (ds != null)
                dataGridView4.DataSource = ds.Tables[0];
        }

        private void btnSiparişDüzenle_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView4.SelectedRows[0];

            Sipariş_Formu sipariş_formu = new Sipariş_Formu()
            {
                Text = "Sipariş Güncelle",
                Güncelleme = true,
                Siparişler = new Siparis()
                {
                    Sipariş_ID = Guid.Parse(row.Cells[0].Value.ToString()),
                    Tarih = DateTime.Parse(row.Cells [1].Value.ToString()),
                    Tutar = float.Parse(row.Cells[2].Value.ToString()),
                    Ödeme_Türü = row.Cells[3].Value.ToString(),
                    Ürün_ID = Guid.Parse(row.Cells[4].Value.ToString()),
                    Müşteri_ID = Guid.Parse(row.Cells[5].Value.ToString()),
                    Çalışan_ID = Guid.Parse(row.Cells[6].Value.ToString()),
                },
 
            };

            var sonuc = sipariş_formu.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.SiparişGüncelle(sipariş_formu.Siparişler);

                if (b)
                {

                    row.Cells[1].Value = sipariş_formu.Siparişler.Tarih;
                    row.Cells[2].Value = sipariş_formu.Siparişler.Tutar;
                    row.Cells[3].Value = sipariş_formu.Siparişler.Ödeme_Türü;
                    row.Cells[4].Value = sipariş_formu.Siparişler.Ürün_ID;
                    row.Cells[5].Value = sipariş_formu.Siparişler.Müşteri_ID;
                    row.Cells[6].Value = sipariş_formu.Siparişler.Çalışan_ID;
                }



            }
        }

        private void btnSiparişSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView4.SelectedRows[0];
            var sid = row.Cells[0].Value.ToString();


            var sonuc = MessageBox.Show("Seçtiğiniz Siparişin silinmesini istiyor musunuz?", "Silmeyi onayla",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.SiparişSil(sid);

                if (b)
                {
                    DataSet ds = BLogic.SiparişGetir("");
                    if (ds != null)
                        dataGridView4.DataSource = ds.Tables[0];

                }

            }
        }

        private void btnSiparişBul_Click(object sender, EventArgs e)
        {
            DataSet ds = BLogic.SiparişGetir(toolStripTextBox4.Text);
            if (ds != null)
                dataGridView4.DataSource = ds.Tables[0];
        }
    }
}

