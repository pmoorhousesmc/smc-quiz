using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_Class_Library
{
    public class QuestionCollection
    {
        public static List<QuestionAnswerObject> _questions = new List<QuestionAnswerObject>();

        public void RemoveQuestion(int questionId)
        {
            QuestionAnswerObject questionToRemove = null;

            foreach(QuestionAnswerObject qaObject in _questions)
            {
                if (qaObject.ID == questionId)
                {
                    questionToRemove = qaObject;
                    break;
                }
            }

            if (questionToRemove != null)
            {
                _questions.Remove(questionToRemove);
            }
        }

        public void AddQuestion(QuestionAnswerObject qaObject)
        {
            _questions.Add(qaObject);
        }
    }
}
