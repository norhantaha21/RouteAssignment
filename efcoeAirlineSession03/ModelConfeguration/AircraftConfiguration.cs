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
    internal class AircraftConfiguration : IEntityTypeConfiguration<Aircraft>
    {
        public void Configure(EntityTypeBuilder<Aircraft> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Model).IsRequired().HasMaxLength(150);

            // one-to-one Aircraft <-> Crew
            builder.HasOne(c => c.crew)
                .WithOne(c => c.Aircraft)
                .HasForeignKey<Crew>(c=>c.AircraftId)
                 .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
