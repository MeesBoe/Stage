using System;

class method1
{
    static void Main(string[] args)
    {
        Console.WriteLine("Vul een nummer voor nummer 1 in:");
        var getal1 = Console.ReadLine();

        Console.WriteLine("Vul een nummer voor nummer 2 in:");
        var getal2 = Console.ReadLine();

        int number1 = Int32.Parse(getal1);
        int number2 = Int32.Parse(getal2);

        int numbercheck = Leesgeheelgetal(number1);
        int som = Som(numbercheck, number2);
        int verschil = Verschil(numbercheck, number2);
        int product = Product(numbercheck, number2);

        Console.WriteLine("De som van " + numbercheck + " en " + number2 + " = " + som);
        Console.WriteLine("Het verschil van " + numbercheck + " en " + number2 + " = " + verschil);
        Console.WriteLine("Het product van " + numbercheck + " en " + number2 + " = " + product);
    }
    private static int Leesgeheelgetal(int input)
    {
        return input;
    }
    private static int Som(int getal1, int getal2)
    {
        return getal1 + getal2;
    }
    private static int Verschil(int getal1, int getal2)
    {
        return getal1 - getal2;
    }
    private static int Product(int getal1, int getal2)
    {
        return (getal1 * getal2);
    }
}