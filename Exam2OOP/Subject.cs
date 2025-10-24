using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamC_
{
    internal class Subject : ICloneable, IComparable<Subject>
    {
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }

        public Exam Exam { get; set; }
        public Subject(int id, string name)
        {
            SubjectId = id;
            SubjectName = name;
        }

        public Subject(int id) : this(id, "Unknown") { }

        public void CreateExam(Exam exam)
        {
            Exam = exam;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public int CompareTo(Subject? other)
        {
            if (other == null) return 1;
            return this.SubjectName.CompareTo(other.SubjectName);
        }

        public override string ToString()
        {
            return $"Subject ID: {SubjectId}, Name: {SubjectName}, Exam Type: {Exam?.GetType().Name ?? "No Exam"}";

        }

    }
    }
