using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirLineEfCore02.Models
{
    internal class Crew
    {
        public int Id { get; set; } 

        public string MainPilot { get; set; } = null!;
        public string AssistantPilot { get; set; } = null!;
        public string Host1 { get; set; } = null!;
        public string Host2 { get; set; } = null!;

        //Relationship
        [InverseProperty(nameof(Aircraft.crew))]
        public int AircraftId { get; set; }
        public Aircraft Aircraft { get; set; } = null!;
    }
}
