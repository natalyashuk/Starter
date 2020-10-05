using System;

namespace DopTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите слово на русском языке про погоду : ");

            string weather = Console.ReadLine();

            switch (weather)
            {
                case "солнечно":
                    Console.WriteLine("sunny");
                    break;

                case "облачно":
                    Console.WriteLine("cloudy");
                    break;

                case "дождливо":
                    Console.WriteLine("rainy");
                    break;

                case "ветрено":
                    Console.WriteLine("windy");
                    break;

                case "туманно":
                    Console.WriteLine("foggy");
                    break;

                case "холодно":
                    Console.WriteLine("cold");
                    break;

                case "тепло":
                    Console.WriteLine("warm");
                    break;

                case "жарко":
                    Console.WriteLine("hot");
                    break;

                case "морозно":
                    Console.WriteLine("frosty");
                    break;

                case "прохладно":
                    Console.WriteLine("chilly");
                    break;

                default:
                    Console.WriteLine("Такого слова нет в словаре");
                    break;
            }

                    Console.ReadKey();
            
        }
    }
}
