using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using Server_API.Models;
using CommonObjects;

namespace Server_API.Controllers
{
    [RoutePrefix("api/Courses")]
    [Authorize(Roles = "Admin")]
    public class CoursesController : ApiController
    { 
        private StudentDBContext db = new StudentDBContext();

        // GET: api/Courses
        public IQueryable<CourseDTO> GetCourses()
        {
            var courses = from c in db.Courses
                          select new CourseDTO()
                          {
                              ID = c.ID,
                              Name = c.Name,
                              Description = c.Description
                          };
            return courses;
        }

        // GET: api/Courses/5
        [Authorize(Roles = "Instructor")] 
        [Route("getCourseById/{id}")]
        [ResponseType(typeof(CourseDTO))]
        public async Task<IHttpActionResult> GetCourse(int id)
        {
            var course = await db.Courses
                                .Select(c =>
                                new CourseDTO()
                                {
                                    ID = c.ID,
                                    Name = c.Name,
                                    Description = c.Description,
                                }).SingleOrDefaultAsync(c => c.ID == id);
            if(course == null)
            {
                return NotFound();
            }

            return Ok(course);
        }

        // PUT: api/Courses/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutCourse(int id, Course course)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != course.ID)
            {
                return BadRequest();
            }

            db.Entry(course).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CourseExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Courses
        [ResponseType(typeof(Course))]
        public async Task<IHttpActionResult> PostCourse(Course course)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Courses.Add(course);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = course.ID }, course);
        }

        // DELETE: api/Courses/5
        [ResponseType(typeof(Course))]
        public async Task<IHttpActionResult> DeleteCourse(int id)
        {
            Course course = await db.Courses.FindAsync(id);
            if (course == null)
            {
                return NotFound();
            }

            db.Courses.Remove(course);
            await db.SaveChangesAsync();

            return Ok(course);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CourseExists(int id)
        {
            return db.Courses.Count(e => e.ID == id) > 0;
        }
    }
}