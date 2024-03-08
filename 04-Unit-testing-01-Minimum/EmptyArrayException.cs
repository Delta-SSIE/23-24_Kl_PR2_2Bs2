using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Unit_testing_01_Minimum
{
    public class EmptyArrayException : Exception
    {
        public EmptyArrayException(string? message) : base(message)
        {
        }
    }
}
