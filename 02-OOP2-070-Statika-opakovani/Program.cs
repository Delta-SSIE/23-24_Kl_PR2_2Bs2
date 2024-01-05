namespace _02_OOP2_070_Statika_opakovani
{
    class Clovek 
    {
        public static int Pocet { get; private set; } = 0; //sdílená mezi všemi instancemi, i pro třídu zvenku
        public Clovek()
        {
            Pocet++;
        }

        public static void Popis() 
        { 
            Console.WriteLine("Lidé jsou humaniodní rasa, ne nepodobná gorilám, vyznačují se ale nižší inteligencí, fyzickou silou i celkovou odolností.Nejsou také schopni artikulované řeči."); 
        } 


    }

    class Program 
    {

        static void Main(string[] args) 
        { 
            Clovek.Popis();

            Console.WriteLine($"Na světě je {Clovek.Pocet} lidí.");
            Clovek franta = new Clovek();

            Console.WriteLine($"Na světě je {Clovek.Pocet} lidí.");
            Clovek lojza = new Clovek();

            Console.WriteLine($"Na světě je {Clovek.Pocet} lidí.");
            Clovek karel = new Clovek();

            Console.WriteLine($"Na světě je {Clovek.Pocet} lidí.");

            //franta.Popis(); //nelze, metoda je statická
        }
    }

}
