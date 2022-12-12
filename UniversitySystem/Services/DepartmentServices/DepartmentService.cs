using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using UniversitySystem.Models;

namespace UniversitySystem.Services.DepartmentServices
{
    public class DepartmentService : IDepartmentService
    {
        private readonly DBContext context;
        public DepartmentService(DBContext context)
        {
            this.context = context; 
        }
        public Department AddDepartment(Department department)
        {
           if(department != null)
            {
                context.Departments.Add(department);
                context.SaveChanges();
                return department;
            }
            else
            {
                throw new System.NotImplementedException();

            }
        }

        public void DeleteDepartment(int id)
        {
            var department = context.Departments.FirstOrDefault(e=>e.Id == id);
            if (department != null)
            {
                context.Departments.Remove(department);
                context.SaveChanges();
            }
            else
            {
                throw new System.NotImplementedException();
            }
        }

        public Department GetDepartment(int id)
        {
            var department = context.Departments.Include(e=>e.Students).Include(e=>e.Courses).FirstOrDefault(e => e.Id == id);
            if (department != null)
            {
                return department;
            }
            else
            {
                throw new System.NotImplementedException();
            }
        }

        public List<Department> GetDepartments()
        {
            var courses = context.Departments.Include(e => e.Students).Include(e => e.Courses).ToList();
            return courses;
        }

        public Department UpdateDepartment(Department department)
        {
          context.Departments.Update(department);
            context.SaveChanges();
            return department;
        }
    }
}
