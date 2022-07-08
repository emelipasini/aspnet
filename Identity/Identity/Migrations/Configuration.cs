namespace Identity.Migrations
{
    using IdentitySample.Models;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<IdentitySample.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(IdentitySample.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.
            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            var roleStore = new RoleStore<ApplicationRole>(context);
            var roleManager = new RoleManager<ApplicationRole>(roleStore);
            if(!context.Roles.Any(r => r.Name == "Admin"))
            {
                var role = new ApplicationRole
                {
                    Name = "Admin",
                    Description = "All permissions"
                };
                roleManager.Create(role);
            }
            if (!context.Roles.Any(r => r.Name == "Employee"))
            {
                var role = new ApplicationRole
                {
                    Name = "Employee",
                    Description = "Can only view their own information"
                };
                roleManager.Create(role);
            }

            var userStore = new UserStore<ApplicationUser>(context);
            var userManager = new UserManager<ApplicationUser>(userStore);
            var passwordHasher = new PasswordHasher();
            if(!context.Users.Any(u => u.UserName == "mg@company.com"))
            {
                var user = new ApplicationUser
                {
                    UserName = "mg@company.com",
                    Email = "mg@company.com",
                    Firstname = "Manuel",
                    Lastname = "Gutierrez",
                    PasswordHash = passwordHasher.HashPassword("Manuel123.")
                };
                userManager.Create(user);
                userManager.AddToRole(user.Id, "Admin");
            }
            if(!context.Users.Any(u => u.UserName == "fg@company.com"))
            {
                var user = new ApplicationUser
                {
                    UserName = "fg@company.com",
                    Email = "fg@company.com",
                    Firstname = "Florencia",
                    Lastname = "Gomez",
                    PasswordHash = passwordHasher.HashPassword("Florencia123.")
                };
                userManager.Create(user);
                userManager.AddToRole(user.Id, "Employee");
            }
        }
    }
}
