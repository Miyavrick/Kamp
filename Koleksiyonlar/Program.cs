using System;
using System.Collections.Generic;
//using System.Collections.Generic;
namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = new string[] {"Rooney","Van Persie","İbrahimovic" };

            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //// yeni oluşan dizinin ilk elemanlarında birşey yok
            //isimler = new string[4];
            //isimler[3] = "Lukaku";
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[3]);


            List<string> isimler2 = new List<string> {"Rooney", "Van Persie", "İbrahimovic" };
            //isimler2.Add("Rooney");

            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            isimler2.Add("Lukaku");
            Console.WriteLine(isimler2[3]);

        }
    }
}
