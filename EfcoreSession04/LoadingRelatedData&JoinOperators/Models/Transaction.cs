using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirLineEfCore02.Models
{
    internal class Transaction
    {
        public int Id { get; set; }      
        public string Description { get; set; } = null!;
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }

        //fk 
        [ForeignKey(nameof(Airline))]
        public int AirlineId { get; set; }
        public Airline Airline { get; set; } = null!;
    }
}
