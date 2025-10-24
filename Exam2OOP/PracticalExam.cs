using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamC_
{
    internal class PracticalExam : Exam
    {

        public PracticalExam(double time, int quesno)
        : base(time, quesno) { }

        public override void AddQuestion(Question ques)
        {
            if (ques is MCQ)
                questions.Add(ques);
            else
                Console.WriteLine("Practical Exam Only accepts MCQ questions");
        }

        public override void ShowExam()
        {
            Console.WriteLine("==== Practical Exam ====");
            int questionNumber = 1;

            foreach (var q in questions)
            {
                Console.WriteLine($"{questionNumber}- {q.body}");
                for (int i = 0; i < q.AnswerList.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {q.AnswerList[i].AnswerText}");
                }

                Console.Write("Your Answer: ");
                int studentAnswer;
                while (!int.TryParse(Console.ReadLine(), out studentAnswer) || studentAnswer < 1 || studentAnswer > q.AnswerList.Count)
                {
                    Console.Write("Invalid input. Please enter a valid number: ");
                }

                q.StudentAnswer = studentAnswer;
                questionNumber++;
                Console.WriteLine();
            }

            Console.WriteLine("==== Correct Answers ====");
            foreach (var q in questions)
            {
                Console.WriteLine($"Question: {q.body}");
                Console.WriteLine($"Right Answer: {q.AnswerList[q.RightAnswer - 1].AnswerText}");
                Console.WriteLine();

            }
                
        }
    }
}
