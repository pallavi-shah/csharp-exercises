using System;

namespace Area
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a radius: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            while (radius <= 0)
            {
                Console.WriteLine("\nError: Radius must be Greater Than Zero: ");
                Console.Write("\nEnter radius of the circle: ");
                radius = Convert.ToSingle(Console.ReadLine());
            }
            double Area = 3.14 * Math.Pow(radius, 2);
            Console.WriteLine($"\n The area of a circle with radius {radius} is : " + Area);
        }
    }
}