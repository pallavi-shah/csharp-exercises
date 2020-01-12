using System;

namespace Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius = 0;
            do
            {
                Console.Write("Enter a radius: ");
                string strRadius = Console.ReadLine();
                if (strRadius == "")
                {
                    break;
                }
                else
                {
                    try
                    {
                        radius = Double.Parse(strRadius);
                    }
                    catch
                    {
                        Console.WriteLine("Error: Radius must be a number.");
                        break;
                    }
                }
                if (radius<0)
                {
                    Console.WriteLine("\nError: Radius must be Greater Than Zero: ");
                    break;
                }
                else
                {
                    double Area = 3.14 * Math.Pow(radius, 2);
                    Console.WriteLine($"\n The area of a circle with radius {radius} is : " + Area);
                }
            }
            while (radius<0);
            Console.ReadLine();
        }
    }
}