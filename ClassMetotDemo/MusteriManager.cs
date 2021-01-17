using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("<-----------Müşteri Eklendi---------->");
            Console.WriteLine("Adı : " + musteri.Ad);
            Console.WriteLine("Soyad : " + musteri.Soyad);
            Console.WriteLine("Yaş : " + musteri.Yas);
            Console.WriteLine("Müşteri No : " + musteri.Id);
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine("<-----------Müşteri Silindi---------->");
            Console.WriteLine("Adı : " + musteri.Ad);
            Console.WriteLine("Soyad : " + musteri.Soyad);
            Console.WriteLine("Yaş : " + musteri.Yas);
            Console.WriteLine("Müşteri No : " + musteri.Id);
        }

        public void Listele(Musteri[] musteriler)
        {
            foreach(Musteri musteri in musteriler)
            {
                Console.WriteLine("<-----------Müşteriler Listeleniyor---------->");
                Console.WriteLine("Adı : " + musteri.Ad);
                Console.WriteLine("Soyad : " + musteri.Soyad);
                Console.WriteLine("Yaş : " + musteri.Yas);
                Console.WriteLine("Müşteri No : " + musteri.Id);
            }
        }



    }
}
