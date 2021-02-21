using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Müşteri Eklendi");
        }
        public void Listele(Musteri musteri)
        {
            Console.WriteLine("Müşteri Listelendi");
        }
        public void Silme(Musteri musteri)
        {
            Console.WriteLine("Müşteri Silindi");
        }
    }
}

