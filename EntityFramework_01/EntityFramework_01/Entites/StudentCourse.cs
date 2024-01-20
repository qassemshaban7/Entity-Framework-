using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Route_EF_01.Entites
{
    internal class StudentCourse
    {

        public int StuedntId { get; set; }

        public int CourseId { get; set; }

        public int Grade { get; set; }

        public virtual Student Student { get; set; }
        public virtual Course Course { get; set; }
    }
}
