using AirLineEfCore02.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AirLineEfCore02.Models.Airline;

namespace AirLineEfCore02.ModelConfiguring
{
    internal class AirlinePhoneConfiguration : IEntityTypeConfiguration<AirlinePhone>
    {
        public void Configure(EntityTypeBuilder<AirlinePhone> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Phone).IsRequired().HasMaxLength(50);
            builder.HasOne(p => p.Airline)
                   .WithMany(a => a.Phones)
                   .HasForeignKey(p => p.AirlineId);
        }
    }
}
