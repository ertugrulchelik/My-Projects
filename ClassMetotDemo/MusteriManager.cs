using System;
namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Musteri eklendi :" + musteri.AdSoyad);
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Musteri silindi :" + musteri.AdSoyad);
        }
    }
}
