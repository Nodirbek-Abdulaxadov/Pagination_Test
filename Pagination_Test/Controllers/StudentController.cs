using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Pagination_Test.Data;
using Pagination_Test.Models;
using Pagination_Test.Services;

namespace Pagination_Test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentInterface studentInterface;

        public StudentController(IStudentInterface studentInterface) 
        {
            this.studentInterface = studentInterface;
        }
        [HttpGet("get")]
        public ActionResult<List<Student>> Get([FromQuery] StudentParametrs parametrs)
        {
            var listOfStudents = studentInterface.GetStudents(parametrs);

            var metaData = new
            {
                listOfStudents.TotalCount,
                listOfStudents.PageSize,
                listOfStudents.CurrentPage,
                listOfStudents.HasNext,
                listOfStudents.HasPrevious
            };

            Response.Headers.Add("X-Pagination", JsonConvert.SerializeObject(metaData));

            return Ok(listOfStudents);
        }

        [HttpGet("getall")]
        public IActionResult Get()
        {
            return Ok(studentInterface.GetStudents());
        }
    }
}
