using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Route_EF_01.Entites
{
    internal class Student
    {
        public int Id  { get; set; }
        
        [Required]
        public string Name { get; set; }

        [Range(18, 22)]
        public int? Age { get; set; }

        //public virtual ICollection<Course> Courses { get; set; } = new HashSet<Course>();
    
        public virtual ICollection<StudentCourse> StudentCourses { get; set; } = new HashSet<StudentCourse>();

    }
}
