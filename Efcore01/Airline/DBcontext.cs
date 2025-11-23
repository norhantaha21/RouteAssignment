using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Efcore02.Models;
using Microsoft.EntityFrameworkCore;

namespace Efcore02
{
    internal class Dbcontext :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=Localhost;Database=Efcore01Airline;Trusted_Connection=true;TrustServerCertificate=true");


        }
        public DbSet<Aircraft> aircrafts { get; set; }
        public DbSet<Airline> airlines { get; set; }
        public DbSet<Employee> employees { get; set; }
        public DbSet<Route> routes { get; set; }
        public DbSet<Transaction> transactions { get; set; }

    }
}
