using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Efcore01.Models
{
    internal class Student
    {
        [Key]
        public int  Id {  get; set; }

        [Required , StringLength(50)]
        public string Fname { get; set; }
        public string? Lname { get; set; }

        [Required ]
        public int Age { get; set; }

        [Required , StringLength(100)]
        public string Address { get; set; }

        public int Dep_Id { get; set; }

    }
}
