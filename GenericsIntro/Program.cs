using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            MyList<string> isimler = new MyList<string>();

            isimler.Add("Rooney");

            Console.WriteLine(isimler[0]);



        }
    }
}
