using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        //müşteri ekle, listele, sil işlemleri
        public void Ekle (Musteri musteri)
        {
            Console.WriteLine("Müşteri eklendi" + musteri.Id);
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Müşteri silindi." + musteri.Id);
        }

        public void Listele(Musteri musteri)
        {
            Console.WriteLine("Müşteri listelendi" + musteri.Id);
        }
    }
}
