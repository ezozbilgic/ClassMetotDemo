using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkleme(Musteri musteri)
        {
            Console.WriteLine("Musteri Eklendi : " + musteri.Adi);
        }
        public void MusteriSilme(Musteri musteri)
        {
            Console.WriteLine("Musteri Silindi : " + musteri.Adi);
        }
    }
}
