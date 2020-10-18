using System;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {

            byte R = 18, //радиус циилиндра
                 h = 12; //высота цилиндра
            const float pi = 3.141f;
            int sum = R + h;
            double V = (pi * R * R * h);
            double S = (2 * pi * R * sum);
            Console.WriteLine("Обьем цилиндра = {0}", V);
            Console.WriteLine("Площадь поверхности цилиндра = {0}", S);
            Console.ReadKey();
            
        }
    }
}
