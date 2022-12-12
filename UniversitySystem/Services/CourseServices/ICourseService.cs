using System.Collections.Generic;
using UniversitySystem.Models;

namespace UniversitySystem.Services.CourseServices
{
    public interface ICourseService
    {
        public List<Course> GetCourses();
        public Course GetCourse(int id);
        public Course AddCourse(Course course);
        public Course UpdateCourse(Course course);
        public void DeleteCourse(int id);
    }
}
