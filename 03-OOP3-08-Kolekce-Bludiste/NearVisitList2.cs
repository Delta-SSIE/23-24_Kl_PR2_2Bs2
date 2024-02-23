using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace _03_Kolekce_02_Bludiste
{
    //má seznam míst setříděný - nejbližší na konec
    internal class NearVisitList2 : NearVisitList
    {
        private Dictionary<Coords, double> _distances = new();

        public NearVisitList2(Coords exit) : base(exit)
        {
        }

        public override void Add(Coords place)
        {
            double dist = GetDistance(place);
            _distances[place] = dist;

            if (_places.Count == 0)
            {
                _places.Add(place);
                return;
            }


            double otherDist;

            for (int i = 0; i < _places.Count; i++)
            {
                //otherDist = GetDistance(_places[i]);
                
                if (_distances[_places[i]] < dist)
                {
                    _places.Insert(i, place);
                    return;
                }
            }

            _places.Add(place);
        }

        //vrátím poslední - je nejbližší
        public override Coords GetNext()
        {
            Coords result = _places[_places.Count - 1];
            _places.RemoveAt(_places.Count - 1);
            return result;
        }
    }
}
