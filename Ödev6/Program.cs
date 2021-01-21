using System;
namespace Ödev6
{
   class Program
    {
      static void Main(string[] args)
        {
            Product urun1 = new Product();
            urun1.urunAd = "Leptop";
            urun1.urunFiyat = 13000;

            Product urun2 = new Product()
            {
                urunAd = "Telefon",
                urunFiyat = 5500
            };
            Product[] urunDizisi = new Product[] { urun1, urun2 };

            for (int i = 0; i < urunDizisi.Length ; i++)
            {
                Console.WriteLine("Ürün Türü = " + urunDizisi[i].urunAd);
                Console.WriteLine("Ürün Fiyatı =  " + urunDizisi[i].urunFiyat);
            }
            Console.WriteLine("-----------------------------------------");
            foreach (var x in urunDizisi)
            {
                Console.WriteLine("Ürün Türü = " + x.urunAd);
                Console.WriteLine("Ürün Fiyatı =  " + x.urunFiyat);
            }
        }
        class Product
        {
            public string urunAd { get; set; }
            public double urunFiyat { get; set; } 
        }
    }
}
