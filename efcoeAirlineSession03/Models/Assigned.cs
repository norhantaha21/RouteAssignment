using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirLineEfCore02.Models
{
    [PrimaryKey(nameof(AircraftId) , nameof(RouteId))]
    internal class Assigned
    {
       
        public int AircraftId { get; set; }
        [InverseProperty(nameof(Aircraft.assigned))]
        public Aircraft aircraft { get; set; } = null!;

        public int RouteId { get; set; }
        [InverseProperty(nameof(Route.assigneds))]
        public Route routes { get; set; } = null!;





        // payload attributes
        public int NumOfPassengers { get; set; }
        public decimal Price { get; set; }
        public DateTime Departure { get; set; }
        public DateTime Arrival { get; set; }
        public int DurationInMinutes { get; set; }
    }
}
