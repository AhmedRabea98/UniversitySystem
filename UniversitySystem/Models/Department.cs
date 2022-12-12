using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace UniversitySystem.Models
{
    public class Department
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
    }
}
