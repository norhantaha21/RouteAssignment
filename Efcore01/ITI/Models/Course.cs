using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Efcore01.Models
{
    internal class Course
    {
        [Key]
        public int Id { get; set; }

        [Required , StringLength(10)]
        public string Name { get; set; }


        public int Duration { get; set; }

        [StringLength(200)]
        public string Description { get; set; }


        public int Top_Id { get; set; }
    }
}
