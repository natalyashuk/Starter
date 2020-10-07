using System;

namespace DopTask_2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool A = true; 
            bool B = false;
            bool result1 = A || B;
            bool result2 = !(!A&&!B);
           
            Console.WriteLine("Значение A{0}|| B{1}={2}", A, B, result1);
            Console.WriteLine("Значение A{0}|| B{1}={2}", A, B, result2);

            Console.ReadKey();
        }
    }
}
