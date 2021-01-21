using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {

            Product urun1 = new Product();
            urun1.Adi = "Elma";
            urun1.Fiyat = 1.3;
            urun1.Acıklama = "Amasya";


            Product urun2 = new Product();
            urun2.Adi = "Karpuz";
            urun2.Fiyat = 2.8;
            urun2.Acıklama = "Diyarbakır";


            Product[] urunler = new Product[] {urun1 , urun2 };

            foreach (Product x in urunler)
            {
                Console.WriteLine(x.Adi);
                Console.WriteLine(x.Fiyat);
                Console.WriteLine(x.Acıklama);
            
                Console.WriteLine("----------------------------");
            }
            Console.WriteLine("*******************Metodlar******************");

                SepetManager sepetManager = new SepetManager();
                sepetManager.Ekle(urun1);
                sepetManager.Ekle2("Armut", "Yeşil", 12, 10);
                sepetManager.Ekle2("Kivi", "Ekşi", 21, 4);
                sepetManager.Ekle2("Kavun", "Kabak", 33, 12);

            

        }
    }
}
