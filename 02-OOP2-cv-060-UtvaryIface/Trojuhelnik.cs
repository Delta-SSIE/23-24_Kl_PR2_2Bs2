using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_OOP_cv_060_UtvaryIface
{
    internal class Trojuhelnik : IUtvar
    {
        public double Strana1 { get; private set; }
        public double Strana2 { get; private set; }
        public double Strana3 { get; private set; }

        public string Nazev => "trojúhelník";

        public Trojuhelnik(double strana1, double strana2, double strana3)
        {
            Strana1 = strana1;
            Strana2 = strana2;
            Strana3 = strana3;
        }

        public double GetObvod()
        {
            return Strana1 + Strana2 + Strana3;
        }

        public double GetObsah()
        {
            double s = GetObvod() / 2;
            return Math.Sqrt(s * (s - Strana1) * (s - Strana2) * (s - Strana3));
        }
        public override string ToString()
        {
            return $"trojúhelník o stranách {Strana1} cm, {Strana2} cm a {Strana3} cm";
        }
    }
}
