using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Kolekce_02_Bludiste
{
    internal class NearVisitList : IVisitList
    {
        protected List<Coords> _places = new();
        private Coords _exit;

        public int Count => _places.Count;

        public NearVisitList(Coords exit)
        {
            _exit = exit;
        }

        public virtual void Add(Coords place)
        {
            _places.Add(place);
        }

        public virtual Coords GetNext()
        {
            int minIndex = 0;
            double minDist = GetDistance(_places[0]);

            //projdi vše, když najdeš menší, ulož si
            for (int i = 1; i < _places.Count; i++)
            {
                double dist = GetDistance(_places[i]);
                if (dist < minDist)
                {
                    minDist = dist;
                    minIndex = i;
                }
            }

            Coords result = _places[minIndex];
            _places.RemoveAt(minIndex);
            return result;

        }

        protected double GetDistance(Coords place)
        {
            int dx = place.X - _exit.X;
            int dy = place.Y - _exit.Y;
            return Math.Sqrt(dx * dx + dy * dy);
            //return Math.Abs(dx) + Math.Abs(dy);
        }
    }
}
