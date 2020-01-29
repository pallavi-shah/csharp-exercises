using System;

namespace MilesPerGallon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of Miles driven: ");
            double miles = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter amount of Gas consumed: ");
            double gasConsumed = Convert.ToDouble(Console.ReadLine());
            double milesPerGallon = miles / gasConsumed;
            Console.WriteLine("Miles Per Gallon= "+ milesPerGallon);
        }
    }
}
