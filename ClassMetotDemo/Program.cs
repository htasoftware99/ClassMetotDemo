using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Ad = "Hasan";
            musteri1.Soyad = "Aykaç";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Ad = "Mehmet";
            musteri2.Soyad = "Buğra";

            Musteri[] musteris = new Musteri[] { musteri1, musteri2 };


            foreach (var m in musteris)
            {
                Console.WriteLine("ID: " + m.Id + " " + "Ad: " + " " + m.Ad + " " + "Soyad: " + m.Soyad);
            }

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Listele(musteri1);
            musteriManager.Ekle(musteri1);
            musteriManager.Silme(musteri1);


        }
    }
}

