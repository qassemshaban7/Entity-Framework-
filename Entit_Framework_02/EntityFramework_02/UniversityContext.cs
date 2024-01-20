using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Route_EF_02
{
    internal class UniversityContext :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer("Server =. ; Database = University ; Integrated security =true");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ///TPH
            modelBuilder.Entity<Teacher>().HasBaseType<Person>();
            modelBuilder.Entity<Student>().HasBaseType<Person>();

            base.OnModelCreating(modelBuilder);
        }

        //public DbSet <Teacher> Teachers { get; set; }
        //public DbSet<Student> Students { get; set; }

        public DbSet<Person> Persons { get; set; }
    }
}