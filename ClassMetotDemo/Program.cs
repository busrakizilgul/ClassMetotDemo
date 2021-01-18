using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Adi = "Ali";
            musteri1.Soyadi = "Güneş";
            musteri1.Numara = 12345;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Adi = "Ayşe";
            musteri2.Soyadi = "Yıldız";
            musteri2.Numara = 23456;

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Adi = "Cemal";
            musteri3.Soyadi = "Gündüz";
            musteri3.Numara = 34567;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Id);
                Console.WriteLine(musteri.Adi);
                Console.WriteLine(musteri.Soyadi);
                Console.WriteLine(musteri.Numara);
            }

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.Ekle(musteri1);
            musteriManager.Listele(musteri1);
            musteriManager.Sil(musteri1);

            musteriManager.Ekle(musteri2);
            musteriManager.Listele(musteri2);
            musteriManager.Sil(musteri2);

            musteriManager.Ekle(musteri3);
            musteriManager.Listele(musteri3);
            musteriManager.Sil(musteri3);



        }
    }
}
