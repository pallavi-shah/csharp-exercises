using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int []{ 1, 1, 2, 3, 5, 8 };
            for(int i=0;i<num.Length; i++)
            {
                Console.WriteLine(num[i]);
            }
            Console.ReadLine();
        }
    }
}
