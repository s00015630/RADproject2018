namespace Server_API.Migrations.ApplicationMigrations
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
            MigrationsDirectory = @"Migrations\ApplicationMigrations";
        }

        protected override void Seed(Server_API.Models.ApplicationDbContext context)
        {
            var manager =
                  new UserManager<ApplicationUser>(
                      new UserStore<ApplicationUser>(context));

            var roleManager =
                new RoleManager<IdentityRole>(
                    new RoleStore<IdentityRole>(context));

            roleManager.Create(new IdentityRole { Name = "Administrator Manager" });

            context.Users.AddOrUpdate(u => u.UserName,
                new ApplicationUser
                {
                    UserName = "s00015630",
                    Email = "s00015630@mail.itsligo.ie",
                    EmailConfirmed = true,
                    SecurityStamp = Guid.NewGuid().ToString(),
                    PasswordHash = new PasswordHasher().HashPassword("s00015630$"),
                    FirstName = "Mark",
                    SecondName = "O Shea"
                }
                );

            context.SaveChanges();
            var s00015630 = manager.FindByName("s00015630");
            manager.AddToRole(s00015630.Id, "Administrator Manager");
            context.SaveChanges();
        }
    }
}
