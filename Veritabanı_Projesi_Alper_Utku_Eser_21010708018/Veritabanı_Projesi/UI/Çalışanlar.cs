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
    public partial class Çalışanlar : Form
    {
        public Çalışanlar()
        {
            InitializeComponent();
        }


        private void btnÇalışanEkle_Click(object sender, EventArgs e)
        {
            Çalışan_Formu çalışan_formu = new Çalışan_Formu()
            {
                Text = "Çalışan Ekle",
                Çalışan = new Calısan() { Çalışan_ID = Guid.NewGuid() }
            };

        tekrar:
            var sonuc = çalışan_formu.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.ÇalışanEkle(çalışan_formu.Çalışan);

                if (b)
                {
                    DataSet ds = BLogic.ÇalışanGetir("");
                    if (ds != null)
                        dataGridView3.DataSource = ds.Tables[0];

                }
                else
                    goto tekrar;

            }
        }

        private void btnÇalışanBul_Click(object sender, EventArgs e)
        {
            DataSet ds = BLogic.ÇalışanGetir(toolStripTextBox3.Text);
            if (ds != null)
                dataGridView3.DataSource = ds.Tables[0];
        }

        private void btnÇalışanDüzenle_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView3.SelectedRows[0];

            Çalışan_Formu çalışan_formu = new Çalışan_Formu()
            {
                Text = "Çalışan Güncelle",
                Güncelleme = true,
                Çalışan = new Calısan()
                {
                    Çalışan_ID = Guid.Parse(row.Cells[0].Value.ToString()),
                    Adı = row.Cells[1].Value.ToString(),
                    Soyadı = row.Cells[2].Value.ToString(),
                    Cinsiyeti = row.Cells[3].Value.ToString(),
                    Maaşı = float.Parse(row.Cells[4].Value.ToString()),
                    Telefon_No = row.Cells[5].Value.ToString(),
                    Maili = row.Cells[6].Value.ToString(),
                },

            };

            var sonuc = çalışan_formu.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.ÇalışanGüncelle(çalışan_formu.Çalışan);

                if (b)
                {

                    row.Cells[1].Value = çalışan_formu.Çalışan.Adı;
                    row.Cells[2].Value = çalışan_formu.Çalışan.Soyadı;
                    row.Cells[3].Value = çalışan_formu.Çalışan.Cinsiyeti;
                    row.Cells[4].Value = çalışan_formu.Çalışan.Maaşı;
                    row.Cells[5].Value = çalışan_formu.Çalışan.Telefon_No;
                    row.Cells[6].Value = çalışan_formu.Çalışan.Maili;
                }



            }
        }

        private void btnÇalışanSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView3.SelectedRows[0];
            var çid = row.Cells[0].Value.ToString();



            var sonuc = MessageBox.Show("Seçtiğiniz Çalışanın silinmesini istiyor musunuz?", "Silmeyi onayla",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.ÇalışanSil(çid);

                if (b)
                {
                    DataSet ds = BLogic.ÇalışanGetir("");
                    if (ds != null)
                        dataGridView3.DataSource = ds.Tables[0];

                }



            }
        }

        private void Çalışanlar_Load(object sender, EventArgs e)
        {
            DataSet ds3 = BLogic.ÇalışanGetir("");
            if (ds3 != null)
                dataGridView3.DataSource = ds3.Tables[0];
        }


        public Calısan Çalışan { get; set; }

        private void btnTamam_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView3.SelectedRows[0];

            Çalışan = new Calısan()
            {
                Çalışan_ID = Guid.Parse(row.Cells[0].Value.ToString()),
                Adı = row.Cells[1].Value.ToString(),
                Soyadı = row.Cells[2].Value.ToString(),
                Cinsiyeti = row.Cells[3].Value.ToString(),
                Maaşı = float.Parse(row.Cells[4].Value.ToString()),
                Telefon_No = row.Cells[5].Value.ToString(),
                Maili = row.Cells[6].Value.ToString(),
            };

            DialogResult = DialogResult.OK;
           
        }

        private void btnİptal_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
