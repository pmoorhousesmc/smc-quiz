using Quiz_Class_Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_Console_App
{
    internal class ConsoleUI
    {


        private Quiz Quiz { get; set; }

        public int Score { get; private set; }
        public int MaxScore { get { return Quiz.questions.Count;  } }

        private int Count { get; set; }

        public ConsoleUI(Quiz quiz)
        {
            Score = 0;
            Count = 0;
            Quiz = quiz;

            AskQuestions();
        }

        private void AskQuestions()
        {
            foreach(QuestionAnswerObject question in Quiz.questions)
            {
                Console.Clear();
                Count++;                
                ServeQuestion(question);
            }
        }

        private void PaintQuestionHeader()
        {
            PaintTitle();
            Console.WriteLine($"Question #{Count}");
            Console.WriteLine();

        }
        private void PaintTitle()
        {
            Console.WriteLine($"{Quiz.Title}");
            Console.WriteLine();
        }

        public void ServeQuestion(QuestionAnswerObject question)
        {
            PaintQuestionHeader();

            Console.WriteLine(question.QuestionText);
            Console.WriteLine();

            string selection = GetSelection(question.AnswerOptions);

            if (question.IsCorrectAnswer(selection))
            {
                CongratulateSelection(selection);
            }
            else
            {
                IllustrateCorrection(selection, question.SecretAnswer);
            }

            Console.WriteLine();
        }

        private void HangAnyKey()
        {
            Console.WriteLine();
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }

        private void CongratulateSelection(string answer)
        {
            Console.Clear();
            PaintQuestionHeader();
            Console.WriteLine($"That's correct!");
            Console.WriteLine($"The answer was '{answer}'.");
            HangAnyKey();
        }

        private void IllustrateCorrection(string selection, string answer)
        {
            Console.Clear();
            PaintQuestionHeader();
            Console.WriteLine($"That's incorrect!");
            Console.WriteLine($"You chose {selection}.");
            Console.WriteLine($"The answer was '{answer}'.");
            HangAnyKey();
        }

        private string GetSelection(List<string> options)
        {
            OfferOptions(options);
            Console.WriteLine();
            int i = GetIntInRange(1, options.Count);
            return options[i-1];
        }

        private int GetIntInRange(int a, int b)
        {
            while (true)
            {
                Console.WriteLine($"Enter a number between {a} & {b} (inclusive)");

                string entry = Console.ReadLine();

                try
                {
                    int num = int.Parse(entry);
                    if (a <= num && num <= b)
                    {
                        return num;
                    }
                }
                catch
                {
                    continue;
                }
            }
        }

        public void OfferOptions(List<string> options)
        {
            for(int i=0; i<options.Count; i++)
            {
                Console.WriteLine($"{i+1}: {options[i]}");
            }
        }

    }
}
