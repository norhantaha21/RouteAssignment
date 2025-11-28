using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirLineEfCore02.Models
{
    internal class Route
    {
        public int Id { get; set; } 
        public string Origin { get; set; } = null!;
        public string Destination { get; set; } = null!;
        public double Distance { get; set; }
        public string Classification { get; set; } = null!;

        // Many-to-many with Aircraft via Assigned
        [InverseProperty(nameof(Assigned.routes))]
        public ICollection<Assigned> assigneds { get; set; } = new List<Assigned>();
    }
}
