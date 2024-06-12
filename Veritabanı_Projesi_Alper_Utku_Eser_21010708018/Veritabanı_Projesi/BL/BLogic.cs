using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Veritabanı_Projesi.DL;
using System.Windows.Forms;
using System.Data;
using System.Security.Cryptography;

namespace Veritabanı_Projesi.BL
{
    public static class BLogic
    {
        public static bool MüşteriEkle(Musteri m)
        {
            try
            {

                int result = DataLayer.MüşteriEkle(m);

                return (result > 0);

            }

            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu: " + ex.Message);
                return false;
            }
        }

        internal static DataSet MüşteriGetir(string filtre)
        {
            try
            {

                DataSet ds = DataLayer.MüşteriGetir(filtre);

                return ds;

            }

            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu: " + ex.Message);
                return null;
            }
        }

        internal static bool MüşteriGüncelle(Musteri m)
        {
            try
            {

                int result = DataLayer.MüşteriGüncelle(m);

                return (result > 0);

            }

            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu: " + ex.Message);
                return false;
            }
        }

        internal static bool MüşteriSil(string mid)
        {
            try
            {

                int result = DataLayer.MüşteriSil(mid);

                return (result > 0);

            }

            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu: " + ex.Message);
                return false;
            }
        }





        internal static DataSet ÜrünGetir(string filtre)
        {
            try
            {

                DataSet ds2 = DataLayer.ÜrünGetir(filtre);

                return ds2;

            }

            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu: " + ex.Message);
                return null;
            }
        }

        internal static bool ÜrünEkle(Urun u)
        {
            try
            {

                int result = DataLayer.ÜrünEkle(u);

                return (result > 0);

            }

            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu: " + ex.Message);
                return false;
            }
        }

        internal static bool ÜrünGüncelle(Urun u)
        {
            try
            {

                int result = DataLayer.ÜrünGüncelle(u);

                return (result > 0);

            }

            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu: " + ex.Message);
                return false;
            }
        }

        internal static bool ÜrünSil(string uid)
        {
            try
            {

                int result = DataLayer.ÜrünSil(uid);

                return (result > 0);

            }

            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu: " + ex.Message);
                return false;
            }
        }
    
    



        internal static bool ÇalışanEkle(Calısan ç)
        {
            try
            {

                int result = DataLayer.ÇalışanEkle(ç);

                return (result > 0);

            }

            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu: " + ex.Message);
                return false;
            }
        }

        internal static DataSet ÇalışanGetir(string filtre)
        {
            try
            {

                DataSet ds = DataLayer.ÇalışanGetir(filtre);

                return ds;

            }

            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu: " + ex.Message);
                return null;
            }
        }

        internal static bool ÇalışanGüncelle(Calısan ç)
        {
            try
            {

                int result = DataLayer.ÇalışanGüncelle(ç);

                return (result > 0);

            }

            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu: " + ex.Message);
                return false;
            }
        }

        internal static bool ÇalışanSil(string çid)
        {
            try
            {

                int result = DataLayer.ÇalışanSil(çid);

                return (result > 0);

            }

            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu: " + ex.Message);
                return false;
            }
        }





        internal static bool SiparişEkle(Siparis s)
        {
            try
            {

                int result = DataLayer.SiparişEkle(s);

                return (result > 0);

            }

            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu: " + ex.Message);
                return false;
            }
        }

        internal static DataSet SiparişGetir(string v)
        {
            try
            {

                DataSet ds = DataLayer.SiparişGetir();

                return ds;

            }

            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu: " + ex.Message);
                return null;
            }
        }

        internal static bool SiparişGüncelle(Siparis s)
        {
            try
            {

                int result = DataLayer.SiparişGüncelle(s);

                return (result > 0);

            }

            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu: " + ex.Message);
                return false;
            }
        }

        internal static bool SiparişSil(string sid)
        {
            try
            {

                int result = DataLayer.SiparişSil(sid);

                return (result > 0);

            }

            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu: " + ex.Message);
                return false;
            }
        }
    }
}
