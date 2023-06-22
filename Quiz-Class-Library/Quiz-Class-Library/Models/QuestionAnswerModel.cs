using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_Class_Library.Models
{
    public class QuestionAnswerModel
    {
        public int ID { get; set; }

        public string Topic { get; set; }
        public string QuestionText { get; set; }

        public string QuestionAnswer { get; set; }

        public string WrongOption1 { get; set; }

        public string WrongOption2 { get; set; }

        public string WrongOption3 { get; set; }





    }
}
