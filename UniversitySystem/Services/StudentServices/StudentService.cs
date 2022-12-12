using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using UniversitySystem.Models;

namespace UniversitySystem.Services.StudentServices
{
    public class StudentService : IStudentService
    {
        private readonly DBContext context;
        public StudentService(DBContext context)
        {
            this.context = context;
        }
        public Student AddStudent(Student student)
        {
            if(student != null)
            {
                context.Students.Add(student);
                context.SaveChanges();
                return student;
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        public void DeleteStudent(int id)
        {
            var student = context.Students.FirstOrDefault(e=>e.Id == id);
            if(student != null)
            {
                context.Students.Remove(student);
                context.SaveChanges();

            }
            else
            {
                throw new NotImplementedException();

            }

        }

        public Student GetStudent(int id)
        {
            var student = context.Students.Include(e=>e.Courses).ThenInclude(e => e.course).Include(e=>e.Department).FirstOrDefault(e => e.Id == id);
            if (student != null)
            {
           
                return student;
            }
            else
            {
                throw new NotImplementedException();

            }
        }

        public List<Student> GetStudents()
        {
            var students = context.Students.Include(e=>e.Courses).ThenInclude(e=>e.course).Include(e=>e.Department).ToList();
            return students;
        }

        public Student UpdateStudent(Student student)
        {
            context.Students.Update(student);
            context.SaveChanges();
            return student;
        }
    }
}
