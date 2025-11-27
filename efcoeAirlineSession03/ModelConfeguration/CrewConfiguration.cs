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
    internal class CrewConfiguration : IEntityTypeConfiguration<Crew>
    {
        public void Configure(EntityTypeBuilder<Crew> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.MainPilot).IsRequired().HasMaxLength(150);
            builder.Property(c => c.AssistantPilot).HasMaxLength(150);
            builder.Property(c => c.Host1).HasMaxLength(150);
            builder.Property(c => c.Host2).HasMaxLength(150);
        }
    }
}
