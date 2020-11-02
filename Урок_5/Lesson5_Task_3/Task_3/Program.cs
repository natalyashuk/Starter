using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5, y = 10, z = 15;
            x += y >> x++ * z;
            Console.WriteLine("Результат 1 = {0}", x);
            z = ++x & (y* 5);
            Console.WriteLine("Результат 2 = {0}", z);
            y /= (x + 5) | z;
            Console.WriteLine("Результат 3 = {0}", y);
            z = (x++) & (y * 5);
            Console.WriteLine("Результат 4 = {0}", z);
            x = (y << x++) ^ z;
            Console.WriteLine("Результат 5 = {0}", x);

            Console.ReadKey();
        }
    }
}
