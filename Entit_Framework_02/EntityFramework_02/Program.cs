using System;
using System.Linq;
namespace Route_EF_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using UniversityContext Context = new UniversityContext();

            Teacher T01 = new Teacher()
            {
                Name = "Ahmed ",
                HirDate = DateTime.Now
            };
            Student S01 = new Student()
            {
                Name = "Mohammed ",
                EnrollDate = DateTime.Now
            };

            Context.Persons.Add(T01);
            Context.Persons.Add(S01);

            Context.SaveChanges();

            //var Teachers = from T in Context.Persons
            //              select T;

            //var Students = from T in Context.Persons
            //              select T;

            var Persons = from P in Context.Persons select P;

            foreach (var student in Persons.OfType<Student>())
            {
                Console.WriteLine($"{student.Id}  :: {student.Name}  :: {student.EnrollDate}");
            }

            foreach (var Teacher in Persons.OfType<Teacher>())
            {
                Console.WriteLine($"{Teacher.Id}  ::{Teacher.Name}  :: {Teacher.HirDate}");
            }
        }
    }
}
