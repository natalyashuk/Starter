using System;

namespace Lesson6_Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int b = Convert.ToInt32(Console.ReadLine());

                { 
                for (int i = 0; i < a; i++)
                {
                    for (int j = 0; j < b; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
                    Console.WriteLine("\n");
                }

                {
                    for (int i = 0; i < a; i++)
                    {
                        for (int j = 0; j < i; j++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine("\n");
                }


            {
                int k = 1;
                k += 2;
                int m = 1;
                m -= 1;
                {
                    for (int i = 0; i < a; i++)
                    {
                        for (int j = 0; j < b; j++)
                        {
                            Console.Write(" ");
                        }
                        for (int x = 0; x < k; x++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine("\n");
                }
            }

            Console.ReadKey();
            
        }
    }
}
