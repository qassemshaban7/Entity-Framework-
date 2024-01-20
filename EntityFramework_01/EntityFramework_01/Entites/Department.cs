using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Route_EF_01.Entites
{
    internal class Department
    {
        public int DeptId { get; set; }
        public string Name { get; set; }
        public DateTime DataOfCreation { get; set; }
        //Navigation Property 
        //public virtual  ICollection<Employee> Employees { get; set; }= new HashSet<Employee>();
        //public Department()
        //{
        //    Employees = new HashSet<Employee>();
        //}

    }
}
