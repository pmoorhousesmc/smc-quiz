using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_Class_Library
{
    public class QuizReport
    {
        public string Title { get; private set; }

        public List<QuestionReport> questionHistory = new List<QuestionReport>();

        public int Score { get; private set; }

        public QuizReport(string title)
        {
            Title = title;
            Score = 0;
        }

        public void Include(QuestionReport questionReport)
        {
            questionHistory.Add(questionReport);

            if (questionReport.WasRightAnswer())
            {
                Score++;
            }
        }
    }
}
