using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirLineEfCore02.Models
{
    internal class Airline
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = null!;
        public string ContactPerson { get; set; } = null!;
        public string Address { get; set; } = null!;



        // Phones stored as value objects / separate entity
        public ICollection<AirlinePhone> Phones { get; set; } = new List<AirlinePhone>();


        // Relationships
        [InverseProperty(nameof(Aircraft.airline))]
        public ICollection<Aircraft> aircrafts { get; set; } = new List<Aircraft>();

        [InverseProperty(nameof(Employee.airline))]
        public ICollection<Employee> Employees { get; set; } = new List<Employee>();


        [InverseProperty(nameof(Transaction.Airline))]
        public ICollection<Transaction> transactions { get; set; } = new List<Transaction>();


        public class AirlinePhone
        {
            public int Id { get; set; }
            public string Phone { get; set; } = null!;
            public int AirlineId { get; set; }
            public Airline Airline { get; set; } = null!;
        }
    }
}
