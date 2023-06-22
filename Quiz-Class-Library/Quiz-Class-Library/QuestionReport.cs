using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_Class_Library
{
    public class QuestionReport
    {
        public QuestionCollection collection = new QuestionCollection();
        public QuestionAnswerObject Question { get; private set; }
        public string Selection { get; private set; }
        public string Verdict { get { return (WasRightAnswer() ? "Correct" : "Incorrect"); } }
        public QuestionReport(QuestionAnswerObject question, string selection)
        {
            Question = question;
            Selection = selection;
        }
        public bool WasRightAnswer()
        {
            return Selection == Question.SecretAnswer;
        }
    }
}
