using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veritabanı_Projesi
{
    public class Musteri
    {
        public Guid Müşteri_ID { get; set; }

        public string Adı { get; set; }

        public string Soyadı { get; set; }

        public string Telefon_No { get; set; }

        public override string ToString()
        {
            return $"{Adı} {Soyadı}";
        }

    }

    public class Urun
    {
        public Guid Ürün_ID { get; set; }

        public string Ürün_Adı { get; set; }

        public string Kategori { get; set; }

        public float Birim_Fiyat { get; set; }

        public float Stok_Miktarı { get; set; }

        public float Barkod_Numarası { get; set; }

        public override string ToString()
        {
            return $"{Ürün_Adı}";
        }

    }

    public class Calısan
    {
        public Guid Çalışan_ID { get; set; }

        public string Adı { get; set; }

        public string Soyadı { get; set; }

        public string Cinsiyeti { get; set; }

        public float Maaşı { get; set; }

        public string Telefon_No { get; set; }

        public string Maili { get; set; }

        public override string ToString()
        {
            return $"{Adı} {Soyadı}";
        }

    }

    public class Siparis
    {
        public Guid Sipariş_ID { get; set; }

        public DateTime Tarih { get; set; }

        public float Tutar { get; set; }

        public string Ödeme_Türü { get; set; }

       public Guid Ürün_ID { get; set; }

       public Guid Müşteri_ID { get; set; }

       public Guid Çalışan_ID { get; set; }

    }




}
