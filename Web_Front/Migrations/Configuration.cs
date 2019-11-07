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
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Web_Front.Models.ApplicationDbContext context)
        {
            // Create User Roles -------------------------------------------------------------->>
            string roleAdmin = "Admin";
            string emailAdmin = "admin@gmail.com";
            string passAdmin = "Admin123456789!";

            string roleSchoolAdmin = "SchoolAdmin";
            string emailSchoolAdmin = "schooladmin@gmail.com";
            string passSchoolAdmin = "Schoolmaster123!";

            if (!context.Users.Any(u => u.UserName == "Admin") || !context.Users.Any(u => u.UserName == "SchoolAdmin"))
            {

                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user1 = new ApplicationUser { UserName = roleAdmin, Email = emailAdmin };
                var user2 = new ApplicationUser { UserName = roleSchoolAdmin, Email = emailSchoolAdmin };

                manager.Create(user1, passAdmin);
                manager.Create(user2, passSchoolAdmin);

                var roleStore = new RoleStore<IdentityRole>(context);
                var roleManager = new RoleManager<IdentityRole>(roleStore);
                var IdentityRole1 = new IdentityRole { Name = roleAdmin };
                var IdentityRole2 = new IdentityRole { Name = roleSchoolAdmin };

                roleManager.Create(IdentityRole1);
                manager.AddToRole(user1.Id, roleAdmin);

                roleManager.Create(IdentityRole2);
                manager.AddToRole(user2.Id, roleSchoolAdmin);


            }
        }
    }
}
