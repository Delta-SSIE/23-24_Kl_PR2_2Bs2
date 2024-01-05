using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_OOP_cv_060_UtvaryIface
{
    internal interface IUtvar
    {
        string Nazev { get; }
        double GetObvod();
        double GetObsah();

    }
}
