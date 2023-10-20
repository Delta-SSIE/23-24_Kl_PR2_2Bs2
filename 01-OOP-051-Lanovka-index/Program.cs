namespace _01_OOP_051_Lanovka_index
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lanovka lanovka = new Lanovka(4, 250);
            Clovek franta = new Clovek("Franta", 85);
            Clovek lojza = new Clovek("Lojza", 120);
            Clovek ance = new Clovek("Anče", 50);

            Console.WriteLine(lanovka.Nastup(franta));
            Console.WriteLine(lanovka.Nastup(lojza)); //nepovede se, je tam plno
            lanovka.Jed();

            Console.WriteLine(lanovka.Nastup(lojza)); //teď už se vejde

            lanovka.Jed();

            Console.WriteLine(lanovka.Nastup(ance)); //anče váží příliš mnoho, lanovka ji neunese

            lanovka.Jed();
            //lanovka.Jed(); //chyba, franta nevystoupil, nelze jet

            Clovek vystoupil;

            vystoupil = lanovka.Vystup();
            Console.WriteLine(vystoupil.Jmeno);

            Console.WriteLine(lanovka.Nastup(ance)); //anče už se vejde

            lanovka.Jed();
            vystoupil = lanovka.Vystup();
            Console.WriteLine(vystoupil.Jmeno);
        }
    }
}
