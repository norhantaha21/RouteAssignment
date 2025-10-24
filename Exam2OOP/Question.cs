using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamC_
{
    internal abstract class Question
    {
        public string header {  get; set; }
        public string body { get; set; }
        public int mark {  get; set; }
        public List <Answer> AnswerList { get; set; }  //3shan association m3 class answer
        //public Answer RightAnswer { get; set; }
        public int RightAnswer { get; set; }
        public int StudentAnswer { get; set; }

        public ExamType type { get; set; }


        public abstract void display();
    }
}
