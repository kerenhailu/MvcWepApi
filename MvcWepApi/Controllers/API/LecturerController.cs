using MvcWepApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MvcWepApi.Controllers.API
{
    public class LecturerController : ApiController
    {
        List<Lecturer> lecturerList=new List<Lecturer>();
        // GET: api/Lecturer
        public IHttpActionResult Get()
        {
            return Ok(lecturerList);
        }

        // GET: api/Lecturer/5
        public IHttpActionResult Get(int id)
        {
            Lecturer lecturerById = lecturerList.Find(item => item.Id == id);
            return Ok(lecturerList);
        }

        // POST: api/Lecturer
        public IHttpActionResult Post([FromBody]Lecturer value)
        {
            lecturerList.Add(value);
            return Ok(lecturerList);
        }

        // PUT: api/Lecturer/5
        public IHttpActionResult Put(int id, [FromBody]Lecturer value)
        {
            Lecturer EaitLecturer = lecturerList.Find(item => item.Id == id);
            lecturerList[lecturerList.IndexOf(EaitLecturer)] = value;
            lecturerList[lecturerList.IndexOf(EaitLecturer)].Id = id;
            return Ok();
        }

        // DELETE: api/Lecturer/5
        public IHttpActionResult Delete(int id)
        {
            Lecturer LecturerToDelete = lecturerList.Find(item => item.Id == id);
            lecturerList.Remove(LecturerToDelete);
            return Ok();
        }
    }
}
