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
    public partial class Çalışan_Formu : Form
    {
        public Çalışan_Formu()
        {
            InitializeComponent();
        }

        private void Çalışan_Formu_Load(object sender, EventArgs e)
        {
            txtÇalışanID.Text = Çalışan.Çalışan_ID.ToString();

            if(Güncelleme)
            {
                txtÇalışanAdı.Text = Çalışan.Adı;
                txtÇalışanSoyadı.Text =Çalışan.Soyadı;
                comboCinsiyeti.Text = Çalışan.Cinsiyeti;
                numericMaaşı.Value = (decimal)Çalışan.Maaşı;
                txtÇalışanTelefon.Text = Çalışan.Telefon_No;
                txtMaili.Text = Çalışan.Maili;
            
            }

        }

        public Calısan Çalışan {  get; set; }

        public bool Güncelleme {  get; set; } = false;

        private void btnTamam_Click(object sender, EventArgs e)
        {
            if (!ErrorControl(txtÇalışanAdı)) return;
            if (!ErrorControl(txtÇalışanSoyadı)) return;
            if (!ErrorControl(comboCinsiyeti)) return;
            if (!ErrorControl(numericMaaşı)) return;
            if (!ErrorControl(txtÇalışanTelefon)) return;
            if (!ErrorControl(txtMaili)) return;


            Çalışan.Adı = txtÇalışanAdı.Text;
            Çalışan.Soyadı = txtÇalışanSoyadı.Text;
            Çalışan.Cinsiyeti = comboCinsiyeti.SelectedItem.ToString();
            Çalışan.Maaşı = (float)numericMaaşı.Value;
            Çalışan.Telefon_No = txtÇalışanTelefon.Text;
            Çalışan.Maili = txtMaili.Text;


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

    }
}
