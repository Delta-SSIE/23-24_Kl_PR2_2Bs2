namespace _03_OOP3_06_Hanojska_vez
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tower tower = new Tower(5);
            //tower.Render();

            //tower.Move(0, 2);
            //tower.Move(0, 1);
            //tower.Move(2, 1);
            //tower.Move(0, 2);

            //Console.WriteLine();
            //tower.Render();


            //tower.Render();
            //Console.WriteLine();

            //tower.Move(0, 2);
            //tower.Render();
            //Console.WriteLine();

            //tower.Move(0, 1);
            //tower.Render();
            //Console.WriteLine();

            //tower.Move(2, 1);
            //tower.Render();
            //Console.WriteLine();

            //tower.Move(0, 2);
            //tower.Render();


            tower.Render();
            tower.MoveDiscs(0, 2, tower.Size);
            tower.Render();


        }
    }
}
