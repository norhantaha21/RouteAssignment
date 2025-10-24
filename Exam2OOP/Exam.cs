using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamC_
{
    internal abstract class Exam
    {
        public double Time { get; set; }

        public int NumberOfQuestions { get; set; }

        public List<Question> questions { get; set; } = new List<Question>();

        public Exam(double time, int numberOfQuestions)
        {
            Time = time;
            NumberOfQuestions = numberOfQuestions;
        }

        public abstract void AddQuestion(Question ques);

        public abstract void ShowExam();

    }
}
