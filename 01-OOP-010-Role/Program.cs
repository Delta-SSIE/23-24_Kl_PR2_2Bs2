namespace _01_OOP_010_Role
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Role role = new Role("Modrá", -150);
                Console.WriteLine(role);
            }
            catch
            {
                Console.WriteLine("Neplatná hodnota parametru.");
            }

            try
            {
                Role role = new Role("Modrá", 250);
                role.Delka -= 100;
                Console.WriteLine(role);
                role.Delka -= 300;
                Console.WriteLine(role);
            }
            catch
            {
                Console.WriteLine("Neplatná hodnota parametru.");
            }
        }
    }
}
