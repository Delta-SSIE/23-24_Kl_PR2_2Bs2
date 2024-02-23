using System.Diagnostics;

namespace _03_OOP3_09_LIst_a_linked_list
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 100_000;

            List<int> cisla = new();

            Stopwatch stopwatch = new();
            stopwatch.Start();

            for (int i = 0; i < count; i++)
            {
                cisla.Insert(0, i);
            }

            stopwatch.Stop();


            Console.WriteLine( "Vkládání");

            Console.WriteLine(stopwatch.ElapsedMilliseconds);


            LinkedList<int> cisla2 = new();

            stopwatch.Restart();

            for (int i = 0; i < count; i++)
            {
                cisla2.AddFirst(i);
            }

            stopwatch.Stop();

            Console.WriteLine(stopwatch.ElapsedMilliseconds);


            Console.WriteLine("Jdi doprostřed");

            int cislo;
            int midIndex = count / 2;

            stopwatch.Restart();


            for (int i = 0; i < count; i++)
            {
                cislo = cisla[midIndex];
            }

            stopwatch.Stop();
            Console.WriteLine(stopwatch.ElapsedTicks);


            stopwatch.Restart();

            for (int i = 0; i < count; i++)
            {
                LinkedListNode<int> current = cisla2.First;
                for (int j = 0; j < midIndex; j++)
                {
                    current = current.Next;
                }
            }

            stopwatch.Stop();
            Console.WriteLine(stopwatch.ElapsedTicks);
        }
    }
}
