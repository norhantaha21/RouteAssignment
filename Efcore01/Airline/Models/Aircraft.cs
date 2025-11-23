using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Efcore02.Models
{
    internal class Aircraft
    {
        [Key]
        public int Id { get; set; }

        public int Capacity { get; set; }
        public string Model { get; set; }
        public string Maj_Pilot { get; set; }
        public string Assistant { get; set; }
        public string Host1 { get; set; }
        public string Host2 { get; set; }

        [ForeignKey(nameof(Aircraft))]
        public int AL_Id { get; set; }

    }
}
