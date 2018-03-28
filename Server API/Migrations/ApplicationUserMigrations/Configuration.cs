namespace Server_API.Migrations.ApplicationUserMigrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Server_API.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations\ApplicationUserMigrations";
        }

        protected override void Seed(Server_API.Models.ApplicationDbContext context)
        {
            var manager =
                   new UserManager<ApplicationUser>(
                   new UserStore<ApplicationUser>(context));

            var roleManager =
                new RoleManager<IdentityRole>(
                new RoleStore<IdentityRole>(context));

            roleManager.Create(new IdentityRole { Name = "Admin" });
            roleManager.Create(new IdentityRole { Name = "Instructor" });
            roleManager.Create(new IdentityRole { Name = "student" });

            context.Users.AddOrUpdate(u => u.UserName,
                new ApplicationUser
                {
                    UserName = "Admin",
                    Email = "s00015630@mail.itsligo.ie",
                    EmailConfirmed = true,
                    SecurityStamp = Guid.NewGuid().ToString(),
                    PasswordHash = new PasswordHasher().HashPassword("Moshea1$"),
                    FirstName = "Mark",
                    SecondName = "O Shea"
                }
                );


            context.Users.AddOrUpdate(u => u.UserName,
                new ApplicationUser
                {
                    UserName = "Instructor",
                    Email = "nauris@mail.itsligo.ie",
                    EmailConfirmed = true,
                    SecurityStamp = Guid.NewGuid().ToString(),
                    PasswordHash = new PasswordHasher().HashPassword("Neidulis1$"),
                    FirstName = "Nauris",
                    SecondName = "Eidulis"
                });

            ApplicationUser admin = manager.FindByEmail("s00015630@mail.itsligo.ie");
            if (admin != null)
            {
                manager.AddToRoles(admin.Id, new string[] { "Admin", "Instructor", "student" });
            }
            else
            {
                throw new Exception { Source = "Did not find admin" };
            }

            ApplicationUser instructor = manager.FindByEmail("nauris@mail.itsligo.ie");
            if(instructor !=null)
            {
                manager.AddToRoles(instructor.Id, new string[] { "Instructor", "student" });
            }
            else
            {
                throw new Exception { Source = "Did not find instructor" };
            }
        }
    }
}
