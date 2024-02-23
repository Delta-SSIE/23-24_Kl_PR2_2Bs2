namespace _03_Kolekce_02_Bludiste
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Maze maze = new Maze();
            //maze.LoadMaze("maze.txt");
            maze.LoadMaze("emptymaze.txt");

            //IVisitList list = new StackVisitList();
            //IVisitList list = new QueueVisitList();

            IVisitList list = new NearVisitList2(maze.Exit);

            maze.Solve(list);
        }
    }
}
