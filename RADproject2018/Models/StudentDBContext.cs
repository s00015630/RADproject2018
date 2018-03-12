using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RADproject2018.Models
{
    public class StudentDBContext : DbContext
    {
        public StudentDBContext() : base("RADproject2018")
        {
            Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<TimeTable> TimeTables { get; set; }
        public DbSet<Section> Sections { get; set; }
        public DbSet<Score> Scores { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Attendance> Attendances { get; set; }
        public DbSet<Assessement> Assessements { get; set; }
    }
}