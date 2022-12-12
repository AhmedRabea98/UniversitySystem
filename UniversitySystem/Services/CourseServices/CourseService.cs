using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using UniversitySystem.Models;

namespace UniversitySystem.Services.CourseServices
{
    public class CourseService : ICourseService
    {
        private readonly DBContext context;
        public CourseService(DBContext context)
        {
            this.context = context; 
        }
        public Course AddCourse(Course course)
        {
            if(course != null)
            {
                context.Courses.Add(course);
                context.SaveChanges();
                return course;
            }
            else {
                throw new System.NotImplementedException();
            }
        }

        public void DeleteCourse(int id)
        {
            var course = context.Courses.FirstOrDefault(e => e.Id == id);
            if (course != null)
            {
                context.Courses.Remove(course);
                context.SaveChanges();
            }
            else
            {
                throw new System.NotImplementedException();
            }
        }

        public List<Course> GetCourses()
        {
            var courses = context.Courses.Include(e=>e.Students).ThenInclude(e=>e.student).Include(e=>e.Department).ToList();
            return courses;
   
        }

        public Course GetCourse(int id)
        {
            var course = context.Courses.Include(e => e.Students).ThenInclude(e=>e.student).Include(e=>e.Department).FirstOrDefault(e => e.Id == id);
            if (course != null)
            {
                return course;
            }
            else
            {
                throw new System.NotImplementedException();
            }
        }

        public Course UpdateCourse(Course course)
        {

            context.Courses.Update(course);
            context.SaveChanges();
            return course;
        }
    }
}
