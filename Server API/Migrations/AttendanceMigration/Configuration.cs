namespace Server_API.Migrations.AttendanceMigration
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Server_API.Models.StudentDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations\AttendanceMigration";
        }

        
        protected override void Seed(Server_API.Models.StudentDBContext context)
        {
            SeedStudents(context);
            SeedCourses(context);
            SeedInstructors(context);
            SeedEnrollments(context);
            SeedDelivery(context,
                            context.Courses.First(m => m.Name.Equals("Systems")),
                            context.Instructors.First(l => l.FirstName.Equals("Rodney")
                                                    && l.LastName.Equals("Mc Manus")));
            context.SaveChanges();
            base.Seed(context);
        }

        private void SeedDelivery(StudentDBContext context, Course course, Instructor lecturer)
        {


            string[] days = new string[] { "Mon", "Tues", "Wed", "Thurs", "Fri" };

            string day = days[new Random().Next(days.Count())];
            context.DeliveryOf.AddOrUpdate(d => new { d.InstrurctorID, d.CourseID, d.DayDelivered },
              new DeliveryOfCourse[] {
                    new DeliveryOfCourse {
                        DeliveredBy = lecturer,
                        DeliveryOf = course,
                        DayDelivered = day

                  } });

            context.SaveChanges();
        }


        private void SeedEnrollments(StudentDBContext context)
        {
            // get the first module
            var course = context.Courses.First();
            // get a random selection of students
            foreach (var student in GetRandomStudent(context, 10))
            {
                // enroll the students on the module
                context.Enrollments.AddOrUpdate(e => new { e.StudentID, e.CourseID },
                    new Enrollment[] {
                        new Enrollment { EnrolledStudent = student,
                                         EnrolledCourse = course,
                                        DateEnrolled = DateTime.Now
                        }
                    });
            }
            context.SaveChanges();
        }

        private Student[] GetRandomStudent(StudentDBContext Context, int count)
        {
            var randomids = Context.Students.Select(s => new { s.ID, order = Guid.NewGuid() })
                                    .OrderBy(o => o.order)
                                    .Select(s => s.ID);
            // take count where student record contains selected random ids
            return Context.Students.Where(s => randomids.Contains(s.ID))
                                   .Take(count).ToArray();

        }

        private void SeedInstructors(StudentDBContext context)
        {
            context.Instructors.AddOrUpdate(p => new { p.FirstName, p.LastName },
                new Instructor[]
                {
                    new Instructor { FirstName="Rodney", LastName="Mc Manus" },
                    new Instructor { FirstName="Trevor", LastName ="Gillen" },
                });
            context.SaveChanges();
        }

        private void SeedCourses(StudentDBContext context)
        {
            context.Courses.AddOrUpdate(s => s.Description,
                new Course[] {
                    new Course { Description = "Systems and Networking", Name="Systems"},
                    new Course { Description = "Software Development and Creative Computing", Name="Software Development"},
                    new Course { Description = "Web Development and Creative Computing", Name="Web Development"},
                     });
            context.SaveChanges();
        }

        private void SeedStudents(StudentDBContext context)
        {
            context.Students.AddOrUpdate(s => s.StudentNum,
                new Student[] {

                new Student
                {
                    FirstName = "John",
                    LastName = "JohnnyBoy",
                    StudentNum = "S0012345678",
                    Email = "S0012345678@mail.itsligo.ie"
                },
                new Student
                {
                    FirstName = "Han",
                    LastName = "HunBun",
                    StudentNum = "S008456345",
                    Email = "S008456345@mail.itsligo.ie"
                },
                new Student
                {
                    FirstName = "Harry",
                    LastName = "Hill",
                    StudentNum = "S008456775",
                    Email = "S008456345@mail.itsligo.ie"
                },
                new Student
                {
                    FirstName = "Sean",
                    LastName = "Giles",
                    StudentNum = "S008456399",
                    Email = "S008456345@mail.itsligo.ie"
                },
                new Student
                {
                    FirstName = "Mike",
                    LastName = "Micky",
                    StudentNum = "S00111111",
                    Email = "S00111111@mail.itsligo.ie"
                },
                new Student
                {
                    FirstName = "Mary",
                    LastName = "Burk",
                    StudentNum = "S00111222",
                    Email = "S00111222@mail.itsligo.ie"
                },
                new Student
                {
                    FirstName = "Tara",
                    LastName = "Dune",
                    StudentNum = "S00111333",
                    Email = "S00111333@mail.itsligo.ie"
                },
                new Student
                {
                    FirstName = "Wally",
                    LastName = "Meath",
                    StudentNum = "S00111444",
                    Email = "S00111444@mail.itsligo.ie"
                },
                new Student
                {
                    FirstName = "Fiona",
                    LastName = "Princess",
                    StudentNum = "S00111666",
                    Email = "S00111666@mail.itsligo.ie"
                },
                new Student
                {
                    FirstName = "hellna",
                    LastName = "JohnnyBoy",
                    StudentNum = "S0012345678",
                    Email = "S0012345678@mail.itsligo.ie"
                }
               });
            context.SaveChanges();
        }
    }
}
