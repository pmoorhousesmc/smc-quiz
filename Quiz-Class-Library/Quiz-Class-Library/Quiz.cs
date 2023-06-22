using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_Class_Library
{
    public class Quiz
    {

        public string Title { get; private set; }

        public List<QuestionAnswerObject> questions = new List<QuestionAnswerObject>();

        public QuizReport Report { get; private set; }

        public Quiz(string title)
        {
            Title = title;
            Report = new QuizReport(title);
        }

        public void AddQuestion(QuestionAnswerObject questionAnswerObject)
        {
            questions.Add(questionAnswerObject);
        }
    }
}
