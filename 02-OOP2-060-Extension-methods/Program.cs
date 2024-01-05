namespace _02_OOP2_060_Extension_methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Math math = new Math(); //nelze - je statická
            int cislo = 10;
            if (cislo.IsEven())
                Console.WriteLine("Číslo je sudé");

            Console.WriteLine(cislo.InverseValue());

            if (cislo.IsInInterval(5, 12))
                Console.WriteLine("Číslo se vejde do intervalu");
        }
    }

    static class Utils
    {
        public static bool IsEven(this int num)
        {
            return num % 2 == 0;
        }

        public static int InverseValue(this int num)
        {
            return -num;
        }

        public static bool IsInInterval(this int num, int minValue, int maxValue)
        {
            return num >= minValue && num <= maxValue;
        }
    }
}
