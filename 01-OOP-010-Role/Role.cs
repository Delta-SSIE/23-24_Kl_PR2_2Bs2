using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_OOP_010_Role
{
    internal class Role
    {
        public string Barva;

        private double _delka;

        public double Delka
        {
            get { return _delka; }
            set 
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException();
                _delka = value; 
            }
        }


        public Role(string barva, double delka)
        {
            Barva = barva;
            Delka = delka;
        }

        public override string ToString()
        {
            return $"Role papíru, barva {Barva}, zbývá {Delka} cm";
        }
    }
}
