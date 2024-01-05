namespace _02_OOP_050_IComparable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Auto[] autos =
            {
                new Auto("Kára", 50),
                new Auto("Kraksna", 65),
                new Auto("Spídr", 250),
            };

            Array.Sort(autos);

            foreach (Auto auto in autos)
            {
                Console.WriteLine($"{auto.Name} : {auto.Speed}");
            }

            if (autos[0] > autos[1])
                //...
        }
    }

    class Auto : IComparable
    {
        public string Name { get; set; }
        public int Speed { get; set; }

        public Auto(string name, int speed)
        {
            Name = name;
            Speed = speed;
        }

        //public int CompareTo(object? obj)
        //{
        //    if (obj == null)
        //        return -1;

        //    if (obj is Auto otherCar)
        //        return Speed.CompareTo(otherCar.Speed);

        //    else
        //        throw new ArgumentException("Can only compare autos");            
        //}

        public int CompareTo(object? obj)
        {
            if (obj == null)
                return -1;

            //Auto otherCar = obj as Auto;
            //if (otherCar == null)
            //    throw new ArgumentException("Can only compare autos");

            //return this.Speed - otherCar.Speed;

            if (obj is Auto otherCar)
                return this.Speed - otherCar.Speed;

            else
                throw new ArgumentException("Can only compare autos");

            //if (this.Speed < otherCar.Speed)
            //    return -1;
            //else if (this.Speed == otherCar.Speed)
            //    return 0;
            //else
            //    return 1;

        }

        public static bool operator >(Auto auto1, Auto auto2)
        {
            return auto1.Speed > auto2.Speed;
        }
        public static bool operator <(Auto auto1, Auto auto2)
        {
            return auto1.Speed < auto2.Speed;
        }
        public static bool operator >=(Auto auto1, Auto auto2)
        {
            return auto1.Speed > auto2.Speed;
        }
        public static bool operator <=(Auto auto1, Auto auto2)
        {
            return auto1.Speed < auto2.Speed;
        }
        public static bool operator ==(Auto auto1, Auto auto2)
        {
            return auto1.Speed == auto2.Speed;
        }
        public static bool operator !=(Auto auto1, Auto auto2)
        {
            return auto1.Speed != auto2.Speed;
        }
    }
}
