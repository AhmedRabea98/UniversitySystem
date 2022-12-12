using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using UniversitySystem.Models;
using UniversitySystem.Services.CourseServices;

namespace UniversitySystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly ICourseService service;
        public CourseController(ICourseService service)
        {
            this.service = service;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Course>> GetCourses()
        {
            try
            {
                return service.GetCourses();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        [HttpGet("{id}")]
        public ActionResult<Course> GetCourse([FromRoute] int id)
        {

            try
            {
                return service.GetCourse(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        [HttpPut]
        public ActionResult<Course> UpdateCourse([FromBody] Course course)
        {
            try
            {
                return service.UpdateCourse(course);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        [HttpPost]
        public ActionResult<Course> AddCourse([FromBody] Course course)
        {
            try
            {
                return service.AddCourse(course);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        [HttpDelete("{id}")]
        public void DeleteCourse([FromRoute] int id)
        {
            try
            {
                var data = service.GetCourse(id);

                if (data != null)
                {
                    service.DeleteCourse(id);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
