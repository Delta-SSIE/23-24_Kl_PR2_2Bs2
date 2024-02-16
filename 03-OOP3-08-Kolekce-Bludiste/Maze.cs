using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Kolekce_02_Bludiste
{
    internal class Maze
    {
        public int Width { get; private set; }
        public int Height { get; private set; }
        private Coords _entrance;
        private TileType[,] _map;
        private MazeDisplay _display;

        public void LoadMaze(string filename)
        {
            using (StreamReader reader = new StreamReader(filename)) //načtu textový soubor
            {
                Width = int.Parse(reader.ReadLine()); //první řádek je šířka
                Height = int.Parse(reader.ReadLine()); //druhý řádek je výška
                
                _map = new TileType[Width, Height];

                string line;
                for (int y = 0; y < Height; y++) //projdu všechny řádky
                {
                    line = reader.ReadLine();
                    for (int x = 0; x < Width; x++) //projdu všechny sloupce
                    {
                        _map[x, y] = line[x] switch //uložím do mapy
                        {
                            '#' => TileType.Wall,
                            ' ' => TileType.Corridor,
                            'S' => TileType.Entrance,
                            'E' => TileType.Exit,
                        };
                        if (line[x] == 'S') //poznamenám si, kde je start
                            _entrance = new Coords(x, y);
                    }
                }                
            }
            _display = new MazeDisplay(1, 1, Width, Height); //připravím prostor pro kreslení, odsazený o 1 čtverec
            RenderMaze();
        }

        public void RenderMaze()
        {
            for (int x = 0; x < Width; x++)
            {
                for (int y = 0; y < Height; y++)
                {
                    _display.RenderTile(new Coords(x, y), _map[x, y]);
                }
            }
            _display.WrapUp();
        }

        public void Solve(IVisitList visitList)
        {
            //připrav si seznam míst k navštívení
            

            //začni na startu
            visitList.Add(_entrance);

            //dokud na seznamu něco je
            while (visitList.Count > 0) 
            {
                //vezmi prvního na seznamu
                Coords here = visitList.GetNext();

                //označ jako navštíveného - ale ne start a cíl
                if (_map[here.X, here.Y] == TileType.Listed)
                    _map[here.X, here.Y] = TileType.Visited;

                //když je to cíl, hurá skonči
                if (_map[here.X, here.Y] == TileType.Exit)
                {
                    return;
                }

                //jinak přidej na seznam všechny sousedy
                foreach(Coords neighbour in Neighbours(here))
                {
                    visitList.Add(neighbour);
                }

                RenderMaze();
                Console.ReadKey();
            }
        }

        private Coords[] Neighbours(Coords place)
        {
            //4 možní sousedé
            Coords[] candidates =
            {
                new Coords(place.X + 1, place.Y),
                new Coords(place.X - 1, place.Y),
                new Coords(place.X, place.Y + 1),
                new Coords(place.X, place.Y - 1),
            };

            //sem přijdou ti, kteří projdou testem
            List<Coords> result = new();

            //otestuju
            foreach(Coords c in candidates)
            {
                if 
                (
                    c.X >= 0 && c.X < Width
                    && c.Y >= 0 && c.Y < Height
                )
                {
                    TileType tileAtC = _map[c.X, c.Y];
                    if (tileAtC == TileType.Corridor || tileAtC == TileType.Exit)
                    { 
                        result.Add(c);

                        if (tileAtC == TileType.Corridor)
                            _map[c.X, c.Y] = TileType.Listed;
                    }
                }
            }

            return result.ToArray();
        }

    }
}
