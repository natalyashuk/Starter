using System;

namespace IndTask
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 36, b = 5;
           
            //Операция сложения
            int sum = a + b;
            Console.WriteLine("Сумма чисел {0} и {1}= {2}", a, b, sum);

            //Операция вычитания
            int difference = a - b;
            Console.WriteLine("Разница чисел {0} и {1}= {2}", a, b, difference);
            
            //Операция умножение
            int product = a * b;
            Console.WriteLine("Произведение {0} и {1}= {2}", a, b, product);

            //Операция деления
            int quotient = a / b;         
            Console.WriteLine("Деление {0} и {1}= {2}", a, b, quotient);

            //Остаток от деления
            int remainder = a % b;
            Console.WriteLine("Остаток от деления {0} и {1}= {2}", a, b, remainder);

            //Возведение в степень 
            double result = Math.Pow(a,b);
            Console.WriteLine("Возведение числа {0} в {1} степень = {2}", a, b, result);

            //Квадратный корень
            double result1 = Math.Sqrt(a);
            double result2 = Math.Sqrt(b);
            Console.WriteLine("Квадратний корень числа {0} = {1}", a, result1);
            Console.WriteLine("Квадратний корень числа {0} = {1}", b, result2);

            Console.ReadKey();

        }   

        
    }
}
