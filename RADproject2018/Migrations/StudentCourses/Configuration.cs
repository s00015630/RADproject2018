namespace RADproject2018.Migrations.StudentCourses
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<RADproject2018.Models.StudentDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations\StudentCourses";
        }

        protected override void Seed(RADproject2018.Models.StudentDBContext context)
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
                    FirstName = "Mike",
                    LastName = "Micky",
                    StudentNum = "S00111111",
                    Email = "S00111111@mail.itsligo.ie"
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

            context.Courses.AddOrUpdate(s => s.Description,
                new Course[] {
                    new Course { Description = "Software Development and Creative Computing", Name="Software Development", Term="1", Type="4 Years"},
                    new Course { Description = "Web Development and Creative Computing", Name="Web Development", Term="1", Type="3 Years"},
                    new Course { Description = "Systems and Networking", Name="Systems", Term="1", Type="3 Years"},
                     });
            context.SaveChanges();
        }
    }
}
