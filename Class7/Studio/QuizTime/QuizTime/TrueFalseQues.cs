using System;
using System.Collections.Generic;
using System.Text;

namespace QuizTime
{
   public class TrueFalseQues : MultipleChoiceQues
    {
        public TrueFalseQues()
        {
            Options.Add("True");
            Options.Add("False");
        }
    }
}
