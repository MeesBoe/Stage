using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Collections
{

    class Program
    {
        private static Dictionary<String, Double> _voertuigenlijst;
        private static Queue<string> _file;


        public static void Main(string[] args)
        {
            Initialiseer();
            Simuleer();
        }
        private static void Initialiseer()
        {
            _voertuigenlijst = new Dictionary<string, double>();

            _voertuigenlijst.Add("Mini", 2.1);
            _voertuigenlijst.Add("Tesla model S", 2.8);
            _voertuigenlijst.Add("Ford S max", 2.8);
            _voertuigenlijst.Add("Camper", 6);

            _file = new Queue<string>();
        }
        private static void Simuleer()
        {
            bool juisteKeuze = false;
            var WhileLoop = true;
            do
            {
                string keuze = Haalkeuze();

                switch (keuze)
                {
                    case "toevoegen":
                        Console.WriteLine();
                        voegToe();
                        WhileLoop = false;
                        break;
                    case "verwijderen":
                        Console.WriteLine();
                        Verwijderen();
                        WhileLoop = false;
                        break;
                    case "stoppen":
                        Console.WriteLine();
                        Stoppen();
                        WhileLoop = false;
                        break;
                }
            } while (WhileLoop);
        }
        private static string Haalkeuze()
        {
            Console.Write("Wilt u toevoegen, verwijderen of stoppen? ");
            var haalKeuze = Console.ReadLine();
            return haalKeuze;
        }
        private static string HaalVoertuig()
        {
            Console.Write("Welk voertuig wilt u toevoegen? ");
            string voertuigT = Console.ReadLine();

            PrintFileGegevens();
            Simuleer();

            return voertuigT;
        }
        private static void voegToe()
        {
            Printvoertuigen();
            Console.WriteLine();
            bool juisteKeuze = false;
            var Loop = true;
            
            do
            {
                Console.Write("Noem een voertuig uit de lijst die u wilt toevoegen: ");
                string keuze = Console.ReadLine();
                switch (keuze)
                {
                    case "Mini":
                        Console.WriteLine();
                        _file.Enqueue("Mini");
                        Console.WriteLine("Mini in de file gezet");
                        Console.WriteLine();
                        PrintFileGegevens();
                        Simuleer();
                        Loop = false;
                        break;
                    case "Tesla model S":
                        Console.WriteLine();
                        _file.Enqueue("Tesla model S");
                        Console.WriteLine("Tesla in de file gezet");
                        Console.WriteLine();
                        PrintFileGegevens();
                        Simuleer();
                        Loop = false;
                        break;
                    case "Ford S max":
                        Console.WriteLine();
                        _file.Enqueue("Ford S max");
                        Console.WriteLine("Ford in de file gezet");
                        Console.WriteLine();
                        PrintFileGegevens();
                        Simuleer();
                        Loop = false;
                        break;
                    case "Camper":
                        Console.WriteLine();
                        _file.Enqueue("Camper");
                        Console.WriteLine("Camper in de file gezet");
                        Console.WriteLine();
                        PrintFileGegevens();
                        Simuleer();
                        Loop = false;
                        break;
                }
            } while (Loop);
            HaalVoertuig();
        }
        private static void Verwijderen()
        {
            Console.WriteLine("");
            Printvoertuigen();
            var Peek1 = _file.Peek();
            _file.Dequeue();
            Console.WriteLine("Dit voertuig is verwijderd: " + Peek1);
            Console.WriteLine();

            PrintFileGegevens();
            Simuleer();
        }
        private static void Printvoertuigen()
        {
            Console.WriteLine("De voertuigen: ");
            _voertuigenlijst.ToList().ForEach(x => Console.WriteLine(x.Key));
        }
        private static void PrintFileGegevens()
        {
            foreach (var obj in _file)
            {
                Console.Write("[ " + obj + " ]");
            }
            Console.WriteLine("" + "");
            Console.Write("De lengte van de file is ");
            double sum = 0;

            foreach (var item in _file)
            {
                sum += _voertuigenlijst[item];
            }
            Console.WriteLine(sum);
            Console.WriteLine();
        }
        private static void Stoppen()
        {
            Environment.Exit(0);
        }
    }
}