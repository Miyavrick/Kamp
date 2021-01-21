using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 20;
            musteri1.Ad = "Hakan";
            musteri1.Soyad = "YILDIRIM";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 49;
            musteri2.Ad = "Zlatan";
            musteri2.Soyad = "İbrahimovic";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 43;
            musteri3.Ad = "Wayne";
            musteri3.Soyad = "Rooney";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2,musteri3 };


            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Id);
                Console.WriteLine(musteri.Ad);
                Console.WriteLine(musteri.Soyad);
                Console.WriteLine("------------------------");

            }

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Islem(musteri1);
            musteriManager.Islem(musteri2);
            musteriManager.Islem2(musteri3);
        }
    }

    class Musteri
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
    }

    
        class MusteriManager
        {
            public void Islem(Musteri musteri)
            {
            Console.WriteLine("Kayıt Yaptıran = " + musteri.Ad);

            }
            public void Islem2(Musteri musteri)
        {
            Console.WriteLine("Kayıt Sildiren = " + musteri.Ad);
        }

        }
    


}
