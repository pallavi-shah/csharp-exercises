using System;
using System.Collections.Generic;
using System.Text;

namespace QuizTime
{
    public class MultipleChoiceQues : Question
    {
        public  int CorrectAnswer { get; set; }
        public  int optionChosen;
        private bool isValidinput=true;
        private string input;

        //method to get answer from the user for multiple Choice questions
        public override void Answer()
        {
            do
            {
                redo:
                isValidinput = true;
                Console.Write("Your Answer : ");

                input = Console.ReadLine();
                try
                {
                    optionChosen = int.Parse(input);
                }
                catch
                {
                    Console.WriteLine("Please enter valid option\n");
                    isValidinput = false;
                    goto redo;
                }
                if (optionChosen < 1 || optionChosen > optionCount)
                {
                    Console.WriteLine("Please enter valid option");
                    goto redo;
                }
            } while (isValidinput == false);
       }
        //method to evaluate answers for multiple Choice questions
    public override bool CheckAnswer()
        {
            if (!(optionChosen == CorrectAnswer))
            {
                return false;
            }
            else
            {
                Quiz.ScoreAchieved++;
                return true;
            }
        }
        
    }
}
