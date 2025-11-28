using AirLineEfCore02.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirLineEfCore02.ModelConfiguring
{
    internal class AssignedConfiguration : IEntityTypeConfiguration<Assigned>
    {
        
        public void Configure(EntityTypeBuilder<Assigned> builder)
        {
            //composite keys
            //builder.HasKey(a => new { a.AircraftId, a.RouteId });

            builder.Property(a => a.Price).HasColumnType("decimal(10,2)");
            builder.Property(a => a.DurationInMinutes);

            builder.HasOne(a => a.aircraft)
                .WithMany(c => c.assigned)
                .HasForeignKey(a => a.AircraftId);

            builder.HasOne(a => a.routes)
            .WithMany(c => c.assigneds)
            .HasForeignKey(c => c.RouteId);
        }
    }
}
