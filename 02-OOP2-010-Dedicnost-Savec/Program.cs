namespace _02_OOP2_010_Dedicnost_Savec
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kun konik = new Kun();
            konik.Dychej();
            konik.Saj();
            konik.Cvalej();

            Console.WriteLine();

            Hribe prcek = new Hribe();
            prcek.Dychej(); //i odvozena trida ma pristup ke vsemu z nadrazenych trid

            Console.WriteLine();

            Velryba mobyDick = new Velryba();
            mobyDick.Dychej();
            mobyDick.Saj();
            mobyDick.Plav();
            //mobyDick.Cvalej(); //Velrybu cválat nenaučíš ... není to kůň

            Console.WriteLine();

            Savec kobyla = new Kun();
            kobyla.Dychej();
            //kobyla.Cvalej(); //nelze, je uloženo v proměnné "typu Savec"

            Kun kobylaJinak = (Kun)kobyla; //type casting - přetypování. "Dívej se na proměnnou kobyla jako na typ Kun"
            kobylaJinak.Cvalej();

            Savec bobby = new Velryba();
            //Kun hybrid = (Kun)bobby; //nelze - velryba není kůň
            //hybrid.Cvalej();

            

        }
    }
    class Savec
    {
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
        public void Cvalej()
        {
            Console.WriteLine("Klapy klap ... ");
        }
    }
    class Hribe : Kun {}
    class Velryba : Savec
    {
        public void Plav()
        {
            Console.WriteLine("Šplouchy, Šplouch...");
        }
    }
}
