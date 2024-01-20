using Route_EF_01.Entites;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Route_EF_01
{
    //internal class Employee
    //{
    //    public int Id { get; set; }
    //    public string Name  { get; set; }
    //    public double Salaray { get; set; }
    //    public int? Age { get; set; }   
    //}

    //[Table("Employees")]
    internal class Employee
    {
        [Key]
        public int EmpId { get; set; }
        [Column(TypeName ="varchar")]
        [Required]
        [StringLength(50,MinimumLength =10)]
        [MaxLength(50)]
        public string Name { get; set; }
        [Column(TypeName ="mony")]
        [DataType(DataType.Currency)]
        public double Salaray { get; set; }
        [Range(18,25)]
        public int? Age { get; set; }
        [EmailAddress]
        //[DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [ForeignKey("FK_Employee_Departments_DepartmentDeptId")]
        public int DepartmentDeptId { get; set; }
        //Navigation Property
        //public virtual Department Department { get; set; }
    }
}
