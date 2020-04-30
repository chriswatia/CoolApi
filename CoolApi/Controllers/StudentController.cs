using CoolApi.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoolApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : Controller
    {
        
        //Create student context
        private StudentContext _studentContext;

        public StudentController(StudentContext context)
        {
            _studentContext = context;
        }

         // GET api/values
         [HttpGet]
        public ActionResult<IEnumerable<Student>> Get()
        {
            return _studentContext.Students.ToList();
        }

        //Get Student by Id
        [HttpGet]
        [Route("getbyid/{id}")]
        public ActionResult<Student> GetById(int? id)
        {
            if (id <= 0)
            {
                return NotFound("Student id must be greater than zero");
            }

            Student student = _studentContext.Students.FirstOrDefault(s => s.StudentId == id);
            if (student == null)
            {
                return NotFound("Student not found");
            }
            return Ok(student);
        }

        //Create student
        [HttpPost]
        public async Task<ActionResult> Post([FromBody]Student student)
        {
            if (student == null)
            {
                return NotFound("Student data is not supplied");
            }
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            await _studentContext.Students.AddAsync(student);
            await _studentContext.SaveChangesAsync();
            return Ok(student);
        }


        ~StudentController()
        {
            _studentContext.Dispose();
        }
    }
}
