using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            double operand1 = 50, operand2 = -36;
           
            Console.WriteLine("Пожалуйста, введите знак арифметической операции :");
            string sigh = Console.ReadLine();
            double result = 0;

            switch (sigh)
            {
                case "+":
                    result = operand1 + operand2;
                    Console.WriteLine("{0}+({1})={2}",operand1, operand2, result);
                    break;

                case "-":
                    result = operand1 - operand2;
                    Console.WriteLine("{0}-({1})={2}", operand1, operand2, result);
                    break;

                case "*":
                    result = operand1 * operand2;
                    Console.WriteLine("{0}*({1})={2}", operand1, operand2, result);
                    break;

                case "/":
                    if (operand2 != 0)
                    {
                        result = operand1 / operand2;
                        Console.WriteLine("{0}/({1})={2}", operand1, operand2, result);
                    }                 
                    else
                    { 
                        Console.WriteLine("Нельзя делить на 0!");
                    }
                    break;

                default:
                    Console.WriteLine("Неверный ввод знака арифметической операции");
                    break;

            }

            Console.ReadKey();
        }
    }
}
