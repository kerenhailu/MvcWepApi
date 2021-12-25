using MvcWepApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MvcWepApi.Controllers.API
{
    public class StudentController : ApiController
    {
        List<Student> studentsList=new List<Student>();
        // GET: api/Student
        public IHttpActionResult Get()
        {
            return Ok(studentsList);
        }


        // GET: api/Student/5
        public IHttpActionResult Get(int id)
        {
            Student StudentById = studentsList.Find(item => item.Id == id);
            return Ok(StudentById);
        }

        // POST: api/Student
        public IHttpActionResult Post([FromBody]Student value)
        {
            studentsList.Add(value);
            return Ok(studentsList);
        }

        // PUT: api/Student/5
        public IHttpActionResult Put(int id, [FromBody]Student value)
        {
           Student EaitStudent= studentsList.Find(item => item.Id == id);
            studentsList[studentsList.IndexOf(EaitStudent)] = value;
            studentsList[studentsList.IndexOf(EaitStudent)].Id = id;
            return Ok();
        }

        // DELETE: api/Student/5
        public IHttpActionResult Delete(int id)
        {
            Student StudentToDelete = studentsList.Find(item => item.Id == id);
            studentsList.Remove(StudentToDelete);
            return Ok();
        }
    }
}
