using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi_Entities;
using WebApi_Entities.Avatar;

namespace WebApi_Database
{
    public class GalleryDbContext : DbContext
    {
        public GalleryDbContext() : base("name=ConnString")
        {

        }
        public DbSet<Avatar> AvatarDb { get; set; }
        public DbSet<AvatarBackground> AvatarBackgroundDb { get; set; }
        public DbSet<AvatarHair> AvatarHairDb { get; set; }
        public DbSet<AvatarBody> AvatarBodyDb { get; set; }
        public DbSet<AvatarClothes> AvatarClothesDb { get; set; }
        public DbSet<Student> StudentDb { get; set; }
        public DbSet<Teacher> TeacherDb { get; set; }

        public System.Data.Entity.DbSet<WebApi_Entities.Classroom> Classrooms { get; set; }

        public System.Data.Entity.DbSet<WebApi_Entities.School> Schools { get; set; }
    }
}
