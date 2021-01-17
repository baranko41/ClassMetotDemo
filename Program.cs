using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Customer musteri1 = new Customer();
            musteri1.Ad = "Baran";
            musteri1.Soyad = "Köse";
            musteri1.MusteriNo = 4441;

            Customer musteri2 = new Customer();
            musteri2.Ad = "Engin";
            musteri2.Soyad = "Demirog";
            musteri2.MusteriNo = 2021;

            Customer[] musteriler = new Customer[] { musteri1, musteri2 };

            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri.Ad);
                Console.WriteLine(musteri.Soyad);
                Console.WriteLine(musteri.MusteriNo);
                Console.WriteLine("^^^^^^^^^^^^^^^^^^^^");


            }

            Console.WriteLine("Durum");

            CustomerManager musterilist = new CustomerManager();
            musterilist.List(musteri1);
            musterilist.List(musteri2);

            Console.WriteLine("-----------------");
            CustomerManager musteriekleme = new CustomerManager();
            musteriekleme.Add(musteri1);

            CustomerManager mustericıkarma = new CustomerManager();
            Console.WriteLine("----------------------");
            musteriekleme.Remove(musteri2);

            Console.WriteLine("-----------------");
            musterilist.Add2("Onur","Sancay",1234);


            Console.WriteLine("Ödev 3'ün sonu");
            Console.ReadLine();

            




        }
    }
}
