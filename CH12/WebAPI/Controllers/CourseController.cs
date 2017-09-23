using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class CourseController : ApiController
    {

        //繫結Model
        private static List<Course> courses = new List<Course>
        {
            new Course{id=1,Name="C#"},
            new Course{id=2,Name="VB"},
            new Course{id=3,Name="C++"},
            new Course{id=4,Name="Java"},
            new Course{id=5,Name="Javascript"},
            new Course{id=6,Name="MVC"},
            new Course{id=7,Name="JQuery"},
            new Course{id=8,Name="CSS3"},
            new Course{id=9,Name="HTML5"},
            new Course{id=10,Name="RWD"},
            new Course{id=11,Name="Node.js"}

        };




        // GET: api/Course
        public IEnumerable<Course> Get()
        {
            return courses;
        }

        // GET: api/Course/5
        public Course Get(int id)
        {
            var find_course = courses.Find(c => c.id == id);

            return find_course;
        }


        // POST: api/Course
        public void Post([FromBody]Course add_course)
        {
            courses.Add(add_course);
        }

        // PUT: api/Course/5
        public void Put(int id, [FromBody]Course edit_course)
        {
            var item = courses.Find(c => c.id == edit_course.id);
            item.Name = edit_course.Name;
            //如果是entity framework的話就是savechange之類的

        }

        // DELETE: api/Course/5
        public void Delete(int id)
        {
            var course = courses.Find(c => c.id == id);
            courses.Remove(course);
        }
    }
}
