using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirLineEfCore02.Models
{
    internal class Aircraft
    {
        //attributes
        public int Id { get; set; }
        public string Model { get; set; } = null!;
        public int Capacity { get; set; }

        // FK to Airline
        [ForeignKey(nameof(Airline))]
        public int AirlineId { get; set; }
        public Airline airline { get; set; } = null!;


        [InverseProperty(nameof(Crew.Aircraft))]
        public Crew? crew { get; set; }


        [InverseProperty(nameof(Assigned.aircraft))]
        public ICollection<Assigned> assigned { get; set; } = new HashSet<Assigned>();
    }
}
