using System;
using System.Collections;

class Opdracht1
{
    private static void VulStack(Stack<string> stapel, int aantal)
    {
        for (int i = 0; i < aantal; i++)
        {
            Console.WriteLine("Geef een waarde voor nummer 1: ");
            var num1 = Console.ReadLine();
            stapel.Push(num1);
            Console.WriteLine("Geef een waarde voor nummer 2: ");
            var num2 = Console.ReadLine();
            stapel.Push(num2);
            Console.WriteLine("Geef een waarde voor nummer 3: ");
            var num3 = Console.ReadLine();
            stapel.Push(num3);
        }

        Check(stapel);
    }

    public static void Check(Stack<string> stapel)
    {
        Console.WriteLine();
        Console.WriteLine("Geef een waarde die u wilt checken: ");
        var Check = Console.ReadLine();
        Console.WriteLine();
        var CheckStapel = stapel.Peek();

        if (stapel.Count > 1)
        {
            if (Check == CheckStapel)
            {
                Console.WriteLine("Deze waarde ligt bovenop in de stapel.");
                stapel.Pop();
                Console.WriteLine();
                PrintStack(stapel);
            }
            else if (stapel.Contains(Check))
            {
                Console.WriteLine("Deze waarde zit wel in de stack, maar ligt niet bovenop.");
                PrintStack(stapel);
            }
            else
            {
                Console.WriteLine("Deze waarde zit niet in de stack");
                PrintStack(stapel);
            }
        }
        else
        {
            Console.WriteLine("Stack is leeg man!");
            System.Environment.Exit(0);
        }
    }

    private static void PrintStack(Stack<string> stapel)
    {
        Console.WriteLine("De stack:");
        foreach (var item in stapel)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
        Check(stapel);
    }
    public static void Main(string[] args)
    {
        Stack<string> stapel = new Stack<string>();
        VulStack(stapel, 1);
    }
}