using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;


namespace RegexExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc accumsan sem ut ligula scelerisque sollicitudin. Ut at sagittis augue. Praesent quis rhoncus justo. Aliquam erat volutpat. Donec sit amet suscipit metus, non lobortis massa. Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa. Donec nec velit non ligula efficitur luctus.";
            //Console.Write("Enter a string: ");
            //text = Console.ReadLine();   //Bonus Mission----(3)
           //var dir=Path.GetuFllPath(Path.Combine(AppContext.BaseDirectory))
                .
            text= System.IO.File.ReadAllText(@"C:\Users\conta\Desktop\codergirl\csharp-exercises\Class2\Studio\CountChars\studio2.txt");              // Bonus Mission---(4)
            Regex r = new Regex("^[a-zA-Z]"); // Bonus Mission---(2)
            text = text.ToLower(); // Bonus Mission---(1)
            int count = 0;
            
            char strChar;
            Dictionary<char, int> charCount = new Dictionary<char, int>();
            for (int i = 0; i < text.Length; i++)
            {
                strChar = text[i];
                if (!charCount.ContainsKey(strChar) && r.IsMatch(Convert.ToString(strChar)))
                {
                    int j = i;
                    count = 0;
                    while (j < text.Length)
                    {
                        if (text[j] == strChar)
                        {
                            count = count + 1;
                        }
                        j = j + 1;
                    }
                    charCount.Add(strChar, count);
                }
            }
            foreach (KeyValuePair<char, int> kv in charCount)
            {
                Console.WriteLine(kv.Key + ":" + kv.Value);

            }
            Console.ReadLine();
        }
        /*   -------- Bonus mission-------(2) without using Regex-----for self reference
        static bool checkChar(char c)
        {
            if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z'))
            {
                return true;
            }
            else
                return false;
        }
        */

    }

}
