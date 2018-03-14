namespace RADproject2018.Migrations.ApplicationUserMigrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<RADproject2018.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations\ApplicationUserMigrations";
        }

        protected override void Seed(RADproject2018.Models.ApplicationDbContext context)
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
                    FirstName ="Mark",
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
