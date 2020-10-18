using System;

namespace Lesson5_Task_2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int a = Convert.ToInt16(Console.ReadLine());
            int result = (byte)(a & 1);

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
