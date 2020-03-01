using System;
using System.Collections.Generic;
using System.Text;

namespace QuizTime
{
    //parent class for different types of question classes
    public abstract class Question
    {
        public string Q { get; set; }  // indicates question
        public List<string> Options = new List<string>(); // multiple choices given in the question to choose from 
        public abstract void Answer();  // method declared to get answer from the user for each question.
        public abstract bool CheckAnswer(); // method declared to evaluate the answer of each question.
        public bool IsAnsCorrect;
        public string Op="";  // string to convert optioncount which is an int, into string to display question numbers.
        public int optionCount = 0;
       
       //method to display Question and its options
        public override string ToString()
        {
            foreach(string el in Options)
            {
                optionCount++;
                Op= Op+optionCount.ToString() + ".\t" + el+"\n";
            }
            return Q + "\n\n" + Op;
        }


    }
}
