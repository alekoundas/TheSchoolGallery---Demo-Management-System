using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Web_Front.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(): base("ConnString", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public System.Data.Entity.DbSet<Web_DomainClasses.Entities.School.Teacher> TeachersDb { get; set; }
        public System.Data.Entity.DbSet<Web_DomainClasses.Entities.School.Painting> PaintingDb { get; set; }
        public System.Data.Entity.DbSet<Web_DomainClasses.Entities.School.Classroom> ClassroomDb { get; set; }
        public System.Data.Entity.DbSet<Web_DomainClasses.Entities.School.School> SchoolDb { get; set; }
        public System.Data.Entity.DbSet<Web_DomainClasses.Entities.School.Student> Students { get; set; }
        public System.Data.Entity.DbSet<Web_DomainClasses.Entities.Avatar.Avatar> Avatars { get; set; }
        public System.Data.Entity.DbSet<Web_DomainClasses.Entities.Avatar.AvatarBackground> AvatarBackgrounds { get; set; }
        public System.Data.Entity.DbSet<Web_DomainClasses.Entities.Avatar.AvatarBody> AvatarBodies { get; set; }
        public System.Data.Entity.DbSet<Web_DomainClasses.Entities.Avatar.AvatarClothing> AvatarClothes { get; set; }
        public System.Data.Entity.DbSet<Web_DomainClasses.Entities.Avatar.AvatarHair> AvatarHairs { get; set; }
    }
}