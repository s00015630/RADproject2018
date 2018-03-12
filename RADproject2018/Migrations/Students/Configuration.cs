namespace RADproject2018.Migrations.Students
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<RADproject2018.Models.StudentDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            MigrationsDirectory = @"Migrations\Students";
        }

        protected override void Seed(RADproject2018.Models.StudentDBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            SeedStudent(context);
        }

        private void SeedStudent(StudentDBContext context)
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
    }
}

