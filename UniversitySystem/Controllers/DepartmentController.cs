using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using UniversitySystem.Models;
using UniversitySystem.Services.DepartmentServices;

namespace UniversitySystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private IDepartmentService service;
        public DepartmentController(IDepartmentService service)
        {
            this.service = service;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Department>> GetDepartments()
        {
            try
            {
                return service.GetDepartments();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        [HttpGet("{id}")]
        public ActionResult<Department> GetDepartment([FromRoute] int id)
        {

            try
            {
                return service.GetDepartment(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        [HttpPut]
        public ActionResult<Department> UpdateDepartment([FromBody] Department department)
        {
            try
            {
                return service.UpdateDepartment(department);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        [HttpPost]
        public ActionResult<Department> AddDepartment([FromBody] Department department)
        {
            try
            {
                return service.AddDepartment(department);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        [HttpDelete("{id}")]
        public void DeleteDepartment([FromRoute] int id)
        {
            try
            {
                var data = service.GetDepartment(id);

                if (data != null)
                {
                    service.DeleteDepartment(id);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
