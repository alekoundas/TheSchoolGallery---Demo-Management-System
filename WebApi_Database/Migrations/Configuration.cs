namespace WebApi_Database.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Validation;
    using System.Diagnostics;
    using System.Linq;
    using WebApi_Entities;
    using WebApi_Entities.Avatar;
    using WebApi_Entities.School;

    internal sealed class Configuration : DbMigrationsConfiguration<WebApi_Database.GalleryDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(WebApi_Database.GalleryDbContext context)
        {


            //                                                                      //
            //              SOS UNCOMENT EVERYTHING BELOW ONLY ONCE !!!             //
            //                                                                      //            










            //                   Avatar Background                    \\
            AvatarBackground b01 = new AvatarBackground { ImageUrl = "back_01.png" };
            AvatarBackground b02 = new AvatarBackground { ImageUrl = "back_02.png" };
            AvatarBackground b03 = new AvatarBackground { ImageUrl = "back_03.png" };
            AvatarBackground b04 = new AvatarBackground { ImageUrl = "back_04.png" };
            AvatarBackground b05 = new AvatarBackground { ImageUrl = "back_05.png" };
            AvatarBackground b06 = new AvatarBackground { ImageUrl = "back_06.png" };
            AvatarBackground b07 = new AvatarBackground { ImageUrl = "back_07.png" };
            AvatarBackground b08 = new AvatarBackground { ImageUrl = "back_08.png" };
            AvatarBackground b09 = new AvatarBackground { ImageUrl = "back_09.png" };
            List<AvatarBackground> blist = new List<AvatarBackground> { b01, b02, b03, b04, b05, b06, b07, b08, b09 };

            //                    Avatar Hair                        \\
            AvatarHair h01 = new AvatarHair { ImageUrl = "hair_01.png" };
            AvatarHair h02 = new AvatarHair { ImageUrl = "hair_02.png" };
            AvatarHair h03 = new AvatarHair { ImageUrl = "hair_03.png" };
            AvatarHair h04 = new AvatarHair { ImageUrl = "hair_04.png" };
            AvatarHair h05 = new AvatarHair { ImageUrl = "hair_05.png" };
            AvatarHair h06 = new AvatarHair { ImageUrl = "hair_06.png" };
            List<AvatarHair> hlist = new List<AvatarHair> { h01, h02, h03, h04, h05, h06 };

            //                    Avatar Body                        \\
            AvatarBody bd01 = new AvatarBody { ImageUrl = "body_01.png" };
            AvatarBody bd02 = new AvatarBody { ImageUrl = "body_02.png" };
            AvatarBody bd03 = new AvatarBody { ImageUrl = "body_03.png" };
            List<AvatarBody> bdlist = new List<AvatarBody> { bd01, bd02, bd03 };

            //                   Avatar Clothes                         \\
            AvatarClothes c01 = new AvatarClothes { ImageUrl = "clothes_01.png" };
            AvatarClothes c02 = new AvatarClothes { ImageUrl = "clothes_02.png" };
            List<AvatarClothes> clist = new List<AvatarClothes> { c01, c02 };

            // AVATAR ------------------------------------------------------------------------------->>  
            Avatar a1 = new Avatar { Backgrounds = blist, Hairs = hlist, Bodys = bdlist, Clothes = clist };

            context.AvatarDb.AddOrUpdate(x => x.Title, a1);
            //context.SaveChanges();

            // TEACHER ------------------------------------------------------------------------------->>  
            Teacher t01 = new Teacher { TeacherId = 01, FirstName = "Mpampis", LastName = "Sougias", Avatar = a1 };
            Teacher t02 = new Teacher { TeacherId = 02, FirstName = "Maria", LastName = "Omorfi", Avatar = a1 };
            Teacher t03 = new Teacher { TeacherId = 03, FirstName = "Nikolas", LastName = "Tipotas", Avatar = a1 };
            Teacher t04 = new Teacher { TeacherId = 04, FirstName = "Dioni", LastName = "Marka", Avatar = a1 };
            Teacher t05 = new Teacher { TeacherId = 05, FirstName = "Yioo", LastName = "Choo", Avatar = a1 };
            Teacher t06 = new Teacher { TeacherId = 06, FirstName = "Alex", LastName = "Laeder", Avatar = a1 };
            Teacher t07 = new Teacher { TeacherId = 07, FirstName = "Josef", LastName = "Josefou", Avatar = a1 };
            Teacher t08 = new Teacher { TeacherId = 08, FirstName = "Vaggelis", LastName = "Maxairas", Avatar = a1 };
            Teacher t09 = new Teacher { TeacherId = 09, FirstName = "Nikolas", LastName = "Fonias", Avatar = a1 };
            Teacher t10 = new Teacher { TeacherId = 10, FirstName = "Afroditi", LastName = "Koukla", Avatar = a1 };
            Teacher t11 = new Teacher { TeacherId = 11, FirstName = "Jessica", LastName = "Bearit", Avatar = a1 };
            Teacher t12 = new Teacher { TeacherId = 12, FirstName = "Kostas", LastName = "Ntounias", Avatar = a1 };
            Teacher t13 = new Teacher { TeacherId = 13, FirstName = "Giannis", LastName = "Mpampinis", Avatar = a1 };
            Teacher t14 = new Teacher { TeacherId = 14, FirstName = "Alex", LastName = "Smith", Avatar = a1 };

            //Unecessary...Classroom will Crerate Them
            //context.TeacherDb.AddOrUpdate(x => x.TeacherId, t01);
            //context.TeacherDb.AddOrUpdate(x => x.TeacherId, t02);
            //context.TeacherDb.AddOrUpdate(x => x.TeacherId, t03);
            //context.TeacherDb.AddOrUpdate(x => x.TeacherId, t04);
            //context.TeacherDb.AddOrUpdate(x => x.TeacherId, t05);
            //context.TeacherDb.AddOrUpdate(x => x.TeacherId, t06);
            //context.TeacherDb.AddOrUpdate(x => x.TeacherId, t07);
            //context.TeacherDb.AddOrUpdate(x => x.TeacherId, t08);
            //context.TeacherDb.AddOrUpdate(x => x.TeacherId, t09);
            //context.TeacherDb.AddOrUpdate(x => x.TeacherId, t10);
            //context.TeacherDb.AddOrUpdate(x => x.TeacherId, t11);
            //context.TeacherDb.AddOrUpdate(x => x.TeacherId, t12);
            //context.TeacherDb.AddOrUpdate(x => x.TeacherId, t13);
            //context.TeacherDb.AddOrUpdate(x => x.TeacherId, t14);
            //context.SaveChanges();

            // PAINTINGS ------------------------------------------------------------------------------->>  
            Painting p01 = new Painting { ImageUrl = "painting_001.jpg", PaintingTitle = "I am Title", Price = 1 };
            Painting p02 = new Painting { ImageUrl = "painting_002.jpg", PaintingTitle = "I am Title", Price = 1 };
            Painting p03 = new Painting { ImageUrl = "painting_003.jpg", PaintingTitle = "I am Title", Price = 1 };
            Painting p04 = new Painting { ImageUrl = "painting_004.jpg", PaintingTitle = "I am Title", Price = 1 };
            Painting p05 = new Painting { ImageUrl = "painting_005.jpg", PaintingTitle = "I am Title", Price = 1 };
            Painting p06 = new Painting { ImageUrl = "painting_006.jpg", PaintingTitle = "I am Title", Price = 1 };
            Painting p07 = new Painting { ImageUrl = "painting_007.jpg", PaintingTitle = "I am Title", Price = 1 };
            Painting p08 = new Painting { ImageUrl = "painting_008.jpg", PaintingTitle = "I am Title", Price = 1 };
            Painting p09 = new Painting { ImageUrl = "painting_009.jpg", PaintingTitle = "I am Title", Price = 1 };

            Painting p10 = new Painting { ImageUrl = "painting_010.jpg", PaintingTitle = "I am Title", Price = 1 };
            Painting p11 = new Painting { ImageUrl = "painting_011.jpg", PaintingTitle = "I am Title", Price = 1 };
            Painting p12 = new Painting { ImageUrl = "painting_012.jpg", PaintingTitle = "I am Title", Price = 1 };
            Painting p13 = new Painting { ImageUrl = "painting_013.jpg", PaintingTitle = "I am Title", Price = 1 };
            Painting p14 = new Painting { ImageUrl = "painting_014.jpg", PaintingTitle = "I am Title", Price = 1 };
            Painting p15 = new Painting { ImageUrl = "painting_015.jpg", PaintingTitle = "I am Title", Price = 1 };
            Painting p16 = new Painting { ImageUrl = "painting_016.jpg", PaintingTitle = "I am Title", Price = 1 };
            Painting p17 = new Painting { ImageUrl = "painting_017.jpg", PaintingTitle = "I am Title", Price = 1 };
            Painting p18 = new Painting { ImageUrl = "painting_018.jpg", PaintingTitle = "I am Title", Price = 1 };
            Painting p19 = new Painting { ImageUrl = "painting_019.jpg", PaintingTitle = "I am Title", Price = 1 };

            Painting p20 = new Painting { ImageUrl = "painting_020.jpg", PaintingTitle = "I am Title", Price = 1 };
            Painting p21 = new Painting { ImageUrl = "painting_021.jpg", PaintingTitle = "I am Title", Price = 1 };
            Painting p22 = new Painting { ImageUrl = "painting_022.jpg", PaintingTitle = "I am Title", Price = 1 };
            Painting p23 = new Painting { ImageUrl = "painting_023.jpg", PaintingTitle = "I am Title", Price = 1 };
            Painting p24 = new Painting { ImageUrl = "painting_024.jpg", PaintingTitle = "I am Title", Price = 1 };
            Painting p25 = new Painting { ImageUrl = "painting_025.jpg", PaintingTitle = "I am Title", Price = 1 };
            Painting p26 = new Painting { ImageUrl = "painting_026.jpg", PaintingTitle = "I am Title", Price = 1 };
            Painting p27 = new Painting { ImageUrl = "painting_027.jpg", PaintingTitle = "I am Title", Price = 1 };
            Painting p28 = new Painting { ImageUrl = "painting_028.jpg", PaintingTitle = "I am Title", Price = 1 };
            Painting p29 = new Painting { ImageUrl = "painting_029.jpg", PaintingTitle = "I am Title", Price = 1 };

            Painting p30 = new Painting { ImageUrl = "painting_030.jpg", PaintingTitle = "I am Title", Price = 1 };
            Painting p31 = new Painting { ImageUrl = "painting_031.jpg", PaintingTitle = "I am Title", Price = 1 };
            Painting p32 = new Painting { ImageUrl = "painting_032.jpg", PaintingTitle = "I am Title", Price = 1 };
            Painting p33 = new Painting { ImageUrl = "painting_033.jpg", PaintingTitle = "I am Title", Price = 1 };
            Painting p34 = new Painting { ImageUrl = "painting_034.jpg", PaintingTitle = "I am Title", Price = 1 };
            Painting p35 = new Painting { ImageUrl = "painting_035.jpg", PaintingTitle = "I am Title", Price = 1 };
            Painting p36 = new Painting { ImageUrl = "painting_036.jpg", PaintingTitle = "I am Title", Price = 1 };
            Painting p37 = new Painting { ImageUrl = "painting_037.jpg", PaintingTitle = "I am Title", Price = 1 };
            Painting p38 = new Painting { ImageUrl = "painting_038.jpg", PaintingTitle = "I am Title", Price = 1 };
            Painting p39 = new Painting { ImageUrl = "painting_039.jpg", PaintingTitle = "I am Title", Price = 1 };

            Painting p40 = new Painting { ImageUrl = "painting_040.jpg", PaintingTitle = "I am Title", Price = 1 };
            Painting p41 = new Painting { ImageUrl = "painting_041.jpg", PaintingTitle = "I am Title", Price = 1 };
            Painting p42 = new Painting { ImageUrl = "painting_042.jpg", PaintingTitle = "I am Title", Price = 1 };
            Painting p43 = new Painting { ImageUrl = "painting_043.jpg", PaintingTitle = "I am Title", Price = 1 };
            Painting p44 = new Painting { ImageUrl = "painting_044.jpg", PaintingTitle = "I am Title", Price = 1 };
            Painting p45 = new Painting { ImageUrl = "painting_045.jpg", PaintingTitle = "I am Title", Price = 1 };
            Painting p46 = new Painting { ImageUrl = "painting_046.jpg", PaintingTitle = "I am Title", Price = 1 };
            Painting p47 = new Painting { ImageUrl = "painting_047.jpg", PaintingTitle = "I am Title", Price = 1 };
            Painting p48 = new Painting { ImageUrl = "painting_048.jpg", PaintingTitle = "I am Title", Price = 1 };
            Painting p49 = new Painting { ImageUrl = "painting_049.jpg", PaintingTitle = "I am Title", Price = 1 };

            Painting p50 = new Painting { ImageUrl = "painting_050.jpg", PaintingTitle = "I am Title", Price = 1 };
            Painting p51 = new Painting { ImageUrl = "painting_051.jpg", PaintingTitle = "I am Title", Price = 1 };
            Painting p52 = new Painting { ImageUrl = "painting_052.jpg", PaintingTitle = "I am Title", Price = 1 };
            Painting p53 = new Painting { ImageUrl = "painting_053.jpg", PaintingTitle = "I am Title", Price = 1 };
            Painting p54 = new Painting { ImageUrl = "painting_054.jpg", PaintingTitle = "I am Title", Price = 1 };
            Painting p55 = new Painting { ImageUrl = "painting_055.jpg", PaintingTitle = "I am Title", Price = 1 };
            Painting p56 = new Painting { ImageUrl = "painting_056.jpg", PaintingTitle = "I am Title", Price = 1 };
            Painting p57 = new Painting { ImageUrl = "painting_057.jpg", PaintingTitle = "I am Title", Price = 1 };
            Painting p58 = new Painting { ImageUrl = "painting_058.jpg", PaintingTitle = "I am Title", Price = 1 };
            Painting p59 = new Painting { ImageUrl = "painting_059.jpg", PaintingTitle = "I am Title", Price = 1 };

            Painting p60 = new Painting { ImageUrl = "painting_060.jpg", PaintingTitle = "I am Title", Price = 1 };


            // STUDENTS ------------------------------------------------------------------------------->>  
            Student s01 = new Student { StudentId = 01, Paintings = new List<Painting> { p01 }, FirstName = "James", LastName = "Hernandez", Age = 5, Avatar = a1 };
            Student s02 = new Student { StudentId = 02, Paintings = new List<Painting> { p02 }, FirstName = "David", LastName = "Smith", Age = 5, Avatar = a1 };
            Student s03 = new Student { StudentId = 03, Paintings = new List<Painting> { p03 }, FirstName = "Robert", LastName = "Rodriguez", Age = 5, Avatar = a1 };
            Student s04 = new Student { StudentId = 04, Paintings = new List<Painting> { p04 }, FirstName = "Maria", LastName = "Garcia", Age = 5, Avatar = a1 };
            Student s05 = new Student { StudentId = 05, Paintings = new List<Painting> { p05 }, FirstName = "Fumiko", LastName = "Koyama", Age = 5, Avatar = a1 };
            Student s06 = new Student { StudentId = 06, Paintings = new List<Painting> { p06 }, FirstName = "Ryoya", LastName = "Urehara", Age = 5, Avatar = a1 };
            Student s07 = new Student { StudentId = 07, Paintings = new List<Painting> { p07 }, FirstName = "Kim", LastName = "Yun", Age = 5, Avatar = a1 };
            Student s08 = new Student { StudentId = 08, Paintings = new List<Painting> { p08 }, FirstName = "Fael", LastName = "Faery", Age = 5, Avatar = a1 };
            Student s09 = new Student { StudentId = 09, Paintings = new List<Painting> { p09 }, FirstName = "Amanda", LastName = "Diamond", Age = 5, Avatar = a1 };
            Student s10 = new Student { StudentId = 10, Paintings = new List<Painting> { p10 }, FirstName = "Michael", LastName = "Shumy", Age = 5, Avatar = a1 };
            Student s11 = new Student { StudentId = 11, Paintings = new List<Painting> { p11 }, FirstName = "Will", LastName = "Smooth", Age = 6, Avatar = a1 };
            Student s12 = new Student { StudentId = 12, Paintings = new List<Painting> { p12 }, FirstName = "Bob", LastName = "Sfougg", Age = 6, Avatar = a1 };
            Student s13 = new Student { StudentId = 13, Paintings = new List<Painting> { p13 }, FirstName = "Jenny", LastName = "Ntouzi", Age = 6, Avatar = a1 };
            Student s14 = new Student { StudentId = 14, Paintings = new List<Painting> { p14 }, FirstName = "Mathiew", LastName = "MacTrack", Age = 6, Avatar = a1 };
            Student s15 = new Student { StudentId = 15, Paintings = new List<Painting> { p15 }, FirstName = "Mairy", LastName = "Pops", Age = 6, Avatar = a1 };
            Student s16 = new Student { StudentId = 16, Paintings = new List<Painting> { p16 }, FirstName = "Triplos", LastName = "Kakos", Age = 6, Avatar = a1 };
            Student s17 = new Student { StudentId = 17, Paintings = new List<Painting> { p17 }, FirstName = "Diplos", LastName = "Arithmos", Age = 6, Avatar = a1 };
            Student s18 = new Student { StudentId = 18, Paintings = new List<Painting> { p18 }, FirstName = "Monos", LastName = "Erimos", Age = 6, Avatar = a1 };
            Student s19 = new Student { StudentId = 19, Paintings = new List<Painting> { p19 }, FirstName = "Notis", LastName = "Sfakias", Age = 6, Avatar = a1 };
            Student s20 = new Student { StudentId = 20, Paintings = new List<Painting> { p20 }, FirstName = "Lookia", LastName = "Kelaidoni", Age = 7, Avatar = a1 };
            Student s21 = new Student { StudentId = 21, Paintings = new List<Painting> { p21 }, FirstName = "Mairy", LastName = "Dounia", Age = 7, Avatar = a1 };
            Student s22 = new Student { StudentId = 22, Paintings = new List<Painting> { p22 }, FirstName = "Xristina", LastName = "Mama", Age = 7, Avatar = a1 };
            Student s23 = new Student { StudentId = 23, Paintings = new List<Painting> { p23 }, FirstName = "Jenny", LastName = "Mpotsi", Age = 7, Avatar = a1 };
            Student s24 = new Student { StudentId = 24, Paintings = new List<Painting> { p24 }, FirstName = "Zozo", LastName = "Markoulaki", Age = 7, Avatar = a1 };
            Student s25 = new Student { StudentId = 25, Paintings = new List<Painting> { p25 }, FirstName = "Babis", LastName = "Lipsos", Age = 7, Avatar = a1 };
            Student s26 = new Student { StudentId = 26, Paintings = new List<Painting> { p26 }, FirstName = "Volos", LastName = "Mpilias", Age = 6, Avatar = a1 };
            Student s27 = new Student { StudentId = 27, Paintings = new List<Painting> { p27 }, FirstName = "Yiorgos", LastName = "Georgiou", Age = 7, Avatar = a1 };
            Student s28 = new Student { StudentId = 28, Paintings = new List<Painting> { p28 }, FirstName = "Ioannis", LastName = "Xaros", Age = 7, Avatar = a1 };
            Student s29 = new Student { StudentId = 29, Paintings = new List<Painting> { p29 }, FirstName = "Vaggelis", LastName = "Giortis", Age = 7, Avatar = a1 };
            Student s30 = new Student { StudentId = 30, Paintings = new List<Painting> { p30 }, FirstName = "Artemis", LastName = "Matsas", Age = 8, Avatar = a1 };
            Student s31 = new Student { StudentId = 31, Paintings = new List<Painting> { p31 }, FirstName = "Iosif", LastName = "Pateras", Age = 8, Avatar = a1 };
            Student s32 = new Student { StudentId = 32, Paintings = new List<Painting> { p32 }, FirstName = "Kostas", LastName = "Karagkounis", Age = 8, Avatar = a1 };
            Student s33 = new Student { StudentId = 33, Paintings = new List<Painting> { p33 }, FirstName = "Elias", LastName = "Apalou", Age = 8, Avatar = a1 };
            Student s34 = new Student { StudentId = 34, Paintings = new List<Painting> { p34 }, FirstName = "Ektoras", LastName = "Limnios", Age = 8, Avatar = a1 };
            Student s35 = new Student { StudentId = 35, Paintings = new List<Painting> { p35 }, FirstName = "Ifigeneia", LastName = "Grevena", Age = 8, Avatar = a1 };
            Student s36 = new Student { StudentId = 36, Paintings = new List<Painting> { p36 }, FirstName = "Manolis", LastName = "Kairos", Age = 8, Avatar = a1 };
            Student s37 = new Student { StudentId = 37, Paintings = new List<Painting> { p37 }, FirstName = "Giannis", LastName = "Xromas", Age = 9, Avatar = a1 };
            Student s38 = new Student { StudentId = 38, Paintings = new List<Painting> { p38 }, FirstName = "Nikos", LastName = "Gkagkas", Age = 9, Avatar = a1 };
            Student s39 = new Student { StudentId = 39, Paintings = new List<Painting> { p39 }, FirstName = "Yiorgos", LastName = "Dedes", Age = 9, Avatar = a1 };
            Student s40 = new Student { StudentId = 40, Paintings = new List<Painting> { p40 }, FirstName = "Betty", LastName = "Mpantianou", Age = 9, Avatar = a1 };
            Student s41 = new Student { StudentId = 41, Paintings = new List<Painting> { p41 }, FirstName = "Michalis", LastName = "Karydas", Age = 9, Avatar = a1 };
            Student s42 = new Student { StudentId = 42, Paintings = new List<Painting> { p42 }, FirstName = "Rea Ifigeneia", LastName = "Chorman", Age = 9, Avatar = a1 };
            Student s43 = new Student { StudentId = 43, Paintings = new List<Painting> { p43 }, FirstName = "Johnnys", LastName = "Perpatitis", Age = 8, Avatar = a1 };
            Student s44 = new Student { StudentId = 44, Paintings = new List<Painting> { p44 }, FirstName = "Dimitris", LastName = "Lymperis", Age = 10, Avatar = a1 };
            Student s45 = new Student { StudentId = 45, Paintings = new List<Painting> { p45 }, FirstName = "Filippas", LastName = "Mpitsis", Age = 8, Avatar = a1 };
            Student s46 = new Student { StudentId = 46, Paintings = new List<Painting> { p46 }, FirstName = "Alexis", LastName = "Prothypos", Age = 8, Avatar = a1 };
            Student s47 = new Student { StudentId = 47, Paintings = new List<Painting> { p47 }, FirstName = "Konstantinos", LastName = "Torinos", Age = 10, Avatar = a1 };
            Student s48 = new Student { StudentId = 48, Paintings = new List<Painting> { p48 }, FirstName = "Maria", LastName = "Maraki", Age = 10, Avatar = a1 };
            Student s49 = new Student { StudentId = 49, Paintings = new List<Painting> { p49 }, FirstName = "Katerina", LastName = "Vafeidi", Age = 10, Avatar = a1 };
            Student s50 = new Student { StudentId = 50, Paintings = new List<Painting> { p50 }, FirstName = "Vaggelitsa", LastName = "Grylou", Age = 9, Avatar = a1 };
            Student s51 = new Student { StudentId = 51, Paintings = new List<Painting> { p51 }, FirstName = "Hector", LastName = "Gatsos", Age = 9, Avatar = a1 };
            Student s52 = new Student { StudentId = 52, Paintings = new List<Painting> { p52 }, FirstName = "Mike", LastName = "Lawry", Age = 9, Avatar = a1 };
            Student s53 = new Student { StudentId = 53, Paintings = new List<Painting> { p53 }, FirstName = "Vanessa", LastName = "Smith", Age = 10, Avatar = a1 };
            Student s54 = new Student { StudentId = 54, Paintings = new List<Painting> { p54 }, FirstName = "Maria", LastName = "Mpihi", Age = 10, Avatar = a1 };
            Student s55 = new Student { StudentId = 55, Paintings = new List<Painting> { p55 }, FirstName = "Kostas", LastName = "Malamoutis", Age = 10, Avatar = a1 };
            Student s56 = new Student { StudentId = 56, Paintings = new List<Painting> { p56 }, FirstName = "Yiannis", LastName = "Noaa", Age = 10, Avatar = a1 };
            Student s57 = new Student { StudentId = 57, Paintings = new List<Painting> { p57 }, FirstName = "Kaori", LastName = "Koyama", Age = 10, Avatar = a1 };
            Student s58 = new Student { StudentId = 58, Paintings = new List<Painting> { p58 }, FirstName = "Jessica", LastName = "Nian", Age = 10, Avatar = a1 };
            Student s59 = new Student { StudentId = 59, Paintings = new List<Painting> { p59 }, FirstName = "Biki", LastName = "Valgeri", Age = 10, Avatar = a1 };
            Student s60 = new Student { StudentId = 60, Paintings = new List<Painting> { p60 }, FirstName = "Ifigeneia", LastName = "Fotopoulou", Age = 11, Avatar = a1 };

            //Unecessary...Classroom will Crerate Them

            //context.StudentDb.AddOrUpdate(x=>x.StudentId,s01);
            //context.StudentDb.AddOrUpdate(x=>x.StudentId,s02);
            //context.StudentDb.AddOrUpdate(x=>x.StudentId,s03);
            //context.StudentDb.AddOrUpdate(x=>x.StudentId,s04);
            //context.StudentDb.AddOrUpdate(x=>x.StudentId,s05);
            //context.StudentDb.AddOrUpdate(x=>x.StudentId,s06);
            //context.StudentDb.AddOrUpdate(x=>x.StudentId,s07);
            //context.StudentDb.AddOrUpdate(x=>x.StudentId,s08);
            //context.StudentDb.AddOrUpdate(x=>x.StudentId,s09);
            //context.StudentDb.AddOrUpdate(x=>x.StudentId,s10);
            //context.StudentDb.AddOrUpdate(x=>x.StudentId,s11);
            //context.StudentDb.AddOrUpdate(x=>x.StudentId,s12);
            //context.StudentDb.AddOrUpdate(x=>x.StudentId,s13);
            //context.StudentDb.AddOrUpdate(x=>x.StudentId,s14);
            //context.StudentDb.AddOrUpdate(x=>x.StudentId,s15);
            //context.StudentDb.AddOrUpdate(x=>x.StudentId,s16);
            //context.StudentDb.AddOrUpdate(x=>x.StudentId,s17);
            //context.StudentDb.AddOrUpdate(x=>x.StudentId,s18);
            //context.StudentDb.AddOrUpdate(x=>x.StudentId,s19);
            //context.StudentDb.AddOrUpdate(x=>x.StudentId,s20);
            //context.StudentDb.AddOrUpdate(x=>x.StudentId,s21);
            //context.StudentDb.AddOrUpdate(x=>x.StudentId,s22);
            //context.StudentDb.AddOrUpdate(x=>x.StudentId,s23);
            //context.StudentDb.AddOrUpdate(x=>x.StudentId,s24);
            //context.StudentDb.AddOrUpdate(x=>x.StudentId,s25);
            //context.StudentDb.AddOrUpdate(x=>x.StudentId,s26);
            //context.StudentDb.AddOrUpdate(x=>x.StudentId,s27);
            //context.StudentDb.AddOrUpdate(x=>x.StudentId,s28);
            //context.StudentDb.AddOrUpdate(x=>x.StudentId,s29);
            //context.StudentDb.AddOrUpdate(x=>x.StudentId,s30);
            //context.StudentDb.AddOrUpdate(x=>x.StudentId,s31);
            //context.StudentDb.AddOrUpdate(x=>x.StudentId,s32);
            //context.StudentDb.AddOrUpdate(x=>x.StudentId,s33);
            //context.StudentDb.AddOrUpdate(x=>x.StudentId,s34);
            //context.StudentDb.AddOrUpdate(x=>x.StudentId,s35);
            //context.StudentDb.AddOrUpdate(x=>x.StudentId,s36);
            //context.StudentDb.AddOrUpdate(x=>x.StudentId,s37);
            //context.StudentDb.AddOrUpdate(x=>x.StudentId,s38);
            //context.StudentDb.AddOrUpdate(x=>x.StudentId,s39);
            //context.StudentDb.AddOrUpdate(x=>x.StudentId,s50);
            //context.StudentDb.AddOrUpdate(x=>x.StudentId,s51);
            //context.StudentDb.AddOrUpdate(x=>x.StudentId,s52);
            //context.StudentDb.AddOrUpdate(x=>x.StudentId,s53);
            //context.StudentDb.AddOrUpdate(x=>x.StudentId,s54);
            //context.StudentDb.AddOrUpdate(x=>x.StudentId,s55);
            //context.StudentDb.AddOrUpdate(x=>x.StudentId,s56);
            //context.StudentDb.AddOrUpdate(x=>x.StudentId,s57);
            //context.StudentDb.AddOrUpdate(x=>x.StudentId,s58);
            //context.StudentDb.AddOrUpdate(x=>x.StudentId,s59);
            //context.StudentDb.AddOrUpdate(x => x.StudentId, s60);
            //context.SaveChanges();




            // CLASSROOM ------------------------------------------------------------------------------->>  
            List<Student> slist = new List<Student> { s01, s02, s03, s04, s05, s06, s07, s08, s09, s13 };
            Classroom cl1 = new Classroom { ClassroomId = 1, Name = "Preliminary", Description = "Η ταξη του 2017", Image = "grade_00.jpg", Teacher = t01, Students = new List<Student> { s01, s02, s03, s04, s05, s06, s07, s08, s09, s13 } };
            Classroom cl2 = new Classroom { ClassroomId = 2, Name = "First Grade", Description = "Η ταξη του 2017", Image = "grade_01.jpg", Teacher = t05, Students = new List<Student> { s10, s11, s12, s14, s15, s16, s17, s18, s19 } };
            Classroom cl3 = new Classroom { ClassroomId = 3, Name = "Second Grade", Description = "Η ταξη του 2018", Image = "grade_02.jpg", Teacher = t06, Students = new List<Student> { s20, s21, s22, s24, s25, s26 } };
            Classroom cl4 = new Classroom { ClassroomId = 4, Name = "Third Grade", Description = "Η ταξη του 2019", Image = "grade_03.jpg", Teacher = t02, Students = new List<Student> { s30, s31, s32, s34, s35, s36, s27, s28, s29 } };
            Classroom cl5 = new Classroom { ClassroomId = 5, Name = "Fourth Grade", Description = "Η ταξη του 2020", Image = "grade_04.jpg", Teacher = t03, Students = new List<Student> { s40, s41, s42, s44, s45, s46, s59 } };
            Classroom cl6 = new Classroom { ClassroomId = 6, Name = "Fifth Grade", Description = "Η ταξη του 2020", Image = "grade_05.jpg", Teacher = t07, Students = new List<Student> { s37, s38, s39, s50, s51, s52, s60 } };
            Classroom cl7 = new Classroom { ClassroomId = 7, Name = "Sixth Grade", Description = "Η ταξη του 2020", Image = "grade_06.jpg", Teacher = t04, Students = new List<Student> { s47, s48, s49, s53, s54, s55, s56, s57, s58 } };


            //Unecessary...School will Crerate Them
            //context.ClassroomsDb.AddOrUpdate(x => x.ClassroomId, cl1);
            //context.ClassroomsDb.AddOrUpdate(x => x.ClassroomId, cl2);
            //context.ClassroomsDb.AddOrUpdate(x => x.ClassroomId, cl3);
            //context.ClassroomsDb.AddOrUpdate(x => x.ClassroomId, cl4);
            //context.ClassroomsDb.AddOrUpdate(x => x.ClassroomId, cl5);//has errorr!!!! DONT RUN
            //context.ClassroomsDb.AddOrUpdate(x => x.ClassroomId, cl6);
            //context.ClassroomsDb.AddOrUpdate(x => x.ClassroomId, cl7);




            // SCHOOLS ------------------------------------------------------------------------------->>  
            School sh01 = new School { Name = "The Lindle School", City = "London", Adress = "59 Picabou Str. SQ9 DZ8 London", Tel = 2109299999, Image = "school_01.jpg", Classroom = new List<Classroom> { cl1, cl2 } };
            School sh02 = new School { Name = "The Lindle School", City = "London", Adress = "59 Picabou Str. SQ9 DZ8 London", Tel = 2109299999, Image = "school_02.jpg", Classroom = new List<Classroom> { cl3, cl4 } };
            School sh03 = new School { Name = "Nipio", City = "Limnos", Adress = "27 Hroon Str. TK81100 Myrina", Tel = 2109788888, Image = "school_03.jpg", Classroom = new List<Classroom> { cl5, cl6 } };
            School sh04 = new School { Name = "Faliro School of Arts", City = "Athens", Adress = "56 Agiou Alexandrou TK17561 P.Faliro", Tel = 2106822222, Image = "school_04.jpg", Classroom = new List<Classroom> { cl7 } };



            context.SchoolsDb.AddOrUpdate(sh01);
            context.SchoolsDb.AddOrUpdate(sh02);
            //context.SchoolsDb.AddOrUpdate(sh03);//has error!!! DONT RUN
            context.SchoolsDb.AddOrUpdate(sh04);

            context.SaveChanges();


        }
    }
}
