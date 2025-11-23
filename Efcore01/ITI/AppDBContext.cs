using Efcore01.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Efcore01
{
    internal class AppDBContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=Localhost;Database=EfcoreITI;Trusted_Connection=true;TrustServerCertificate=true");


        }


        public DbSet<Student> student { get; set; }
        public DbSet<Course> course { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<Instructor> Instructor { get; set; }
        public DbSet<Topic> Topic { get; set; }
    }
}
