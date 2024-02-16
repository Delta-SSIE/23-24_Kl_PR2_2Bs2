using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Kolekce_02_Bludiste
{
    internal class RandomVisitList : IVisitList
    {
        List<Coords> _list = new();
        static Random _random = new();

        public int Count => _list.Count;

        public void Add(Coords place)
        {
            _list.Add(place);
        }

        public Coords GetNext()
        {
            int randomIndex = _random.Next(_list.Count);
            Coords place = _list[randomIndex];
            _list.RemoveAt(randomIndex);
            return place;
        }
    }
}
