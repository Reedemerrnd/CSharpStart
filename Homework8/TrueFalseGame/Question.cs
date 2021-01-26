using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrueFalseGame
{
    public class Question
    {
        public string Quest { get; set; }
        public string Answer { get; set; }
        public Question(string ques, string answ)
        {
            Quest = ques;
            Answer = answ;
        }
        public Question()
        {
                
        }
    }
}
