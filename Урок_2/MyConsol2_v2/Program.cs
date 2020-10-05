using System;

namespace MyConsol2_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            string myPhrase = "\nмоя строка 1";
            string myPhrase2 = "\tмоя строка 2";
            string myPhrase3 = "\aмоя строка 3";
            Console.WriteLine(myPhrase);
            Console.WriteLine(myPhrase2);
            Console.WriteLine(myPhrase3);
            Console.ReadKey();

        }
    }
}
