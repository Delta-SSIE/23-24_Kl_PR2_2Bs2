namespace _02_OOP2_040_Abstrakce
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kun konik = new Kun("Ferda");
            //konik.Dychej();
            //konik.Saj();
            //konik.Cvalej();

            //Console.WriteLine();


            //Velryba mobyDick = new Velryba("Moby Dick");
            //mobyDick.Dychej();
            //mobyDick.Saj();
            //mobyDick.Plav();
            ////mobyDick.Cvalej(); //Velrybu cválat nenaučíš ... není to kůň

            //Console.WriteLine();

            //Savec kobyla = new Kun("Hátátitlá");
            //kobyla.Dychej();
            ////kobyla.Cvalej(); //nelze, je uloženo v proměnné "typu Savec"

            //Kun kobylaJinak = (Kun)kobyla; //type casting - přetypování. "Dívej se na proměnnou kobyla jako na typ Kun"
            //kobylaJinak.Cvalej();

            //Savec bobby = new Velryba("Bobby");
            ////Kun hybrid = (Kun)bobby; //nelze - velryba není kůň
            ////hybrid.Cvalej();

            Savec[] zvirata = {
                new Kun("Ferda"),
                new Kun("Hátátitlá"),
                new Velryba("Moby Dick")
            };

            foreach (Savec zvire in zvirata)
            {
                zvire.PredstavSe();
            }


            //Savec krava = new Savec("Stračena");

        }
    }
    abstract class Savec
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

        public abstract void PredstavSe(); //neříkám jak, ale nařizuju, že každý savec se musí umět představit
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

        public override void PredstavSe() //override používáme i pro přepis abstraktní i virtuální metody
        {
            Console.WriteLine($"Já jsem kůň a jmenuju se {Jmeno}");
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
        public sealed override void PredstavSe()
        {
            Console.WriteLine($"Já jsem velryba a jmenuju se {Jmeno}");
        }
    }
    class Krava : Savec
    {
        public Krava(string jmeno) : base(jmeno)
        {
        }

        public override void PredstavSe()
        {
            Console.WriteLine($"Já jsem kráva a neumím mluvit. Bů!");
        }
    }

    class Vorvan : Velryba
    {
        public Vorvan(string jmeno) : base(jmeno)
        {
        }
        //public override void PredstavSe() //nelze - PredstavSe je uz sealed
        //{
        //    Console.WriteLine($"Já jsem ...");
        //}
    }
}
