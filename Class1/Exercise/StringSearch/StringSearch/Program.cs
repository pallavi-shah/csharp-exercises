using System;

namespace StringSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            string storyLine = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do:" +
                " once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' " +
                "thought Alice 'without pictures or conversation?'";
            Console.WriteLine("Enter a string to search: ");
            string searchWord=Console.ReadLine();
            string lowerCaseString=searchWord.ToLower();
            if (storyLine.ToLower().Contains((lowerCaseString)) == true)
            {
                Console.WriteLine("\n true");
            }
        }
    }
}
