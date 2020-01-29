using System;

namespace AreaOfRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Length of Rectangle: ");
            double Length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter width of Rectangle: ");
            double Width = Convert.ToDouble(Console.ReadLine());
            double Area = Length * Width;
            Console.WriteLine("Area of Rectangle =  " + Area);
            //Console.ReadLine();
        }
    }
}
