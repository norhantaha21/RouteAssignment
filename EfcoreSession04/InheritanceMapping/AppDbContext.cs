using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using static InheritanceMapping.Models;

namespace InheritanceMapping
{
    internal class AppDbContext : DbContext
    {
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer("Server=Localhost;Database=InheritencaMapping;Trusted_Connection=true;TrustServerCertificate=true");
            }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                // Q1: Vehicle TPH
                modelBuilder.Entity<Vehicle>()
                    .HasDiscriminator<string>("VehicleType")
                    .HasValue<Vehicle>("Vehicle")
                    .HasValue<Car>("Car")
                    .HasValue<Bus>("Bus");

                // Q2: Payment TPT
                modelBuilder.Entity<Payment>().ToTable("Payments");
                modelBuilder.Entity<CreditCardPayment>().ToTable("CreditCardPayments");
                modelBuilder.Entity<CashPayment>().ToTable("CashPayments");

                //Q3: Product TPC
                modelBuilder.Entity<Book>().ToTable("Books");
                modelBuilder.Entity<Electronics>().ToTable("Electronics");
            }
        }
    }

