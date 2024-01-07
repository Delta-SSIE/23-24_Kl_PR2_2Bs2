using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_OOP2_cv_070_Body
{
    class Bod : IComparable
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Bod(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        public override string ToString()
        {
            return string.Format("Bod [{0};{1}]", this.X, this.Y);
        }

        public double VzdalenostOdStredu()
        {
            return Math.Sqrt(this.X * this.X + this.Y * this.Y);
        }

        public int CompareTo(object? obj)
        {
            if (obj is Bod druhyBod) //převedu typ
            { 
                //if (druhyBod.VzdalenostOdStredu() < this.VzdalenostOdStredu())
                //    return 1;
                //else if (druhyBod.VzdalenostOdStredu() == this.VzdalenostOdStredu())
                //    return 0;
                //else return -1;

                return this.VzdalenostOdStredu().CompareTo(druhyBod.VzdalenostOdStredu());
                //return Math.Sign( this.VzdalenostOdStredu() - druhyBod.VzdalenostOdStredu() );

            }

            throw new Exception("Incomaparable objects");


        }
    }
}
