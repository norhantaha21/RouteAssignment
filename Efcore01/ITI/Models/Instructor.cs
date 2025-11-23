using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Efcore01.Models
{
    internal class Instructor
    {
        [Key]
        public int Id { get; set; }

        [Required , StringLength(100)]
        public string Name { get; set; }

        [Required, StringLength(100)]
        public string Address { get; set; }

        public decimal Bouns { get; set; }

        public decimal Salary { get; set; }

        public decimal Hour_Rate { get; set; }

        public int Dep_Id { get; set; }
    }
}
