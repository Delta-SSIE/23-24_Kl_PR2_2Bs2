using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _02_OOP_cv_060_UtvaryIface
{
    internal class Kruh : IUtvar
    {
        public double Polomer { get; private set; }

        public string Nazev => "kruh";

        public Kruh(double polomer)
        {
            Polomer = polomer;
        }

        public double GetObvod()
        {
            return 2 * Math.PI * Polomer;
        }

        public double GetObsah()
        {
            return Math.PI * Polomer * Polomer;
        }
        public override string ToString()
        {
            return $"kruh o poloměru {Polomer} cm";
        }
    }
}
