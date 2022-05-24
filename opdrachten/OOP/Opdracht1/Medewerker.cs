using Personen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medewerkers
{
    public class Medewerker : Persoon
    {
        public Medewerker(string voornaam, string achternaam, string rol) : base(voornaam, achternaam)
        {
            Rol = rol;
        }
        public string Rol { get; set; }
        public override string WieBenIk()
        {
            var wieBenIk = base.WieBenIk();
            return $"{wieBenIk} Mijn rol is {Rol}.";
            Console.WriteLine(WieBenIk);
        }
    }
}
