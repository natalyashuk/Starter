using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
             //Вариант 1
            byte r = 20, c = 2;
            const float pi = 3.141f;
            double result = pi * (Math.Pow(15,2));
            Console.WriteLine("Площадь круга = {0}", result);
            Console.ReadKey();

            //Вариант 2
            //byte r = 20;
            //const float pi = 3.141f;
            //Console.WriteLine("Площадь круга = {0}", (pi*r*r));
            //Console.ReadKey();

            //Вариант 3
            //byte r = 20, c = 2;
            //const float pi = 3.141f;
            //Console.WriteLine("Площадь круга = {0}", (float) (pi * Math.Pow(20,2)));
            //Console.ReadKey();

        }
    }
}
