using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Route_EF_02
{
    internal /*abstract*/ class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }    
    }

    class Teacher : Person
    {
        public DateTime HirDate { get; set; }

    }
    class Student : Person
    {
        public DateTime EnrollDate { get; set; }
    }
}
