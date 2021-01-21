using System;

namespace ToplamaMetod
{
    class Program
    {
        static void Main(string[] args)
        {

            int number1 = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Topla(number1,number2));




            static int Topla(int number1, int number2)
            {

                return number1 + number2;

            }



        }



    }



}
