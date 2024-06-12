using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veritabanı_Projesi.UI
{
    public partial class Ürün_Formu : Form
    {
        public Ürün_Formu()
        {
            InitializeComponent();
        }


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public Urun Ürün {  get; set; }

        public bool Güncelleme { get; set; } = false;

        private void btnTamam_Click(object sender, EventArgs e)
        {
            if (!ErrorControl(txtÜrünAdı)) return;
            if (!ErrorControl(comboKategori)) return;
            if (!ErrorControl(numericBirimFiyat)) return;
            if (!ErrorControl(numericStokMiktarı)) return;
            if (!ErrorControl(numericBarkodNumarası)) return;

            Ürün.Ürün_Adı = txtÜrünAdı.Text;
            Ürün.Kategori = comboKategori.Text;
            Ürün.Birim_Fiyat = (float)numericBirimFiyat.Value;
            Ürün.Stok_Miktarı = (float)numericStokMiktarı.Value;
            Ürün.Barkod_Numarası = (float)numericBarkodNumarası.Value;

            DialogResult = DialogResult.OK;
        }

        private void btnİptal_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private bool ErrorControl(Control c)
        {
            if (c is TextBox || c is ComboBox)
            {
                if (c.Text == "")
                {
                    errorProvider1.SetError(c, "Eksik veya hatalı bilgi girildi.");
                    c.Focus();
                    return false;
                }
                else
                {
                    errorProvider1.SetError(c, "");
                    return true;
                }
            }

            if (c is NumericUpDown)
            {
                if (((NumericUpDown)c).Value == 0)
                {
                    errorProvider1.SetError(c, "Eksik veya hatalı bilgi girildi.");
                    c.Focus();
                    return false;
                }
                else
                {
                    errorProvider1.SetError(c, "");
                    return true;
                }
            }

            return true;

        }

        private void Ürün_Formu_Load(object sender, EventArgs e)
        {

            txtÜrünID.Text = Ürün.Ürün_ID.ToString();

            if (Güncelleme)
            {

                txtÜrünAdı.Text = Ürün.Ürün_Adı;
                comboKategori.Text = Ürün.Kategori;
                numericBirimFiyat.Value = (decimal)Ürün.Birim_Fiyat;
                numericStokMiktarı.Value = (decimal)Ürün.Stok_Miktarı;
                numericBarkodNumarası.Value = (decimal)Ürün.Barkod_Numarası;
            }

        }
    }
}
