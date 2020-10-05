using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            {
                int x = 10, y = 12, z = 3;

                x += y - (x++ * z);

                Console.WriteLine("Результат операции x += y - x++ * z = {0}", x);
            }

            {
                int x = 10, y = 12, z = 3;
                
                z = --x - (y * 5); 
                               
                Console.WriteLine("Результат операции z = --x - y * 5 = {0}", z);
            }

            {
                int x = 10, y = 12, z = 3;
                
                y /= x + (5 % z);

                Console.WriteLine("Результат операции y /= x + 5 % z = {0}", y);
            }

            {
                int x = 10, y = 12, z = 3;

                z = x++ + (y * 5);
                         
                Console.WriteLine("Результат операции z = x++ + y * 5 = {0}", z);
            }

            {
                int x = 10, y = 12, z = 3;

                x = y - (x++ * z);

                Console.WriteLine("Результат операции x = y - x++ * z = {0}", x);
            }

            Console.ReadKey();
        }
    }
}
