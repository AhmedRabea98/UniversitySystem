using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniversitySystem.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string NameAr { get; set; }    
        public string NameEn { get; set; }

        public string Gpa { get; set; }
        public int DepartmentId { get; set; }

        [ForeignKey("DepartmentId")]
        public virtual Department Department { get; set; }
        public virtual ICollection<StudentCourse> Courses { get; set; }
    }
}
