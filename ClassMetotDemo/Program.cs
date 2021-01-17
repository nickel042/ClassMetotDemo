using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 111;
            musteri1.Ad = "Mehmet";
            musteri1.Soyad = "Yılmaz";
            musteri1.Yas = 22;
          

            Musteri musteri2 = new Musteri();
            musteri2.Id = 222;
            musteri2.Ad = "Zehra";
            musteri2.Soyad = "Yıldız";
            musteri2.Yas = 37;
           

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Sil(musteri2);
            musteriManager.Listele(musteriler);




            Console.Read();
        }
    }
}
