using System.Collections.Generic;
using UniversitySystem.Models;

namespace UniversitySystem.Services.DepartmentServices
{
    public interface IDepartmentService
    {
        public List<Department> GetDepartments();
        public Department GetDepartment(int id);
        public Department AddDepartment(Department department);
        public Department UpdateDepartment(Department department);
        public void DeleteDepartment(int id);
    }
}
