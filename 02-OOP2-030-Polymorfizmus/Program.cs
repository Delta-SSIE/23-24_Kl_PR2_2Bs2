namespace _02_OOP2_030_Polymorfizmus
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

        public virtual void PredstavSe() //virtuální = vhodná k předefinování dědící třídou
        {
            Console.WriteLine($"Já jsem savec a jmenuju se {Jmeno}");
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

        public override void PredstavSe()
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
        public override void PredstavSe()
        {
            Console.WriteLine($"Já jsem velryba a jmenuju se {Jmeno}");
        }
    }
}
