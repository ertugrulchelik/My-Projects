using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {


            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.TC = "1234";
            musteri1.AdSoyad = "Ertugrul Celik";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.TC = "56789";
            musteri2.AdSoyad = "Eren Celik";


            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Id);
                Console.WriteLine(musteri.AdSoyad);
                Console.WriteLine(musteri.TC);
                Console.WriteLine("-------------------");
            }

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);

            musteriManager.Sil(musteri1);
            musteriManager.Sil(musteri2);

        }
    }
}
