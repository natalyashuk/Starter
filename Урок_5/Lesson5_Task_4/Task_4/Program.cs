using System;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            double years; //выслуга годов
            double salary; //заработная плата
            double prize; // премия
            
            Console.WriteLine("Введите выслугу годов");
            years = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите сумму заработной платы");
            salary = Convert.ToDouble (Console.ReadLine());

            if (years > 0 && years < 5)
            {
                prize = salary * 0.1;
                Console.WriteLine("Сума премии: {0}", prize);
            }

            else if (years >= 5 && years < 10)
            {
                prize = salary * 0.15;
                Console.WriteLine("Сумма премии: {0}", prize);
            }

            else if (years >= 10 && years < 15)
            {
                prize = salary * 0.25;
                Console.WriteLine("Сумма премии: {0}", prize);
            }

            else if (years >= 15 && years < 20)
            {
                prize = salary * 0.35;
                Console.WriteLine("Сумма премии: {0}", prize);
            }

            else if (years >= 20 && years < 25)
            {
                prize = salary * 0.45;
                Console.WriteLine("Сумма премии: {0}", prize);
            }

            else if (years >= 25)
            {
                prize = salary * 0.5;
                Console.WriteLine("Сумма премии: {0}", prize);
            }
            else if (years <= 0)
            {
                Console.WriteLine("Недопустимое значение выслуги годов: Премия не полагается");
            }
           
            Console.ReadKey(); 
        }
    }
}
