using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_OOP_cv_060_UtvaryIface
{
    internal class Ctverec : IUtvar
    {
        public double Strana { get; private set; }

        string IUtvar.Nazev => "čtverec";

        public Ctverec(double strana)
        {
            Strana = strana;
        }

        public double GetObvod()
        {
            return Strana * 4;
        }

        public double GetObsah()
        {
            return Strana * Strana;
        }

        public override string ToString()
        {
            return $"čtverec o straně {Strana} cm";
        }
    }
}
