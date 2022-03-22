using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonifyData
{
    internal class QuestionAndAnswer
    {
        public string? Question { get; set; }
        public List<string> Answers { get; set; }
        public int CorrectAnswerIndex { get; set; }

        public QuestionAndAnswer()
        {
            this.Answers = new List<string>();
        }



    }

}
