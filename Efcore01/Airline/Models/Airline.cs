using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Efcore02.Models
{
    internal class Airline
    {
        [Key]
        public int Id { get; set; }

        [Required , MaxLength(100)]
        public string Name { get; set; }

        [Required , MaxLength(200)]
        public string Address { get; set; }
        public string Cont_person { get; set; }
    }
}
