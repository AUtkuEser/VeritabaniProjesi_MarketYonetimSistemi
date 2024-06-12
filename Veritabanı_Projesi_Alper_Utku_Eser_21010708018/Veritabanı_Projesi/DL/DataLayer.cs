using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;

namespace Veritabanı_Projesi.DL
{
    public static class DataLayer
    {
        static MySqlConnection conn = new MySqlConnection(
            new MySqlConnectionStringBuilder()
            {
                Server = "localhost",
                Database = "market_yönetimi",
                UserID = "root",
                Password = "Utku1234",

            }.ConnectionString
            );

        public static int MüşteriEkle(Musteri m)
        {

            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                MySqlCommand komut = new MySqlCommand("MusteriEkle", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@mid", m.Müşteri_ID);
                komut.Parameters.AddWithValue("@mad", m.Adı);
                komut.Parameters.AddWithValue("@msoyad", m.Soyadı);
                komut.Parameters.AddWithValue("@mtel", m.Telefon_No);

                int result = komut.ExecuteNonQuery();
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
               
            }
            finally 
            { 
            if(conn.State != System.Data.ConnectionState.Closed) 
                conn.Close();
            
            }


        }

        internal static DataSet MüşteriGetir(string filtre)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                MySqlCommand komut;
                if (string.IsNullOrEmpty(filtre))
                {
                    komut = new MySqlCommand("MusterilerHepsi", conn);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;
                  
                }
                else
                {
                    komut = new MySqlCommand("MusteriBul", conn);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;
                    komut.Parameters.AddWithValue("@filtre", filtre);

                }
                DataSet dataSet = new DataSet();
                MySqlDataAdapter adp = new MySqlDataAdapter(komut);
                adp.Fill(dataSet);

                return dataSet;
            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();

            }
        }

        internal static int MüşteriGüncelle(Musteri m)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                MySqlCommand komut = new MySqlCommand("MusteriGuncelle", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@mid", m.Müşteri_ID);
                komut.Parameters.AddWithValue("@mad", m.Adı);
                komut.Parameters.AddWithValue("@msoyad", m.Soyadı);
                komut.Parameters.AddWithValue("@mtel", m.Telefon_No);

                int result = komut.ExecuteNonQuery();
                return result;
            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();

            }
        }

        internal static int MüşteriSil(string mid)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                MySqlCommand komut = new MySqlCommand("MusteriSil", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@mid", mid);

                int result = komut.ExecuteNonQuery();
                return result;
            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();

            }
        }






        internal static DataSet ÜrünGetir(string filtre)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                MySqlCommand komut;
                if (string.IsNullOrEmpty(filtre))
                {
                    komut = new MySqlCommand("ÜrünlerHepsi", conn);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;

                }
                else
                {
                    komut = new MySqlCommand("ÜrünBul", conn);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;
                    komut.Parameters.AddWithValue("@filtre", filtre);

                }
                DataSet dataSet = new DataSet();
                MySqlDataAdapter adp = new MySqlDataAdapter(komut);
                adp.Fill(dataSet);

                return dataSet;
            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();

            }
        }

        internal static int ÜrünEkle(Urun u)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                MySqlCommand komut = new MySqlCommand("ÜrünEkle", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@uid", u.Ürün_ID);
                komut.Parameters.AddWithValue("@uAd", u.Ürün_Adı);
                komut.Parameters.AddWithValue("@uKategori", u.Kategori);
                komut.Parameters.AddWithValue("@uFiyat", u.Birim_Fiyat);
                komut.Parameters.AddWithValue("@uStok", u.Stok_Miktarı);
                komut.Parameters.AddWithValue("@uBarkod", u.Barkod_Numarası);

                int result = komut.ExecuteNonQuery();
                return result;
            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();

            }
        }

        internal static int ÜrünGüncelle(Urun u)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                MySqlCommand komut = new MySqlCommand("ÜrünGüncelle", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@uid", u.Ürün_ID);
                komut.Parameters.AddWithValue("@uAd", u.Ürün_Adı);
                komut.Parameters.AddWithValue("@uKategori", u.Kategori);
                komut.Parameters.AddWithValue("@uFiyat", u.Birim_Fiyat);
                komut.Parameters.AddWithValue("@uStok", u.Stok_Miktarı);
                komut.Parameters.AddWithValue("@uBarkod", u.Barkod_Numarası);

                int result = komut.ExecuteNonQuery();
                return result;
            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();

            }
        }

        internal static int ÜrünSil(string uid)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                MySqlCommand komut = new MySqlCommand("ÜrünSil", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@uid", uid);

                int result = komut.ExecuteNonQuery();
                return result;
            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();

            }
        }
    





        internal static int ÇalışanEkle(Calısan ç)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                MySqlCommand komut = new MySqlCommand("ÇalışanEkle", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@çid", ç.Çalışan_ID);
                komut.Parameters.AddWithValue("@çAd", ç.Adı);
                komut.Parameters.AddWithValue("@çSoyad", ç.Soyadı);
                komut.Parameters.AddWithValue("@çCinsiyet", ç.Cinsiyeti);
                komut.Parameters.AddWithValue("@çMaaş", ç.Maaşı);
                komut.Parameters.AddWithValue("@çTel", ç.Telefon_No);
                komut.Parameters.AddWithValue("@çMail", ç.Maili);

                int result = komut.ExecuteNonQuery();
                return result;
            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();

            }
        }

        internal static DataSet ÇalışanGetir(string filtre)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                MySqlCommand komut;
                if (string.IsNullOrEmpty(filtre))
                {
                    komut = new MySqlCommand("ÇalışanlarHepsi", conn);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;

                }
                else
                {
                    komut = new MySqlCommand("ÇalışanBul", conn);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;
                    komut.Parameters.AddWithValue("@filtre", filtre);

                }
                DataSet dataSet = new DataSet();
                MySqlDataAdapter adp = new MySqlDataAdapter(komut);
                adp.Fill(dataSet);

                return dataSet;
            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();

            }
        }

        internal static int ÇalışanGüncelle(Calısan ç)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                MySqlCommand komut = new MySqlCommand("ÇalışanGüncelle", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@çid", ç.Çalışan_ID);
                komut.Parameters.AddWithValue("@çAd", ç.Adı);
                komut.Parameters.AddWithValue("@çSoyad", ç.Soyadı);
                komut.Parameters.AddWithValue("@çCinsiyet", ç.Cinsiyeti);
                komut.Parameters.AddWithValue("@çMaaş", ç.Maaşı);
                komut.Parameters.AddWithValue("@çTel", ç.Telefon_No);
                komut.Parameters.AddWithValue("@çMail", ç.Maili);

                int result = komut.ExecuteNonQuery();
                return result;
            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();

            }
        }

        internal static int ÇalışanSil(string çid)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                MySqlCommand komut = new MySqlCommand("ÇalışanSil", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@çid", çid);

                int result = komut.ExecuteNonQuery();
                return result;
            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();

            }
        }

        




        internal static int SiparişEkle(Siparis s)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                MySqlCommand komut = new MySqlCommand("SiparişEkle", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@sid", s.Sipariş_ID);
                komut.Parameters.AddWithValue("@sTarih", s.Tarih);
                komut.Parameters.AddWithValue("@sTutar", s.Tutar);
                komut.Parameters.AddWithValue("@sÖdemeTürü", s.Ödeme_Türü);
                komut.Parameters.AddWithValue("@uid", s.Ürün_ID);
                komut.Parameters.AddWithValue("@mid", s.Müşteri_ID);
                komut.Parameters.AddWithValue("@çid", s.Çalışan_ID);

                int result = komut.ExecuteNonQuery();
                return result;
            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();

            }
        }

        internal static DataSet SiparişGetir()
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                    
                    MySqlCommand komut = new MySqlCommand("SiparişlerHepsi", conn);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;

                
                
                DataSet dataSet = new DataSet();
                MySqlDataAdapter adp = new MySqlDataAdapter(komut);
                adp.Fill(dataSet);

                return dataSet;
            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();

            }
        }

        internal static int SiparişGüncelle(Siparis s)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                MySqlCommand komut = new MySqlCommand("SiparişGüncelle", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@sid", s.Sipariş_ID);
                komut.Parameters.AddWithValue("@sTarih", s.Tarih);
                komut.Parameters.AddWithValue("@sTutar", s.Tutar);
                komut.Parameters.AddWithValue("@sÖdemeTürü", s.Ödeme_Türü);
                komut.Parameters.AddWithValue("@uid", s.Ürün_ID);
                komut.Parameters.AddWithValue("@mid", s.Müşteri_ID);
                komut.Parameters.AddWithValue("@çid", s.Çalışan_ID);

                int result = komut.ExecuteNonQuery();
                return result;
            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();

            }
        }

        internal static int SiparişSil(string sid)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                MySqlCommand komut = new MySqlCommand("SiparişSil", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@sid", sid);

                int result = komut.ExecuteNonQuery();
                return result;
            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();

            }
        }
    }
}
