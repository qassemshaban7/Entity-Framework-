using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Route_EF_01.Entites
{
    internal class Course
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        
        public virtual ICollection<Student> Students { get; set; } = new HashSet<Student>();

    }
}
