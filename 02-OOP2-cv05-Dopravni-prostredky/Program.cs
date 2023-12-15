namespace _02_OOP2_cv_05_Dopravni_prostredky
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ElektroAuto mobil = new ElektroAuto(80, 4);
            Bicykl kolo = new Bicykl(65);
            Popelnice kontejner = new Popelnice(4);

            IPojizdny[] pojizdneVeci =
            {
                mobil,
                kolo,
                kontejner
            };

            int pocetKol = SpocitejKola(pojizdneVeci);
            Console.WriteLine($"Celkem je tu {pocetKol} koleček.");

        }

        private static int SpocitejKola(IPojizdny[] pojizdneVeci)
        {
            int pocetKol = 0;
            foreach (IPojizdny jezditko in pojizdneVeci)
            {
                pocetKol += jezditko.PocetKol;
            }

            return pocetKol;
        }
    }
}
