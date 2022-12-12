using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniversitySystem.Models
{
    public class Course
    {
        [Key]
        public int Id { get; set; }
        public string NameAr { get; set; }
        public string NameEn { get; set; }
        public string CodeAr { get; set; }
        public string CodeEn { get; set; }
        public string Prerequisite { get; set; }
        public string Hours { get; set; }
         public string Grade { get; set; }
        public int MaxNum { get; set; }
        public int DepartmentId { get; set; }

        [ForeignKey("DepartmentId")]
        public virtual Department Department { get; set; }
        public virtual ICollection<StudentCourse> Students { get; set; }

    }
}
