using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_OOP_cv_060_UtvaryIface
{
    internal class PlechovkaBarvy
    {
        /// <summary>
        /// kolik je tam mililitrů
        /// </summary>
        public double Objem { get; private set; }
        /// <summary>
        /// kolik mililitrů je třeba na 1 cm2
        /// </summary>
        public double Vydatnost { get; private set; }

        public PlechovkaBarvy(double objem, double vydatnost)
        {
            Objem = objem;
            Vydatnost = vydatnost;
        }

        public override string ToString()
        {
            return $"Plechovka barvy, zbývá ještě na {Objem  / Vydatnost}";
        }
        public bool Obarvi(IUtvar utvar)
        {
            double spotreba = utvar.GetObsah() * Vydatnost;
            if (spotreba <= Objem)
            {
                Objem -= spotreba;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
