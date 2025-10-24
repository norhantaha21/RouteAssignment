using System.Reflection.PortableExecutable;

namespace ExamC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
 
            Subject cs = new Subject(101, "Computer Science");

          
            FinalExam finalExam = new FinalExam(60, 2); // 60 دقيقة، سؤالين

            // 3- السؤال الأول (MCQ)
            MCQ q1 = new MCQ
            {
                header = "Q1",
                body = "Which of the following is NOT a programming language?",
                mark = 5,
                AnswerList = new List<Answer>
        {
            new Answer(1, "Python"),
            new Answer(2, "HTML"),
            new Answer(3, "C++"),
            new Answer(4, "Java")
        },
                RightAnswer = 2 
            };

           
            TrueOrFalse q2 = new TrueOrFalse
            {
                header = "Q2",
                body = "In Object-Oriented Programming, inheritance allows a class to reuse code from another class.",
                mark = 5,
                AnswerList = new List<Answer>
        {
            new Answer(1, "True"),
            new Answer(2, "False")
        },
                RightAnswer = 1
            };

           
            finalExam.AddQuestion(q1);
            finalExam.AddQuestion(q2);

 
            cs.CreateExam(finalExam);

            
            cs.Exam.ShowExam();

            Console.ReadLine();
        }
    }
    }

