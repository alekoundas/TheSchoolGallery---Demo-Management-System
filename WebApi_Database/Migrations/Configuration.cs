namespace WebApi_Database.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WebApi_Entities;
    using WebApi_Entities.Avatar;

    internal sealed class Configuration : DbMigrationsConfiguration<WebApi_Database.GalleryDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(WebApi_Database.GalleryDbContext context)
        {

            //                   Avatar Background                    \\
            AvatarBackground b1 = new AvatarBackground { ImageUrl = "C://sssssd" };
            AvatarBackground b2 = new AvatarBackground { ImageUrl = "C://ddddd" };
            AvatarBackground b3 = new AvatarBackground { ImageUrl = "C://fffff" };
            AvatarBackground b4 = new AvatarBackground { ImageUrl = "C://gggggg" };
            List<AvatarBackground> blist = new List<AvatarBackground> { b1, b2, b3, b4 };

            //                    Avatar Hair                        \\
            AvatarHair h1 = new AvatarHair { ImageUrl = "C://qqqqq" };
            AvatarHair h2 = new AvatarHair { ImageUrl = "C://wwwww" };
            AvatarHair h3 = new AvatarHair { ImageUrl = "C://eeeee" };
            AvatarHair h4 = new AvatarHair { ImageUrl = "C://rrrrr" };
            List<AvatarHair> hlist = new List<AvatarHair> { h1, h2, h3, h4 };

            //                    Avatar Body                        \\
            AvatarBody bd1 = new AvatarBody { ImageUrl = "C://zzzzzz" };
            AvatarBody bd2 = new AvatarBody { ImageUrl = "C://xxxxxx" };
            AvatarBody bd3 = new AvatarBody { ImageUrl = "C://cccccc" };
            AvatarBody bd4 = new AvatarBody { ImageUrl = "C://vvvvvv" };
            List<AvatarBody> bdlist = new List<AvatarBody> { bd1, bd2, bd3, bd4 };

            //                   Avatar Clothes                         \\
            AvatarClothes c1 = new AvatarClothes { ImageUrl = "C://pppppp" };
            AvatarClothes c2 = new AvatarClothes { ImageUrl = "C://oooooo" };
            AvatarClothes c3 = new AvatarClothes { ImageUrl = "C://iiiiii" };
            AvatarClothes c4 = new AvatarClothes { ImageUrl = "C://uuuuuu" };
            List<AvatarClothes> clist = new List<AvatarClothes> { c1, c2, c3, c4 };

            //                   Avatar                               \\
            Avatar a1 = new Avatar { Backgrounds = blist, Hairs = hlist, Bodys = bdlist, Clothes = clist };

            context.AvatarDb.AddOrUpdate(x => x.Title, a1);
            context.SaveChanges();






            //                        Teacher                           \\    
            Teacher t1 = new Teacher { FirstName = "John", LastName = "O'Neil", Avatar = a1 };
            Teacher t2 = new Teacher { FirstName = "Mary", LastName = "William" };
            Teacher t3 = new Teacher { FirstName = "Ethan", LastName = "Charles" };
            context.TeacherDb.AddOrUpdate(t1);
            context.TeacherDb.AddOrUpdate(t2);
            context.TeacherDb.AddOrUpdate(t3);


            //                        Student                           \\    
            Student s1 = new Student { FirstName = "James", LastName = "Hernandez", Age = 12 };
            Student s2 = new Student { FirstName = "David", LastName = "Smith", Age = 12 };
            Student s3 = new Student { FirstName = "Robert ", LastName = "Rodriguez", Age = 12 };
            Student s4 = new Student { FirstName = "Maria", LastName = "Garcia", Age = 12 };
        }
    }
}
