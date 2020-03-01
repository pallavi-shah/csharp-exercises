using System;
using System.Collections.Generic;
using System.Text;

namespace QuizTime
{
    public class Quiz
    {
        public static List<Question> Questions   {get; set; } = new List<Question>(); // displays list of questions
        public static int ScoreAchieved = 0;   //indicates score achieved by user
        public static int TotalQuizScore = 0;  // indicates the total score/points of the quiz
        public static int QuestionScore = 0;   // indicates score assigned to each type of question
        public static void AddQuestion(Question q)
        {
             Questions.Add(q);
            if (q.GetType()==typeof(MultipleChoiceQues) || q.GetType() == typeof(TrueFalseQues))
            {
                TotalQuizScore++;
            }
            else
                TotalQuizScore = TotalQuizScore + 2;
        }

        //method to run the quiz and display questions,options and get answers from the user
        public static void RunQuiz()
        {
            int QuestionCount = 0;
            foreach (Question el in Quiz.Questions)
            {
                QuestionCount++;
                Console.WriteLine(QuestionCount + "." + el.ToString());
                el.Answer();
                Console.WriteLine("\n------------------------------------------\n");
            }
        }

        // method to grade the quiz
        public static void GradeQuiz()
            {
            int questCount = 0;
            foreach (Question q in Questions)
            {
               q.CheckAnswer();
            }

            Console.WriteLine("YOU'RE DONE !! THANK YOU FOR TAKING THE QUIZ.\n");
            Console.WriteLine("=======YOUR SCORE : {0} out of {1} ========\n", ScoreAchieved, TotalQuizScore);
            foreach (Question q in Questions)
            {
                
                if (q.CheckAnswer() is true)
                {
                    questCount++;
                    if (q.GetType() == typeof(MultipleChoiceQues) || q.GetType() == typeof(TrueFalseQues))
                        {
                            Console.WriteLine("\nQ" + questCount + "." + "Your Answer option {0} is Correct !", ((MultipleChoiceQues)q).CorrectAnswer);
                        }
                    else
                    {
                        Console.WriteLine("\nQ" + questCount + "." + "Your Answer option {0}is Correct !", convertToStr(((CheckboxQues)q).CorrectAnswer));
                    }          
                }
                else 
                {
                    questCount++;
                    if (q.GetType() == typeof(MultipleChoiceQues) || q.GetType() == typeof(TrueFalseQues))
                    {
                        Console.WriteLine("\nQ"+questCount+". Your Answer    : option {0} is wrong. ", ((MultipleChoiceQues)q).optionChosen);
                        Console.WriteLine("    Correct Answer : option {0} ", ((MultipleChoiceQues)q).CorrectAnswer);
                    }
                    else
                    {
                        Console.WriteLine("\nQ" + questCount + ". Your Answer  : option {0} ", convertToStr(((CheckboxQues)q).optionChosen));
                        Console.WriteLine("    Correct Answer :  option {0}" , convertToStr(((CheckboxQues)q).CorrectAnswer));

                    }
                }
            }
        }

        //method to convert optionChosen and correct answer which are a list of integer into a string.
        public static string convertToStr(List<int> listInt)
        {
            string str = "";
            foreach (int el in listInt)
            {
                str += el + ", ";
            }
            return str;
        }
    }

}
