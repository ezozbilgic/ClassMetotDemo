using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Adi = "Ezgi";
            musteri1.Soyadi = "Sonem";
            musteri1.Yasi = 24;
            musteri1.Gender = "Female";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Adi = "Cemre";
            musteri2.Soyadi = "Akkuş";
            musteri2.Yasi = 23;
            musteri2.Gender = "Female";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Adi = "Emir";
            musteri3.Soyadi = "Çakır";
            musteri3.Yasi = 22;
            musteri3.Gender = "Male";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Adi);
                Console.WriteLine(musteri.Soyadi);
                Console.WriteLine(musteri.Yasi);
                Console.WriteLine(musteri.Gender);
                Console.WriteLine("----------");

            
            }

            //musteri ekleme
            MusteriManager musteriManager = new MusteriManager();

            musteriManager.MusteriEkleme(musteri1);
            musteriManager.MusteriEkleme(musteri2);
            musteriManager.MusteriEkleme(musteri3);

            //musteri silme
            MusteriManager musteriManager2 = new MusteriManager();

            musteriManager2.MusteriSilme(musteri1);
            musteriManager2.MusteriSilme(musteri2);
            musteriManager2.MusteriSilme(musteri3);


            Console.ReadLine();
        }
        
    }
}
