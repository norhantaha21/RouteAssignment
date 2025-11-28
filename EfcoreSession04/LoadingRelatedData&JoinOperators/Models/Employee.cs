using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirLineEfCore02.Models
{
    internal class Employee
    {
        public int Id { get; set; }      
        public string Name { get; set; } = null!;
        public string Position { get; set; } = null!;
        public string Gender { get; set; } = null!;
        public DateTime? Birthday { get; set; }
        public string Address { get; set; } = null!;
        public string Qualifications { get; set; } = null!;


        //fk with airline
        [ForeignKey(nameof(Airline))]
        public int AirlineId { get; set; }
        public Airline airline { get; set; } = null!;
    }
}
