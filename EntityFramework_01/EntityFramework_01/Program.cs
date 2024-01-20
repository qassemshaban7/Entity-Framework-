using Route_EF_01.Context;
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using System.Linq;

namespace Route_EF_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using(EnterpriseContext context = new EnterpriseContext())
            {
                #region Insert 
                //Employee E1 = new Employee()
                //{
                //    Name = "Ahmed",
                //    Salaray = 4000,
                //    Age = 33,
                //    Email = "Ahmed@gmail.com" 
                //};
                //Employee E2 = new Employee()
                //{
                //    Name = "Mohamed",
                //    Salaray = 5000,
                //    Age = 23,
                //    Email = "Mohamed@gmail.com"
                //};

                //Console.WriteLine(context.Entry(E1).State);///Detached

                /////Add to local
                //context.Employees.Add(E1);
                //context.Employees.Add(E2);
                ////context.Set<Employee>().Add(E1);
                ////context.Add(E1);
                ////context.Entry(E1).State = EntityState.Added;

                //Console.WriteLine(context.Entry(E1).State); ///Added

                //context.SaveChanges(); ///add to database

                //Console.WriteLine(context.Entry(E1).State);
                /////Unchanged

                //Console.WriteLine(E1.EmpId);
                //Console.WriteLine(E2.EmpId); 
                #endregion
                #region Select Update
                //var Result = (from E in context.Employees
                //             where E.EmpId == 1
                //             select E).FirstOrDefault();

                //Console.WriteLine(Result?.Name ?? "Na");

                ////Update at Local
                //Result.Name = "NewName";
                //Console.WriteLine(context.Entry(Result).State); ///Modified

                //context.SaveChanges(); ///Update Database

                //Console.WriteLine(context.Entry(Result).State); ///UnChanged
                #endregion
                #region Delete
                //var DeletedEmp = context.Employees.FirstOrDefault(E => E.EmpId == 1);
                //context.Employees.Remove(DeletedEmp);
                /////Delet from local

                //Console.WriteLine(context.Entry(DeletedEmp).State);///Deleted
                //context.SaveChanges();///Delete From DataBase 
                //Console.WriteLine(context.Entry(DeletedEmp).State);///Detached

                #endregion

            }
        }
    }
}
