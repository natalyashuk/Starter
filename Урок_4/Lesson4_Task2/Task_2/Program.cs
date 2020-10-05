using System;
using System.Reflection.Metadata;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число от 1 до 100:");
            double number = Convert.ToDouble(Console.ReadLine());
 

            if ((number >= 0) && (number <= 14))
            {
                Console.WriteLine("Число входит в числовой промежуток 0-14 ");
            }
            else if ((number >= 15) && (number <= 35))
            {
                Console.WriteLine("Число входит в числовой промежуток 15-35");
            }
            else if ((number >= 36) && (number <= 50))
            {
                Console.WriteLine("Число входит в числовой промежуток 36-50");
            }
            else if ((number >= 50) && (number <= 100))
            {
                Console.WriteLine("Число входит в числовой промежуток 50-100");
            }
            else 
            {
                Console.WriteLine("Число не входит ни в один из имеющихся числовых промежутков");
            }

        
            Console.ReadKey();
   
        }
    }
}
