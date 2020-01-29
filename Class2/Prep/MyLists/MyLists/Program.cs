using System;
using System.Collections.Generic;

namespace MyLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> num = new List<int>(){1,2,3,4,5,6,7,8,9,10};
            Console.Write("List is = ");
            foreach (int el in num)
            {
                Console.Write(" "+ el );
            }

            Console.WriteLine();
            Console.WriteLine("Sum of all Even numbers in the List is: " + sumOfEvenNum(num));
            Console.ReadLine();
        }

        static int sumOfEvenNum(List<int> listOfNum)
        {
            int sum=0;
            foreach (int el in listOfNum)
            {
                if (el % 2 == 0)
                {
                    sum = sum + el;
                }
            }
            return sum;           
        }
    }
}
    