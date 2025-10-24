using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamC_
{
    internal class TrueOrFalse : Question
    {

        public bool CorrectAnswer {  get; set; }

        public override void display()
        {
            Console.WriteLine($"{header} : {body}");
            Console.WriteLine("1. True\n2. False");
        }
    }
}
