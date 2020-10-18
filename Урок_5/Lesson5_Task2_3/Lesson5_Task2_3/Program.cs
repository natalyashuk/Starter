using System;

namespace Lesson5_Task2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int a = Convert.ToInt32(Console.ReadLine());
            int result = (byte)(a << 7);

            if (result==0)
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
