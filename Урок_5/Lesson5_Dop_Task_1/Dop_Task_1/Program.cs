using System;

namespace Dop_Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int a = Convert.ToInt32(Console.ReadLine());
            int result = a & a - 1;

            if (result == 0)
            {
                Console.WriteLine("Число является степенью двойки");
            }
            else
            {
                Console.WriteLine("Число не является степенью двойки");
            }
            Console.ReadKey();
        }
    }
}
