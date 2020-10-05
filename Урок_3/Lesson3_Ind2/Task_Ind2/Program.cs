using System;

namespace Task_Ind2
{
    class Program
    {
        static void Main(string[] args)
        {
            byte a = 36, b = 5;
            Console.WriteLine("Сумма чисел {0} и {1} = {2}", a, b, a+b);
            Console.WriteLine("Вычитание чисел {0} и {1} = {2}", a, b, a-b);
            Console.WriteLine("Умножение чисел {0} и {1} = {2}", a, b, a * b);
            Console.WriteLine("Деление чисел {0} и {1} = {2}, остаток от деления {3}", a, b, a / b, a % b);
            Console.WriteLine("Возведение числа {0} в {1} степень = {2}", a, b, (Math.Pow(a,b)));
            Console.WriteLine("Корень квадратный с {0} = {2}, корень квадратный с {1} = {3}", a,b, (Math.Sqrt(a)), (Math.Sqrt(b)));
            
            Console.ReadKey();
             
        }
    }
}
