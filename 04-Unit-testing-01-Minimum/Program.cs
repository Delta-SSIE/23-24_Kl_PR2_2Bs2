namespace _04_Unit_testing_01_Minimum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = [6, 1, 3, 12, 4, 7, 2];
            Console.WriteLine(Tools.FindMin(nums));
        }

        static bool TestMin()
        {
            int[] nums = [6, 1, 3, 12, 4, 7, 2];
            if (Tools.FindMin(nums) == 1)
                return true;

            return false;
        }
    }
}
