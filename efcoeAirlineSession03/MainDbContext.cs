using AirLineEfCore02.ModelConfiguring;
using AirLineEfCore02.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AirLineEfCore02.Models.Airline;

namespace AirLineEfCore02
{
    internal class MainDbContext :DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=Localhost;Database=EfcoreAirlineSession02;Trusted_Connection=true;TrustServerCertificate=true");


        }
        public DbSet<Airline> Airlines { get; set; }
        public DbSet<AirlinePhone> AirlinePhones { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Aircraft> Aircrafts { get; set; }
        public DbSet<Crew> Crews { get; set; }
        public DbSet<Route> Routes { get; set; }
        public DbSet<Assigned> Assigneds { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AirlineConfiguration());
            modelBuilder.ApplyConfiguration(new AirlinePhoneConfiguration());
            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
            modelBuilder.ApplyConfiguration(new TransactionConfiguration());
            modelBuilder.ApplyConfiguration(new AircraftConfiguration());
            modelBuilder.ApplyConfiguration(new CrewConfiguration());
            modelBuilder.ApplyConfiguration(new RouteConfiguration());
            modelBuilder.ApplyConfiguration(new AssignedConfiguration());
        }
    }
}
