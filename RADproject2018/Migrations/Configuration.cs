namespace RADproject2018.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Models;
    using System.Collections.Generic;

    internal sealed class Configuration : DbMigrationsConfiguration<RADproject2018.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(RADproject2018.Models.ApplicationDbContext context)
        {
            SeedStudent(context);
        }

        private void SeedStudent(ApplicationDbContext context)
        {
            var students = new List<Student>()
            {
                new Student {
                    FirstName = "John",
                    LastName = "JohnnyBoy",
                    StudentNum = "S0012345678",
                    Email = "S0012345678@mail.itsligo.ie"
                },
                new Student {
                    FirstName = "Han",
                    LastName = "HunBun",
                    StudentNum = "S008456345",
                    Email = "S008456345@mail.itsligo.ie"
                },
                new Student {
                    FirstName = "Mike",
                    LastName = "Micky",
                    StudentNum = "S00111111",
                    Email = "S00111111@mail.itsligo.ie"
                },
                new Student {
                    FirstName = "hellna",
                    LastName = "JohnnyBoy",
                    StudentNum = "S0012345678",
                    Email = "S0012345678@mail.itsligo.ie"
                }

            };
        }
        private void SeedCourses(ApplicationDbContext context)
        {
            /*
            var courses = new List<Course>()
            {
                new Course {
                    FirstName = "John",
                    LastName = "JohnnyBoy",
                    StudentNum = "S0012345678",
                    Email = "S0012345678@mail.itsligo.ie"
                },
                new Student {
                    FirstName = "Han",
                    LastName = "HunBun",
                    StudentNum = "S008456345",
                    Email = "S008456345@mail.itsligo.ie"
                },
                new Student {
                    FirstName = "Mike",
                    LastName = "Micky",
                    StudentNum = "S00111111",
                    Email = "S00111111@mail.itsligo.ie"
                },
                new Student {
                    FirstName = "hellna",
                    LastName = "JohnnyBoy",
                    StudentNum = "S0012345678",
                    Email = "S0012345678@mail.itsligo.ie"
                }

            };
            */
        }
    }
}
