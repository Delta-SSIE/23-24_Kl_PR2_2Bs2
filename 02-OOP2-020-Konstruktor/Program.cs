namespace _02_OOP2_020_Konstruktor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kun konik = new Kun("Ferda");
            konik.Dychej();
            konik.Saj();
            konik.Cvalej();

            Console.WriteLine();


            Velryba mobyDick = new Velryba("Moby Dick");
            mobyDick.Dychej();
            mobyDick.Saj();
            mobyDick.Plav();
            //mobyDick.Cvalej(); //Velrybu cválat nenaučíš ... není to kůň

            Console.WriteLine();

            Savec kobyla = new Kun("Hátátitlá");
            kobyla.Dychej();
            //kobyla.Cvalej(); //nelze, je uloženo v proměnné "typu Savec"

            Kun kobylaJinak = (Kun)kobyla; //type casting - přetypování. "Dívej se na proměnnou kobyla jako na typ Kun"
            kobylaJinak.Cvalej();

            Savec bobby = new Velryba("Bobby");
            //Kun hybrid = (Kun)bobby; //nelze - velryba není kůň
            //hybrid.Cvalej();



        }
    }
    class Savec
    {
        public string Jmeno { get; protected set; }

        public Savec(string jmeno)
        {
            Jmeno = jmeno;
        }

        public void Dychej()
        {
            Console.WriteLine("Nádech ... Výdech ... Vzdech ...");
        }

        public void Saj()
        {
            Console.WriteLine("Sssssssssssss....");
        }
    }
    class Kun : Savec
    {
        public Kun(string jmeno) : base(jmeno)
        {
            Console.WriteLine($"Narodil se nový kůň, jmenuje se {Jmeno}.");
        }

        public void Cvalej()
        {
            Console.WriteLine("Klapy klap ... ");
        }
    }

    class Velryba : Savec
    {
        public Velryba(string jmeno) : base(jmeno)
        {
        }

        public void Plav()
        {
            Console.WriteLine("Šplouchy, Šplouch...");
        }
    }
}
