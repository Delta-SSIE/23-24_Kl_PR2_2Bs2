using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Unit_testing_01_Minimum
{
    public class Tools
    {
        public static int FindMin(int[] numbers)
        {
            if (numbers.Length == 0)
                throw new EmptyArrayException("Empty dataset");

            int min = int.MaxValue;
            foreach (int num in numbers)
            {
                if (min > num)
                    min = num;
            }
            return min;
        }

        public static (bool hasMinimum, int minValue) SafeFindMin(int[] numbers)
        {
            if (numbers.Length == 0)
                return (false, 0);

            int min = int.MaxValue;
            foreach (int num in numbers)
            {
                if (min > num)
                    min = num;
            }
            return (true, min);
        }
    }
}
