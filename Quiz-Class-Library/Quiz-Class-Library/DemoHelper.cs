using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_Class_Library
{
    public class DemoHelper
    {
        public static Quiz GetDemoQuiz()
        {
            Quiz quiz = new Quiz("Demo Quiz");

            quiz.AddQuestion(Question1());
            quiz.AddQuestion(Question2());
            return quiz;
        }

        private static QuestionAnswerObject Question1()
        {
            string question = "What is pseudocode?";
            string answer = "A set of instructions in the style of a programming language but using plain English.";

            string[] wrongAnswers = new string[]
            {
                "A high level programming language that allows the user to create complex routines and flows.",
                "A programming language used to build websites and software.",
            };


            QuestionAnswerObject questionObj = new QuestionAnswerObject(question, answer, wrongAnswers);
            return questionObj;
        }

        private static QuestionAnswerObject Question2()
        {
            string question = "Which element should be included at the start and end of a flowchart?";
            string answer = "Terminator";

            string[] wrongAnswers = new string[]
            {
                "Decision",
                "Input/Output",
                "Process",
            };


            QuestionAnswerObject questionObj = new QuestionAnswerObject(question, answer, wrongAnswers);
            return questionObj;
        }


    }
}
