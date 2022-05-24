using System;

namespace method2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef een getal tussen 1 t/m 4:");
            string number = Console.ReadLine();
            GeefKaart(number);
        }
        private static string GeefKaart(string number)
        {
            int i = 1;

            do
            {
                switch (number)
                {
                    case "1":
                        Console.WriteLine("U heeft 1 gekozen. Dat is ruiten.");
                        break;
                    case "2":
                        Console.WriteLine("U heeft 2 gekozen. Dat is harten.");
                        break;
                    case "3":
                        Console.WriteLine("U heeft 3 gekozen. Dat is klaveren.");
                        break;
                    case "4":
                        Console.WriteLine("U heeft 4 gekozen. Dat is schoppen.");
                        break;
                    default:
                        Console.WriteLine("Kies een GETAL uit tussen 1 t/m 4!");
                        break;
                }
                return null;
            } while (i < 4);
        }
    }
}