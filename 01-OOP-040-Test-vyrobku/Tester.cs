using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace _01_OOP_040_Test_vyrobku
{
    internal class Tester
    {
		private double _tolerance;

		/// <summary>
		/// Kladná hodnota tolerance shody výrobku v procentech
		/// </summary>
		public double Tolerance
		{
			get { return _tolerance; }
			set		
			{
				if (value < 0)
					throw new ArgumentOutOfRangeException();
				
				_tolerance = value; 
			}
		}

		private Vyrobek _vzor;

		public Vyrobek Vzor
		{
			get { return _vzor; }
			set 
			{
				if (value == null)
					throw new ArgumentNullException();

				_vzor = value; 
			}
		}

        public Tester(Vyrobek vzor, double tolerance)
        {
            Tolerance = tolerance;
            Vzor = vzor;
        }

		public bool Vyhovuje(Vyrobek vyrobek)
		{
			double odchylka = Math.Abs(vyrobek.Rozmer - Vzor.Rozmer);
			double odchylkaVProcentech = odchylka / Vzor.Rozmer * 100;
			
			if (odchylkaVProcentech > Tolerance)
				return false;
			else
				return true;
		}
    }
}
