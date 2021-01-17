using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add(Customer musteri)
        {
            Console.WriteLine("Müşteri Bilgileri Eklendi: " + musteri.Ad);
            Console.WriteLine("Müşteri Bilgileri Eklendi: " + musteri.Soyad);
            Console.WriteLine("Müşteri Bilgileri Eklendi: " + musteri.MusteriNo);

        }

        public void Remove(Customer musteri)
        {
            Console.WriteLine("Müşteri Bilgileri Çıkarıldı: " + musteri.Ad );
            Console.WriteLine("Müşteri Bilgileri Çıkarıldı: " + musteri.Soyad );
            Console.WriteLine("Müşteri Bilgileri Çıkarıldı: " + musteri.MusteriNo );
        }
        public void List(Customer musteriler)
        {
            Console.WriteLine("Müşterilerin Numaraları: " + musteriler.MusteriNo);
        }

        public void Add2(string musteriAdi, string soyAdi, int mstNo)
        {
            Console.WriteLine("Müşteri Adı Eklendi : " + musteriAdi);
            Console.WriteLine("Müşteri Soyadı Eklendi : " + soyAdi);
            Console.WriteLine("Müşteri No Eklendi : " + mstNo);
        }
    }
}
