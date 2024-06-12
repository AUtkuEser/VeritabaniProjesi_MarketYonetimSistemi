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
    public partial class Müşteri_Formu : Form
    {
        public Müşteri_Formu()
        {
            InitializeComponent();
        }

        private void Müşteri_Load(object sender, EventArgs e)
        {
            txtMüşteriID.Text = Müşteri.Müşteri_ID.ToString();

            if (Güncelleme)
            {
                
                txtMüşteriAdı.Text = Müşteri.Adı;
                txtMüşteriSoyadı.Text = Müşteri.Soyadı;
                txtMüşteriTelefon.Text = Müşteri.Telefon_No;

            }
            
        }

        private void btnİptal_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        public Musteri Müşteri {  get; set; }

        public bool Güncelleme { get; set; } = false;
        

        private void btnTamam_Click(object sender, EventArgs e)
        {
           if (!ErrorControl(txtMüşteriAdı)) return;
           if (!ErrorControl(txtMüşteriSoyadı)) return;
           if (!ErrorControl(txtMüşteriTelefon)) return;


            Müşteri.Adı = txtMüşteriAdı.Text;
            Müşteri.Soyadı = txtMüşteriSoyadı.Text;
            Müşteri.Telefon_No = txtMüşteriTelefon.Text;


            DialogResult = DialogResult.OK;
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

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

        private void txtTelefon_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
