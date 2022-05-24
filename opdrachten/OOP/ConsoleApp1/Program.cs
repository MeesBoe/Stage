using Personen;
using Medewerkers;
using Managers;
using System;
using System.Collections.Generic;
using static System.Console;

namespace OOPopdracht2
{
    public class Program
    {
        private static List<Persoon> personen;
        private static List<Medewerker> medewerkers;
        private static List<Manager> managers;
        static void Main(string[] args)
        {
            Invullen();
            PersonenWeergeven();
        }
        private static void Invullen()
        {
            personen = new List<Persoon>();
            medewerkers = new List<Medewerker>();
            managers = new List<Manager>();

            Persoon persoon1 = new Persoon("Mees", "Boerman");
            personen.Add( persoon1 );

            Persoon persoon2 = new Persoon("Mitch", "Koomen");
            personen.Add( persoon2 );

            Medewerker medewerker1 = new Medewerker("Mees", "Boerman", "Student");
            medewerkers.Add(medewerker1);

            Medewerker medewerker2 = new Medewerker("Mitch", "Koomen", "Student");
            medewerkers.Add(medewerker2);

            Manager manager1 = new Manager("Mees", "Boerman", "Manager", "Bijzaken");
            managers.Add(manager1);

            Manager manager2 = new Manager("Mitch", "Koomen", "Manager", "Financiën");
            managers.Add(manager2);
        }
        private static void PersonenWeergeven()
        {
            foreach (Persoon persoon in personen)
            {
                Console.WriteLine(persoon.WieBenIk());
            }
            Console.WriteLine();
            foreach (Medewerker medewerker in medewerkers)
            {
                Console.WriteLine(medewerker.WieBenIk());
            }
            Console.WriteLine();
            foreach (Manager manager in managers)
            {
                Console.WriteLine(manager.WieBenIk());
            }
        }
    }
}