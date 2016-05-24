using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using SecretProject.Models;

namespace SecretProject.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SecretProject.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "SecretProject.Models.ApplicationDbContext";
        }

        protected override void Seed(SecretProject.Models.ApplicationDbContext context)
        {
            //var hasher = new PasswordHasher();
            //context.Users.AddOrUpdate(u => u.Email,
            //    new ApplicationUser { Email = "default@test.com", PasswordHash = hasher.HashPassword("Test.123")});

            if (!context.Users.Any(u => u.Email == "default@test.com"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser { Email = "default@test.com" };

                manager.Create(user, "Test.123");
            }
        }
    }
}
