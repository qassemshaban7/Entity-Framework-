using Microsoft.EntityFrameworkCore;
using Route_EF_01.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Route_EF_01.Context
{
    internal class EnterpriseContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server =.; Database =EnterpriseDb; Integrated Security = true ;");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>().ToTable("Departments");
            modelBuilder.Entity<Department>().HasKey(D => D.DeptId);

            modelBuilder.Entity<Department>()
                //.Property(D => D.DeptId)
                .Property(nameof(Department.DeptId))
                .UseIdentityColumn(10, 10);

            modelBuilder.Entity<Department>()
                .Property(D => D.Name)
                .IsRequired(true)
                .HasMaxLength(50)
                .HasColumnType("varchar");

            modelBuilder.Entity<Department>()
                .Property(D => D.DataOfCreation)
                .HasDefaultValue(DateTime.Now);

            modelBuilder.Entity<Department>(E =>
            {
                E.Property(nameof(Department.DeptId))
                .UseIdentityColumn(10, 10);

                E.Property(D => D.Name)
                    .IsRequired(true)
                    .HasMaxLength(50)
                    .HasColumnType("varchar");

                E.Property(D => D.DataOfCreation)
                    .HasDefaultValue(DateTime.Now);
            });

            //modelBuilder.ApplyConfiguration(new DeparmentConfigration());

            //modelBuilder.Entity<Department>()
            //    .HasMany(D => D.Employee)
            //    .WithOne(E => E.Department);
            //modelBuilder.Entity<Employee>()
            //    .HasOne(E => E.Department)
            //    .WithMany(E => E.Employee);


            //modelBuilder.Entity<Student>()
            //    .HasMany(s => s.Courses)
            //    .WithMany(c => c.Students);

            //modelBuilder.Entity<Student>()
            //    .HasMany(s => s.StudentCourses)
            //    .WithOne(SC => SC.Course);
            //modelBuilder.Entity<Course>()
            //    .HasMany(s => s.CourseStudents)
            //    .WithOne(SC => SC.Student);

            modelBuilder.Entity<StudentCourse>()
                .HasKey(SC => new{SC.StuedntId, SC.CourseId});


            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Employee> Employees { get; set; }

        //public DbSet<Department> Departments { get; set; }

        public DbSet<Student>Students { get; set; }

        public DbSet<Course> Courses { get; set; }

    }
}
