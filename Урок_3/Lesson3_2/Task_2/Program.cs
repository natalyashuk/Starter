using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Используя Visual Studio, создайте проект по шаблону Console Application.
            //Вычислите среднее арифметическое трех целочисленных значений и выведите его на экран.
            //С какой проблемой вы столкнулись? Какой тип переменных лучше использовать для корректного
            //отображения результата? 
            double a = 25, b = 8, c = 55;
            double result = (a + b + c) / 3;
            Console.WriteLine("Среднее арифметическое чисел = {0}", result);
            Console.ReadKey();
        }
    }
}
