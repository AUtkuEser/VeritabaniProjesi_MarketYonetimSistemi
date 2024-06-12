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

namespace Veritabanı_Projesi.UI
{
    public partial class Ürünler : Form
    {
        public Ürünler()
        {
            InitializeComponent();
        }

        private void btnÜrünEkle_Click(object sender, EventArgs e)
        {
            Ürün_Formu ürün_formu = new Ürün_Formu()
            {
                Text = "Ürün Ekle",
                Ürün = new Urun() { Ürün_ID = Guid.NewGuid() }
            };

        tekrar:
            var sonuc = ürün_formu.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.ÜrünEkle(ürün_formu.Ürün);

                if (b)
                {
                    DataSet ds = BLogic.ÜrünGetir("");
                    if (ds != null)
                        dataGridView2.DataSource = ds.Tables[0];

                }
                else
                    goto tekrar;

            }



        }

        private void btnÜrünBul_Click(object sender, EventArgs e)
        {
            DataSet ds = BLogic.ÜrünGetir(toolStripTextBox2.Text);
            if (ds != null)
                dataGridView2.DataSource = ds.Tables[0];
        }

        private void btnÜrünDüzenle_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView2.SelectedRows[0];

            Ürün_Formu ürün_formu = new Ürün_Formu()
            {
                Text = "Ürün Güncelle",
                Güncelleme = true,
                Ürün = new Urun()
                {
                    Ürün_ID = Guid.Parse(row.Cells[0].Value.ToString()),
                    Ürün_Adı = row.Cells[1].Value.ToString(),
                    Kategori = row.Cells[2].Value.ToString(),
                    Birim_Fiyat = float.Parse(row.Cells[3].Value.ToString()),
                    Stok_Miktarı = float.Parse(row.Cells[4].Value.ToString()),
                    Barkod_Numarası = float.Parse(row.Cells[5].Value.ToString()),
                },

            };

            var sonuc = ürün_formu.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.ÜrünGüncelle(ürün_formu.Ürün);

                if (b)
                {

                    row.Cells[1].Value = ürün_formu.Ürün.Ürün_Adı;
                    row.Cells[2].Value = ürün_formu.Ürün.Kategori;
                    row.Cells[3].Value = ürün_formu.Ürün.Birim_Fiyat;
                    row.Cells[4].Value = ürün_formu.Ürün.Stok_Miktarı;
                    row.Cells[5].Value = ürün_formu.Ürün.Barkod_Numarası;
                }



            }
        }

        private void btnÜrünSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView2.SelectedRows[0];
            var uid = row.Cells[0].Value.ToString();



            var sonuc = MessageBox.Show("Seçtiğiniz Ürünün silinmesini istiyor musunuz?", "Silmeyi onayla",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.ÜrünSil(uid);

                if (b)
                {
                    DataSet ds = BLogic.ÜrünGetir("");
                    if (ds != null)
                        dataGridView2.DataSource = ds.Tables[0];

                }



            }
        }

        private void Ürünler_Load(object sender, EventArgs e)
        {
            DataSet ds2 = BLogic.ÜrünGetir("");
            if (ds2 != null)
                dataGridView2.DataSource = ds2.Tables[0];
        }


        public Urun Ürün { get; set; }

        private void btnTamam_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView2.SelectedRows[0];

            Ürün = new Urun()
            {
                Ürün_ID = Guid.Parse(row.Cells[0].Value.ToString()),
                Ürün_Adı = row.Cells[1].Value.ToString(),
                Kategori = row.Cells[2].Value.ToString(),
                Birim_Fiyat = float.Parse(row.Cells[3].Value.ToString()),
                Stok_Miktarı = float.Parse(row.Cells[4].Value.ToString()),
                Barkod_Numarası = float.Parse(row.Cells[5].Value.ToString()),
            };

            DialogResult = DialogResult.OK;
            
        }

        private void btnİptal_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
