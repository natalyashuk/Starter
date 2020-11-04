using System;

namespace Lesson6_DopTask
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 35; 
            int b = 7;
            { 
                for (int i = 0; i < b; i++)
                {                   
                    for (int j = 0; j < a; j++)
                    {
                        Console.Write("*");
                    }            
                    Console.WriteLine();
                }               
                Console.ReadKey();
            }
        }
    }
}
