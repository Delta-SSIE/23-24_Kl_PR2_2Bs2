namespace _02_OOP2_030_Obdelnik_a_ctverec
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Obdelnik abcd = new Obdelnik(3, 5);
            Console.WriteLine(abcd);
            Console.WriteLine($"Opsach obdélňýka abcd je {abcd.Obsah()} a obvot je {abcd.Obvod()}.");

            Ctverec efgh = new Ctverec(4);
            Console.WriteLine(efgh);
            Console.WriteLine($"Opsach štverce abcd je {efgh.Obsah()} a obvot je {efgh.Obvod()}.");
        }
    }
    class Obdelnik
    {
        public double StranaA { get; private set; }
        public double StranaB { get; private set; }

        public Obdelnik(double stranaA, double stranaB)
        {
            if (stranaA < 0)
                throw new ArgumentException();
            StranaA = stranaA;

            if (stranaB < 0)
                throw new ArgumentException();
            StranaB = stranaB;
        }
        public double Obvod()
        {
            return 2 * (StranaA + StranaB);
        }
        public double Obsah()
        {
            return StranaA * StranaB;
        }
        public override string ToString()
        {
            return base.ToString();
            return $"Obdélník o stranách {StranaA} a {StranaB}.";
        }
    }
    class Ctverec : Obdelnik
    {
        public Ctverec(double strana) : base(strana, strana)
        {
        }

        public override string ToString()
        {
            return $"Čtverec o straně {StranaA}.";
        }
    }
}
