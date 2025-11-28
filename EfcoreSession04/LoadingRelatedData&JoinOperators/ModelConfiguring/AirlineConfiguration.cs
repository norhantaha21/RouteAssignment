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
    internal class AirlineConfiguration : IEntityTypeConfiguration<Airline>
    {
        public void Configure(EntityTypeBuilder<Airline> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Name).IsRequired().HasMaxLength(200);
            builder.Property(a => a.ContactPerson).IsRequired().HasMaxLength(150);
            builder.Property(a => a.Address).IsRequired().HasMaxLength(300);

            builder.HasMany(a => a.aircrafts)
                   .WithOne(ac => ac.airline)
                   .HasForeignKey(ac => ac.AirlineId)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(a => a.Employees)
                .WithOne(ac => ac.airline)
                .HasForeignKey( a => a.AirlineId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(a => a.transactions)
                  .WithOne(t => t.Airline)
                  .HasForeignKey(t => t.AirlineId)
                  .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
