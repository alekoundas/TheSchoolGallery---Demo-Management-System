namespace Web_Front.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Web_Front.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Web_Front.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Web_Front.Models.ApplicationDbContext";
        }

        protected override void Seed(Web_Front.Models.ApplicationDbContext context)
        {
            // Create a new Application User -------------------------------------------------->>
            if (!context.Users.Any(u => u.UserName == "YioCho"))
            {
                // Connection With our DataBase
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser { UserName = "YioCho", Email = "tsormang@gmail.com" };
                manager.Create(user, "Aa123456789!");
            }

            // Create User Roles -------------------------------------------------------------->>
            string roleAdmin = "Admin";
            string emailAdmin = "admin@gmail.com";
            string passAdmin = "Admin123456789!";

            string roleSuperAdmin = "SuperAdmin";
            string emailSuperAdmin = "superadmin@gmail.com";
            string passSuperAdmin = "SuperAdmin123456789!";

            if (!context.Users.Any(u => u.UserName == "Admin") || !context.Users.Any(u => u.UserName == "SuperAdmin"))
            {

                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user1 = new ApplicationUser { UserName = emailAdmin, Email = emailAdmin };
                var user2 = new ApplicationUser { UserName = emailSuperAdmin, Email = emailSuperAdmin };

                manager.Create(user1, passAdmin);
                manager.Create(user2, passSuperAdmin);

                var roleStore = new RoleStore<IdentityRole>(context);
                var roleManager = new RoleManager<IdentityRole>(roleStore);
                var IdentityRole1 = new IdentityRole { Name = roleAdmin };
                var IdentityRole2 = new IdentityRole { Name = roleSuperAdmin };

                roleManager.Create(IdentityRole1);
                manager.AddToRole(user1.Id, roleAdmin);

                roleManager.Create(IdentityRole2);
                manager.AddToRole(user2.Id, roleSuperAdmin);


            }








        }
    }
}
