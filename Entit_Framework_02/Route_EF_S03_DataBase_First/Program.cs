using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Route_EF_S03_DataBase_First.Contexts;
using System;

namespace Route_EF_S03_DataBase_First
{
    internal class Program
    {
        static /*async*/ void Main(string[] args)
        {
            using NorthwindContext Context = new NorthwindContext();

            //var NorthwindProcedures = new NorthwindContextProcedures(Context);

            //var Products = NorthwindProcedures.SalesByCategoryAsync("Beverages", "1998");

            //foreach (var Product  in Products.Result)
            //{
            //    Console.WriteLine(Product);
            //}

            #region Run SQL Query

            ////var Categories = /*await*/ Context.Categories.FromSqlRaw("Select * from categories").ToListAsync();

            //int count = 3;
            //var Categories = Context.Categories.FromSqlInterpolated($"Select top({count}) * from categories").ToListAsync();

            //foreach (var item in Categories.Result)
            //{
            //    Console.WriteLine(item?.CategoryName ?? "NA");
            //}

            //SqlParameter id = new SqlParameter() 
            //{
            //    Value = 1, Direction = System.Data.ParameterDirection.Input
            //};
            //SqlParameter name = new SqlParameter()
            //{
            //    Direction = System.Data.ParameterDirection.Output
            //};
            //var Result = Context.Products.FromSqlRaw 
            //    ("Execute SP_GetStudentNameById @Id, @Name output", id, name);


            //Context.Database.ExecuteSqlRaw("Update Categories set CategoryName = 'NewName' where CategoryID =1");
           

            
            
            #endregion
        }
    }
}
