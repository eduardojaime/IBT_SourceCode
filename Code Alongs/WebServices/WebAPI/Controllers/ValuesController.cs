using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EFDataAccessLibrary;

namespace WebAPI.Controllers
{
    public class ValuesController : ApiController
    {
        // GET/POST/PATCH/DELETE
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        [HttpGet]
        [ActionName("GetFirstStudent")]
        public Student MyCustomMethod()
        {
            StudentsModel dbContext = new StudentsModel();

            return dbContext.Students.First();
        }

        [System.Web.Http.AcceptVerbs("GET", "POST")]
        public List<Student> GetStudentsList()
        {
            StudentsModel dbContext = new StudentsModel();

            return dbContext.Students.ToList();
        }

        [NonAction]
        public bool SendEmail()
        {
            return true;
        }
    }
}
