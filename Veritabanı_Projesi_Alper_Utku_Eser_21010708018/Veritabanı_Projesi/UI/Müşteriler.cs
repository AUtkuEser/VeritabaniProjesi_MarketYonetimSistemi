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
    public partial class Müşteriler : Form
    {
        public Müşteriler()
        {
            InitializeComponent();
        }

        private void btnMüşteriEkle_Click(object sender, EventArgs e)
        {
            Müşteri_Formu müşteri_Formu = new Müşteri_Formu()
            {
                Text = "Müşteri Ekle",
                Müşteri = new Musteri() { Müşteri_ID = Guid.NewGuid() }
            };

        tekrar:
            var sonuc = müşteri_Formu.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.MüşteriEkle(müşteri_Formu.Müşteri);

                if (b)
                {
                    DataSet ds = BLogic.MüşteriGetir("");
                    if (ds != null)
                        dataGridView1.DataSource = ds.Tables[0];

                }
                else
                    goto tekrar;

            }
        }



        private void btnMüşteriBul_Click(object sender, EventArgs e)
        {
            DataSet ds = BLogic.MüşteriGetir(toolStripTextBox1.Text);
            if (ds != null)
                dataGridView1.DataSource = ds.Tables[0];
        }



        private void btnMüşteriSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            var mid = row.Cells[0].Value.ToString();



            var sonuc = MessageBox.Show("Seçtiğiniz müşterinin silinmesini istiyor musunuz?", "Silmeyi onayla",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.MüşteriSil(mid);

                if (b)
                {
                    DataSet ds = BLogic.MüşteriGetir("");
                    if (ds != null)
                        dataGridView1.DataSource = ds.Tables[0];

                }



            }



        }


        private void btnMüşteriDüzenle_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];

            Müşteri_Formu müşteri_Formu = new Müşteri_Formu()
            {
                Text = "Müşteri Güncelle",
                Güncelleme = true,
                Müşteri = new Musteri()
                {
                    Müşteri_ID = Guid.Parse(row.Cells[0].Value.ToString()),
                    Adı = row.Cells[1].Value.ToString(),
                    Soyadı = row.Cells[2].Value.ToString(),
                    Telefon_No = row.Cells[3].Value.ToString(),
                },

            };

            var sonuc = müşteri_Formu.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.MüşteriGüncelle(müşteri_Formu.Müşteri);

                if (b)
                {

                    row.Cells[1].Value = müşteri_Formu.Müşteri.Adı;
                    row.Cells[2].Value = müşteri_Formu.Müşteri.Soyadı;
                    row.Cells[3].Value = müşteri_Formu.Müşteri.Telefon_No;

                }



            }
        }

        private void Müşteriler_Load(object sender, EventArgs e)
        {
            DataSet ds1 = BLogic.MüşteriGetir("");
            if (ds1 != null)
                dataGridView1.DataSource = ds1.Tables[0];
        }


        public Musteri Müşteri { get; set; }
        private void btnTamam_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];


            Müşteri = new Musteri()
            {
                Müşteri_ID = Guid.Parse(row.Cells[0].Value.ToString()),
                Adı = row.Cells[1].Value.ToString(),
                Soyadı = row.Cells[2].Value.ToString(),
                Telefon_No = row.Cells[3].Value.ToString(),
            };

            

            DialogResult = DialogResult.OK;
        }

        private void btnİptal_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
