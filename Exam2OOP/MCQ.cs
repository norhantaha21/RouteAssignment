using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamC_
{
    internal class MCQ : Question
    {
        public List<string> Choices {  get; set; }
        public string CorrectAnswer {  get; set; }

        public MCQ(){
             Choices = new List <string>();
            }

        public override void display()
        {
            Console.WriteLine($"{header} : {body}");
            int i = 1;
            foreach (var choice in Choices)
            {
                Console.WriteLine($"{i}. {choice}");
                i++;
            }
        }
    }
}
