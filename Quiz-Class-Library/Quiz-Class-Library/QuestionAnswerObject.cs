using System.Runtime.Serialization;

namespace Quiz_Class_Library
{
    public class QuestionAnswerObject
    {
        private static Random _randomizer = new Random();
        public string QuestionText { get; private set; }
        public string SecretAnswer { get; set; }

        public List<string> AnswerOptions = new List<string>();
        public int OptionCount { get { return AnswerOptions.Count; } }

        public int ID = 1;

        public QuestionAnswerObject(string question, string answer, string[] wrongAnswers)
        {
            QuestionText = question;
            SecretAnswer = answer;
            AnswerOptions.Add(answer);

            foreach(string option in wrongAnswers)
            {
                AnswerOptions.Add(option);
            }
            ShuffleOptions();
        }

        public bool IsCorrectAnswer(string selection)
        {
            return (selection == SecretAnswer);
        }

        private void ShuffleOptions()
        {
            HashSet<int> seen = new HashSet<int>();

            List<string> reorderedOptions = new List<string>();

            while (seen.Count < OptionCount)
            {
                int choice = _randomizer.Next(AnswerOptions.Count);

                if (!seen.Contains(choice))
                {
                    seen.Add(choice);
                    reorderedOptions.Add(AnswerOptions[choice]);
                }
            }

            AnswerOptions = reorderedOptions;
        }
    }
}