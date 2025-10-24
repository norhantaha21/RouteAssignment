using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamC_
{
    internal class FinalExam : Exam
    {
        public FinalExam(double time, int numOfQuestions)
            : base(time, numOfQuestions) { }

        public override void AddQuestion(Question ques)
        {
            if (ques is MCQ || ques is TrueOrFalse)
                questions.Add(ques);
            else
                Console.WriteLine("Final Exam only accepts True/False or MCQ questions");
        }

        public override void ShowExam()
        {
            Console.WriteLine("==== Final Exam ====");
            int totalMarks = 0;
            int studentMarks = 0;

            foreach (var q in questions)
            {
                totalMarks += q.mark;
                Console.WriteLine($"{q.body}");

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

                if (studentAnswer == q.RightAnswer)
                    studentMarks += q.mark;

                Console.WriteLine();
            }

            Console.WriteLine("==== Exam Summary ====");
            foreach (var q in questions)
            {
                Console.WriteLine($"Q: {q.body}");
                Console.WriteLine($"Your Answer: {q.AnswerList[q.StudentAnswer - 1].AnswerText}");
                Console.WriteLine($"Right Answer: {q.AnswerList[q.RightAnswer - 1].AnswerText}");
                Console.WriteLine($"Mark: {(q.StudentAnswer == q.RightAnswer ? q.mark : 0)} / {q.mark}");
                Console.WriteLine();
            }

            Console.WriteLine($"Total Grade: {studentMarks} / {totalMarks}");
        }
        }
    }
