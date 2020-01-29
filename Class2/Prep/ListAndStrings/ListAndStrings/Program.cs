using System;
using System.Collections.Generic;

namespace ListAndStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> MyListOfWords= new List<string> {"hello","World","Launch","Coder","Girl"};
            Console.WriteLine("Words with Five letters are: \n");
            FiveCharString(MyListOfWords);
            Console.ReadLine();
        }

        static void FiveCharString(List<string>ListOfWords)
        {
           foreach (string word in ListOfWords)
            {
                if (word.Length == 5)
                {
                    Console.WriteLine(word);
                }
            }
        }
    }
}
