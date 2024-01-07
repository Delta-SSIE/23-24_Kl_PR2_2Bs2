namespace _02_OOP_cv_060_UtvaryIface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Trojuhelnik t = new Trojuhelnik(3, 4, 5);
            //Console.WriteLine(t.GetObsah());
            Kruh k = new Kruh(2);
            Ctverec c = new Ctverec(5);
           

            IUtvar[] utvary = { t, c, k };
            foreach (IUtvar utvar in utvary)
            {
                Console.WriteLine(utvar.Nazev);
            }

            PlechovkaBarvy plechovka = new PlechovkaBarvy(50, 2);
            
            Console.WriteLine(plechovka);
            
            foreach (IUtvar utvar in utvary)
            {
                Console.WriteLine(utvar);
                Console.WriteLine(plechovka.Obarvi(utvar));
                Console.WriteLine(plechovka);

            }
        }
    }
}
