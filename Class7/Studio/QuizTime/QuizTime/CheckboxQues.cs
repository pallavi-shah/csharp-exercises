using System;
using System.Collections.Generic;
using System.Text;

namespace QuizTime
{
    public class CheckboxQues : Question
    {
        public List<int> CorrectAnswer = new List<int>(); // contains list of correct options for a question
        public List<int> optionChosen = new List<int>(); // contains list of options chosen by the user
        private int choice;
        private bool isValidInput = true; 
        private string input;
        int i = 1;

        //method to get answer from the user for checkbox type questions
        public override void Answer()
        {
            redo:
            do
            {
                isValidInput = true;
                Console.Write("Your Answer: Enter Option " + i + ".\t");
                input = Console.ReadLine();
                try
                {
                    choice = int.Parse(input);
                }
                catch
                {
                    Console.WriteLine("Please enter valid option");
                    isValidInput = false;
                    goto redo;
                }
                if (choice < 1 || choice > optionCount)
                {
                    Console.WriteLine("Please enter valid option");
                    isValidInput = false;
                    goto redo;
                }
                else
                {
                    isValidInput = true;
                    if (!optionChosen.Contains(choice))
                    {
                        optionChosen.Add(choice);
                    }
                    else
                    {
                        Console.WriteLine("Choose another option.");
                        goto redo;
                    }
                }
            } while (isValidInput == false);
            do
            {
                if (i < CorrectAnswer.Count)
                {
                    i++;
                    goto redo;
                }
                
                foreach (int el in optionChosen)
                {
                    if (CorrectAnswer.Contains(el))
                    {
                        IsAnsCorrect = true;
                    }
                    else
                    {
                        IsAnsCorrect = false;
                        break;
                    }
                }
            } while (Options.Count < optionChosen.Count); 
        }

        //method to evaluate answers of checkbox type questions
        public override bool CheckAnswer()
        {
            if (IsAnsCorrect && (optionChosen.Count == CorrectAnswer.Count))
            {
                Quiz.ScoreAchieved = Quiz.ScoreAchieved + 2;
                return true;
            }
            else
            {
                return false;

            }
        }
    }
}


          
