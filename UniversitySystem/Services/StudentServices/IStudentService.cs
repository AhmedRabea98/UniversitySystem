using System.Collections.Generic;
using UniversitySystem.Models;

namespace UniversitySystem.Services.StudentServices
{
    public interface IStudentService
    {
        public List<Student> GetStudents();
        public Student GetStudent(int id);
        public Student AddStudent(Student student);
        public Student UpdateStudent(Student student);
        public void DeleteStudent(int id);
    }
}
