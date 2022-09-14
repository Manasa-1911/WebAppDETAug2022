using Microsoft.AspNetCore.Mvc;
using OData6Demo.Models;
using OData6Demo.Services;
using Microsoft.AspNetCore.OData.Query;

namespace OData6Demo.Controllers
{

    [ApiController]
    [Route("api/[controller]")]

    public class StudentsController : ControllerBase
    {
            private readonly IStudentService studentService;

            public StudentsController(IStudentService studentService) =>
                this.studentService = studentService;

            [HttpGet]
            [EnableQuery]
            public ActionResult<IQueryable<Student>> GetAllStudents()
            {
                IQueryable<Student> retrievedStudents =
                    this.studentService.RetrieveAllStudents();

                return Ok(retrievedStudents);
            }
        }
    }

