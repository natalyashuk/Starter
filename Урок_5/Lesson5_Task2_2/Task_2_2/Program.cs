using System;

namespace Task_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Введите число:");
            int a = Convert.ToInt32(Console.ReadLine());
            int result = a & 1;
            
            if (result == 0)
            {
                Console.WriteLine("Вы ввели четное число");
            }
            else
            {
                Console.WriteLine("Вы ввели нечетное число");
            }

            Console.ReadKey();
        }
    }
}
