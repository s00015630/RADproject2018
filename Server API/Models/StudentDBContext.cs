using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Server_API.Models
{
    public class StudentDBContext : DbContext
    {
        public StudentDBContext() : base("DefaultConnection")
        {
            Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<TimeTable> TimeTables { get; set; }
        public DbSet<DeliveryOfCourse> DeliveryOf { get; set; }
        public DbSet<StudentAttendance> StudentAttendances { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Attendance> Attendances { get; set; }
        public DbSet<Assessement> Assessements { get; set; }
    }
    
}