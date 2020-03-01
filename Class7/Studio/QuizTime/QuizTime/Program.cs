using System;
using System.Collections.Generic;
using System.Text;

namespace QuizTime
{
    class Program
    {
        static void Main(string[] args)
        {
            MultipleChoiceQues mcq = new MultipleChoiceQues()
            {
                Q = "What is USA Capital? (Select an option )",
                Options = { "New Jersey", "Washington, DC", "Calfornia" },
                CorrectAnswer = 2
            };

            MultipleChoiceQues mcq1 = new MultipleChoiceQues()
            {
                Q = "What is the Capital of India? (Select an option)",
                Options = { "Gujarat", "New Delhi", "Mumbai" },
                CorrectAnswer = 2
            };

            CheckboxQues cbq1 = new CheckboxQues()
            {
                Q = "Which of the following are types of performance testing? (select two options below)",
                Options = { "Load Testing", "Reliability Testing", "Stress Testing", "Scalability Testing" },
                CorrectAnswer= {1,3}
            };

            CheckboxQues cbq2 = new CheckboxQues()
            {
                Q = "Three states in USA are ? (select two options below)",
                Options = { "NJ", "CA", "WI", "AS" },
                CorrectAnswer = { 1, 2, 3 }
            };

            TrueFalseQues tfq1 = new TrueFalseQues()
            {
                Q = "Narendra Modi is president of India? Choose option 1 or 2.",
                CorrectAnswer = 2
            };
            
            Console.WriteLine("Your Quiz Starts Now...\n______________________\n\n");
            
            // methods to add questions
            Quiz.AddQuestion(mcq);
            Quiz.AddQuestion(mcq1);
            Quiz.AddQuestion(cbq1);
            Quiz.AddQuestion(cbq2);
            Quiz.AddQuestion(tfq1);

            // method to run the quiz and display questions,options and get answers from the user

            Quiz.RunQuiz();

            // method to grade the quiz

            Quiz.GradeQuiz();

            Console.ReadLine();
        }
    }

}
 