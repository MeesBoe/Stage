namespace Personen
{
    public class Persoon
    {
        public Persoon(string voornaam, string achternaam)
        {
            Voornaam = voornaam;
            Achternaam = achternaam;
        }
        public string Voornaam { get; set; }
        public string Achternaam { get; set; }

        private DateOnly _geboorteDatum;
        public DateOnly Geboortedatum
        { 
            get { return _geboorteDatum; }
            private set { _geboorteDatum = value; }
        }

        private string _geslacht;
        public string Geslacht
        {
            get { return _geslacht; }
            set { _geslacht = value; }
        }

        private int _lengte;
        public int Lengte
        {
            get
            {
                return _lengte;
            }
            set
            {
                if (value > 30)
                {
                    _lengte = value;
                }
                else
                {
                    Console.WriteLine("Voor een getal boven 30 in.");
                }
            }
        }
        private double _gewicht;
        public double Gewicht
        {
            get
            {
                return _gewicht;
            }
            set
            {
                if (value > 1.5)
                {
                    if (value < 321.6)
                    {
                        _gewicht = value;
                    }
                }
                else
                {
                    Console.WriteLine("Voer een getal tussen de 1,5 en 321,6 in.");
                }
            }
        }
        public virtual string WieBenIk()
        {
            return $"Ik ben {Voornaam} {Achternaam}, en ik ben geboren op {Geboortedatum}.";
        }
    }
}
