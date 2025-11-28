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
    internal class RouteConfiguration : IEntityTypeConfiguration<Route>
    {
        public void Configure(EntityTypeBuilder<Route> builder)
        {
            builder.HasKey(r => r.Id);
            builder.Property(r => r.Origin).IsRequired().HasMaxLength(200);
            builder.Property(r => r.Destination).IsRequired().HasMaxLength(200);
            builder.Property(r => r.Classification).HasMaxLength(100);
        }
    }
}
