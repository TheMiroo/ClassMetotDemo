using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();

            musteri1.Ad = "Miraç";
            musteri1.Soyad = "Altın";
            musteri1.HesapNo = 263754;


            Musteri musteri2 = new Musteri();

            musteri2.Ad = "Engin";
            musteri2.Soyad = "Demiroğ";
            musteri2.HesapNo = 319079;

            Console.WriteLine("--------------Listeleme-----------------");
            Musteri[] musteriler = new Musteri[] {musteri1, musteri2};

            foreach (var musteri in musteriler)
            {   
                Console.WriteLine("--------------Müşteri-----------------");
                Console.WriteLine(musteri.Ad);
                Console.WriteLine(musteri.Soyad);
                Console.WriteLine(musteri.HesapNo);
            }


            MusteriManager musteriManager = new MusteriManager();
            musteriManager.EkleMusteri(musteri1);
            Console.WriteLine("------------------------------");
            musteriManager.SilMusteri(musteri2);

            Console.WriteLine();
            Console.ReadLine();

        }
    }
}
