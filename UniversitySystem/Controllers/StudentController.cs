using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using UniversitySystem.Models;
using UniversitySystem.Services.StudentServices;

namespace UniversitySystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService service;
        public StudentController(IStudentService service)
        {
            this.service = service;
        }
        [HttpGet]
        public ActionResult<IEnumerable<Student>> GetStudents()
        {
            try
            {
                return service.GetStudents();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        [HttpGet("{id}")]
        public ActionResult<Student> GetStudent([FromRoute]int id) {

            try
            {
                return service.GetStudent(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        [HttpPut]
        public ActionResult<Student> UpdateStudent([FromBody]Student student)
        {
            try
            {
                return service.UpdateStudent(student);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        [HttpPost]
        public ActionResult<Student> AddStudent([FromBody]Student student)
        {
            try
            {
                return service.AddStudent(student);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        [HttpDelete("{id}")]
        public void DeleteStudent([FromRoute] int id)
        {
            try
            {
                var data = service.GetStudent(id);

                if (data != null)
                {
                    service.DeleteStudent(id);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
