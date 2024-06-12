using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veritabanı_Projesi.UI
{
    public partial class Sipariş_Formu : Form
    {
        public Sipariş_Formu()
        {
            InitializeComponent();
        }

        public Musteri Müşteri { get; set; }             
    
        public Urun Ürün { get; set; }

        public Calısan Çalışan { get; set; }

        public Siparis Siparişler { get; set; }

        public bool Güncelleme { get; set; } = false;

        private void btnTamam_Click(object sender, EventArgs e)
        {
            if (comboÖdemeTürü.SelectedItem == null)
            {
                errorProvider1.SetError(comboÖdemeTürü, "Lütfen ödeme türünüzü seçiniz.");
                comboÖdemeTürü.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(comboÖdemeTürü, "");
            }

            //Siparişler.Ürün_ID = Ürün.Ürün_ID;
            //Siparişler.Müşteri_ID = Müşteri.Müşteri_ID;
            //Siparişler.Çalışan_ID = Çalışan.Çalışan_ID;
            
            
            Siparişler.Tarih = dtTarih.Value;
            Siparişler.Ödeme_Türü = comboÖdemeTürü.SelectedItem.ToString();
            Siparişler.Ürün_ID = Guid.Parse(txtSiparişlerÜrünID.Text);
            Siparişler.Müşteri_ID = Guid.Parse(txtSiparişlerMüşteriID.Text);
            Siparişler.Çalışan_ID = Guid.Parse(txtSiparişlerÇalışanID.Text);
            Siparişler.Tutar = (float)numericTutar.Value;
            
            
            
            DialogResult = DialogResult.OK;
        }
  


        private void btnİptal_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void Sipariş_Formu_Load(object sender, EventArgs e)
        {
            txtSiparişID.Text = Siparişler.Sipariş_ID.ToString();

            if (Güncelleme)
            {
                dtTarih.Value = Siparişler.Tarih;
                numericTutar.Value = (decimal)Siparişler.Tutar;
                comboÖdemeTürü.Text = Siparişler.Ödeme_Türü;
                txtSiparişlerÜrünID.Text = Siparişler.Ürün_ID.ToString();
                txtSiparişlerMüşteriID.Text = Siparişler.Müşteri_ID.ToString();
                txtSiparişlerÇalışanID.Text = Siparişler.Çalışan_ID.ToString();
            }
        }

        private void btnMüşteriSeç_Click(object sender, EventArgs e)
        {
            Müşteriler müşteri_formu = new Müşteriler();
            if(müşteri_formu.ShowDialog() == DialogResult.OK)
            {
                Müşteri = müşteri_formu.Müşteri;
                txtSiparişlerMüşteriID.Text = Müşteri.ToString();
            }
        }

        private void btnÜrünSeç_Click(object sender, EventArgs e)
        {
            Ürünler ürün_formu = new Ürünler();
            if (ürün_formu.ShowDialog() == DialogResult.OK)
            {
                Ürün = ürün_formu.Ürün;
                txtSiparişlerÜrünID.Text = Ürün.ToString();
            }
        }

        private void btnÇalışanSeç_Click(object sender, EventArgs e)
        {
            Çalışanlar çalışan_formu = new Çalışanlar();
            if (çalışan_formu.ShowDialog() == DialogResult.OK)
            {
                Çalışan = çalışan_formu.Çalışan;
                txtSiparişlerÇalışanID.Text = Çalışan.ToString();
            }
        }
    }
}
