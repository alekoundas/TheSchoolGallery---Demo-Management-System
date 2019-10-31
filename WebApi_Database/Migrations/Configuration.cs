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

            //                    Avatar Hair                        \\
            AvatarHair h01 = new AvatarHair { ImageUrl = "hair_01.png" };
            AvatarHair h02 = new AvatarHair { ImageUrl = "hair_02.png" };
            AvatarHair h03 = new AvatarHair { ImageUrl = "hair_03.png" };
            AvatarHair h04 = new AvatarHair { ImageUrl = "hair_04.png" };
            AvatarHair h05 = new AvatarHair { ImageUrl = "hair_05.png" };
            AvatarHair h06 = new AvatarHair { ImageUrl = "hair_06.png" };
            AvatarHair h07 = new AvatarHair { ImageUrl = "hair_07.png" };
            AvatarHair h08 = new AvatarHair { ImageUrl = "hair_08.png" };
            AvatarHair h09 = new AvatarHair { ImageUrl = "hair_09.png" };

            //                    Avatar Body                        \\
            AvatarBody bd01 = new AvatarBody { ImageUrl = "body_01.png" };
            AvatarBody bd02 = new AvatarBody { ImageUrl = "body_02.png" };
            AvatarBody bd03 = new AvatarBody { ImageUrl = "body_03.png" };
            AvatarBody bd04 = new AvatarBody { ImageUrl = "body_04.png" };
            AvatarBody bd05 = new AvatarBody { ImageUrl = "body_05.png" };
            AvatarBody bd06 = new AvatarBody { ImageUrl = "body_06.png" };
            AvatarBody bd07 = new AvatarBody { ImageUrl = "body_07.png" };
            AvatarBody bd08 = new AvatarBody { ImageUrl = "body_08.png" };
            AvatarBody bd09 = new AvatarBody { ImageUrl = "body_09.png" };

            //                   Avatar Clothes                         \\
            AvatarClothing c01 = new AvatarClothing { ImageUrl = "clothes_01.png" };
            AvatarClothing c02 = new AvatarClothing { ImageUrl = "clothes_02.png" };
            AvatarClothing c03 = new AvatarClothing { ImageUrl = "clothes_03.png" };
            AvatarClothing c04 = new AvatarClothing { ImageUrl = "clothes_04.png" };
            AvatarClothing c05 = new AvatarClothing { ImageUrl = "clothes_05.png" };
            AvatarClothing c06 = new AvatarClothing { ImageUrl = "clothes_06.png" };
            AvatarClothing c07 = new AvatarClothing { ImageUrl = "clothes_07.png" };
            AvatarClothing c08 = new AvatarClothing { ImageUrl = "clothes_08.png" };
            AvatarClothing c09 = new AvatarClothing { ImageUrl = "clothes_09.png" };

            // AVATAR ------------------------------------------------------------------------------->>  
            Avatar a1 = new Avatar { Background = b01, Hair = h01, Body = bd01, Clothing = c01 };
            Avatar a2 = new Avatar { Background = b02, Hair = h02, Body = bd02, Clothing = c02 };
            Avatar a3 = new Avatar { Background = b03, Hair = h03, Body = bd03, Clothing = c01 };
            Avatar a4 = new Avatar { Background = b04, Hair = h04, Body = bd02, Clothing = c02 };
            Avatar a5 = new Avatar { Background = b05, Hair = h05, Body = bd01, Clothing = c01 };

            context.AvatarDb.AddOrUpdate(x => x.Title, a1);
            context.AvatarDb.AddOrUpdate(x => x.Title, a2);
            context.AvatarDb.AddOrUpdate(x => x.Title, a3);
            context.AvatarDb.AddOrUpdate(x => x.Title, a4);
            context.AvatarDb.AddOrUpdate(x => x.Title, a5);
            //context.SaveChanges();

            // TEACHER ------------------------------------------------------------------------------->>  
            Teacher t01 = new Teacher { TeacherId = 01, FirstName = "Mpampis", LastName = "Sougias" };
            Teacher t02 = new Teacher { TeacherId = 02, FirstName = "Maria", LastName = "Omorfi" };
            Teacher t03 = new Teacher { TeacherId = 03, FirstName = "Nikolas", LastName = "Tipotas" };
            Teacher t04 = new Teacher { TeacherId = 04, FirstName = "Dioni", LastName = "Marka" };
            Teacher t05 = new Teacher { TeacherId = 05, FirstName = "Yioo", LastName = "Choo" };
            Teacher t06 = new Teacher { TeacherId = 06, FirstName = "Alex", LastName = "Laeder" };
            Teacher t07 = new Teacher { TeacherId = 07, FirstName = "Josef", LastName = "Josefou" };
            Teacher t08 = new Teacher { TeacherId = 08, FirstName = "Vaggelis", LastName = "Maxairas" };
            Teacher t09 = new Teacher { TeacherId = 09, FirstName = "Nikolas", LastName = "Fonias" };
            Teacher t10 = new Teacher { TeacherId = 10, FirstName = "Afroditi", LastName = "Koukla" };
            Teacher t11 = new Teacher { TeacherId = 11, FirstName = "Jessica", LastName = "Bearit" };
            Teacher t12 = new Teacher { TeacherId = 12, FirstName = "Kostas", LastName = "Ntounias" };
            Teacher t13 = new Teacher { TeacherId = 13, FirstName = "Giannis", LastName = "Mpampinis" };
            Teacher t14 = new Teacher { TeacherId = 14, FirstName = "Alex", LastName = "Smith" };

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
            Painting p00 = new Painting { ImageUrl = "painting_000.jpg", PaintingTitle = "No Painting", Price = 0 };

            Painting p01 = new Painting { ImageUrl = "painting_001.jpg", PaintingTitle = "Fall", Price = 1 };
            Painting p02 = new Painting { ImageUrl = "painting_002.jpg", PaintingTitle = "Fall Again", Price = 1 };
            Painting p03 = new Painting { ImageUrl = "painting_003.jpg", PaintingTitle = "Old China", Price = 1 };
            Painting p04 = new Painting { ImageUrl = "painting_004.jpg", PaintingTitle = "Old China", Price = 1 };
            Painting p05 = new Painting { ImageUrl = "painting_005.jpg", PaintingTitle = "Red Panda", Price = 1 };
            Painting p06 = new Painting { ImageUrl = "painting_006.jpg", PaintingTitle = "90 Degrees", Price = 1 };
            Painting p07 = new Painting { ImageUrl = "painting_007.jpg", PaintingTitle = "Rouster", Price = 1 };
            Painting p08 = new Painting { ImageUrl = "painting_008.jpg", PaintingTitle = "Lake Xu", Price = 1 };
            Painting p09 = new Painting { ImageUrl = "painting_009.jpg", PaintingTitle = "Bird", Price = 1 };

            Painting p10 = new Painting { ImageUrl = "painting_010.jpg", PaintingTitle = "Lake Tai", Price = 1 };
            Painting p11 = new Painting { ImageUrl = "painting_011.jpg", PaintingTitle = "Outside Table", Price = 1 };
            Painting p12 = new Painting { ImageUrl = "painting_012.jpg", PaintingTitle = "Birdies", Price = 1 };
            Painting p13 = new Painting { ImageUrl = "painting_013.jpg", PaintingTitle = "Lake Side", Price = 1 };
            Painting p14 = new Painting { ImageUrl = "painting_014.jpg", PaintingTitle = "Village", Price = 1 };
            Painting p15 = new Painting { ImageUrl = "painting_015.jpg", PaintingTitle = "Outside", Price = 1 };
            Painting p16 = new Painting { ImageUrl = "painting_016.jpg", PaintingTitle = "Bottles", Price = 1 };
            Painting p17 = new Painting { ImageUrl = "painting_017.jpg", PaintingTitle = "Taiger", Price = 1 };
            Painting p18 = new Painting { ImageUrl = "painting_018.jpg", PaintingTitle = "Gafild", Price = 1 };
            Painting p19 = new Painting { ImageUrl = "painting_019.jpg", PaintingTitle = "Spotty", Price = 1 };

            Painting p20 = new Painting { ImageUrl = "painting_020.jpg", PaintingTitle = "Jacky", Price = 1 };
            Painting p21 = new Painting { ImageUrl = "painting_021.jpg", PaintingTitle = "Boofy", Price = 1 };
            Painting p22 = new Painting { ImageUrl = "painting_022.jpg", PaintingTitle = "Spark", Price = 1 };
            Painting p23 = new Painting { ImageUrl = "painting_023.jpg", PaintingTitle = "Cat at Window", Price = 1 };
            Painting p24 = new Painting { ImageUrl = "painting_024.jpg", PaintingTitle = "Kitchen", Price = 1 };
            Painting p25 = new Painting { ImageUrl = "painting_025.jpg", PaintingTitle = "Kitchen", Price = 1 };
            Painting p26 = new Painting { ImageUrl = "painting_026.jpg", PaintingTitle = "Bottles", Price = 1 };
            Painting p27 = new Painting { ImageUrl = "painting_027.jpg", PaintingTitle = "Village Celebration", Price = 1 };
            Painting p28 = new Painting { ImageUrl = "painting_028.jpg", PaintingTitle = "Blue Mist", Price = 1 };
            Painting p29 = new Painting { ImageUrl = "painting_029.jpg", PaintingTitle = "Under Water", Price = 1 };

            Painting p30 = new Painting { ImageUrl = "painting_030.jpg", PaintingTitle = "Mountain Home", Price = 1 };
            Painting p31 = new Painting { ImageUrl = "painting_031.jpg", PaintingTitle = "Flowers", Price = 1 };
            Painting p32 = new Painting { ImageUrl = "painting_032.jpg", PaintingTitle = "Pastel Flowers", Price = 1 };
            Painting p33 = new Painting { ImageUrl = "painting_033.jpg", PaintingTitle = "Green", Price = 1 };
            Painting p34 = new Painting { ImageUrl = "painting_034.jpg", PaintingTitle = "I made a Mess", Price = 1 };
            Painting p35 = new Painting { ImageUrl = "painting_035.jpg", PaintingTitle = "Our Cow", Price = 1 };
            Painting p36 = new Painting { ImageUrl = "painting_036.jpg", PaintingTitle = "Snoopy", Price = 1 };
            Painting p37 = new Painting { ImageUrl = "painting_037.jpg", PaintingTitle = "Old man Li", Price = 1 };
            Painting p38 = new Painting { ImageUrl = "painting_038.jpg", PaintingTitle = "Villagers", Price = 1 };
            Painting p39 = new Painting { ImageUrl = "painting_039.jpg", PaintingTitle = "Suburbs", Price = 1 };

            Painting p40 = new Painting { ImageUrl = "painting_040.jpg", PaintingTitle = "Villagers", Price = 1 };
            Painting p41 = new Painting { ImageUrl = "painting_041.jpg", PaintingTitle = "Villagers", Price = 1 };
            Painting p42 = new Painting { ImageUrl = "painting_042.jpg", PaintingTitle = "Valley", Price = 1 };
            Painting p43 = new Painting { ImageUrl = "painting_043.jpg", PaintingTitle = "One Brush", Price = 1 };
            Painting p44 = new Painting { ImageUrl = "painting_044.jpg", PaintingTitle = "Blue Wet", Price = 1 };
            Painting p45 = new Painting { ImageUrl = "painting_045.jpg", PaintingTitle = "I Broke my Pen", Price = 1 };
            Painting p46 = new Painting { ImageUrl = "painting_046.jpg", PaintingTitle = "Pattern", Price = 1 };
            Painting p47 = new Painting { ImageUrl = "painting_047.jpg", PaintingTitle = "Trees", Price = 1 };
            Painting p48 = new Painting { ImageUrl = "painting_048.jpg", PaintingTitle = "Ma Favorit", Price = 1 };
            Painting p49 = new Painting { ImageUrl = "painting_049.jpg", PaintingTitle = "War is Bad", Price = 1 };

            Painting p50 = new Painting { ImageUrl = "painting_050.jpg", PaintingTitle = "War is Bad", Price = 1 };
            Painting p51 = new Painting { ImageUrl = "painting_051.jpg", PaintingTitle = "War is Bad", Price = 1 };
            Painting p52 = new Painting { ImageUrl = "painting_052.jpg", PaintingTitle = "El Esdi", Price = 1 };
            Painting p53 = new Painting { ImageUrl = "painting_053.jpg", PaintingTitle = "Ellen Sdee", Price = 1 };
            Painting p54 = new Painting { ImageUrl = "painting_054.jpg", PaintingTitle = "Eles Dee", Price = 1 };
            Painting p55 = new Painting { ImageUrl = "painting_055.jpg", PaintingTitle = "Sea", Price = 1 };
            Painting p56 = new Painting { ImageUrl = "painting_056.jpg", PaintingTitle = "Sleeping Birds", Price = 1 };
            Painting p57 = new Painting { ImageUrl = "painting_057.jpg", PaintingTitle = "My Home", Price = 1 };
            Painting p58 = new Painting { ImageUrl = "painting_058.jpg", PaintingTitle = "Fishy", Price = 1 };
            Painting p59 = new Painting { ImageUrl = "painting_059.jpg", PaintingTitle = "Fishy", Price = 1 };

            Painting p60 = new Painting { ImageUrl = "painting_060.jpg", PaintingTitle = "My Village", Price = 1 };
            Painting p61 = new Painting { ImageUrl = "painting_061.jpg", PaintingTitle = "Home", Price = 1 };
            Painting p62 = new Painting { ImageUrl = "painting_062.jpg", PaintingTitle = "Fish", Price = 1 };
            Painting p63 = new Painting { ImageUrl = "painting_063.jpg", PaintingTitle = "Pasxalitsa", Price = 1 };
            Painting p64 = new Painting { ImageUrl = "painting_064.jpg", PaintingTitle = "Stary Sky", Price = 1 };
            Painting p65 = new Painting { ImageUrl = "painting_065.jpg", PaintingTitle = "Stary Sky", Price = 1 };
            Painting p66 = new Painting { ImageUrl = "painting_066.jpg", PaintingTitle = "Neberhood", Price = 1 };
            Painting p67 = new Painting { ImageUrl = "painting_067.jpg", PaintingTitle = "Neiberhood", Price = 1 };
            Painting p68 = new Painting { ImageUrl = "painting_068.jpg", PaintingTitle = "Birdy", Price = 1 };
            Painting p69 = new Painting { ImageUrl = "painting_069.jpg", PaintingTitle = "Neberhoud", Price = 1 };

            Painting p70 = new Painting { ImageUrl = "painting_070.jpg", PaintingTitle = "Neiberhud", Price = 1 };
            Painting p71 = new Painting { ImageUrl = "painting_071.jpg", PaintingTitle = "Moon Home", Price = 1 };
            Painting p72 = new Painting { ImageUrl = "painting_072.jpg", PaintingTitle = "Mai Tri", Price = 1 };
            Painting p73 = new Painting { ImageUrl = "painting_073.jpg", PaintingTitle = "Mi Tree", Price = 1 };
            Painting p74 = new Painting { ImageUrl = "painting_074.jpg", PaintingTitle = "Ma Tri", Price = 1 };

















            // STUDENTS ------------------------------------------------------------------------------->>  
            Student s01 = new Student { StudentId = 01, Paintings = new List<Painting> { p01, p02 }, FirstName = "James", LastName = "Hernandez", Age = 5, Avatar = a1 };
            Student s02 = new Student { StudentId = 02, Paintings = new List<Painting> { p03, p04 }, FirstName = "Senzieng", LastName = "Hou", Age = 5, Avatar = a1 };
            Student s03 = new Student { StudentId = 03, Paintings = new List<Painting> { p06 }, FirstName = "Robert", LastName = "Rodriguez", Age = 5, Avatar = a1 };
            Student s04 = new Student { StudentId = 04, Paintings = new List<Painting> { p00 }, FirstName = "Maria", LastName = "Garcia", Age = 5, Avatar = a1 };
            Student s05 = new Student { StudentId = 05, Paintings = new List<Painting> { p07, p09, p05 }, FirstName = "Fumiko", LastName = "Koyama", Age = 5, Avatar = a1 };
            Student s06 = new Student { StudentId = 06, Paintings = new List<Painting> { p08, p10 }, FirstName = "Ryoya", LastName = "Urehara", Age = 5, Avatar = a1 };
            Student s07 = new Student { StudentId = 07, Paintings = new List<Painting> { p11 }, FirstName = "Kim", LastName = "Yun", Age = 5, Avatar = a1 };
            Student s08 = new Student { StudentId = 08, Paintings = new List<Painting> { p12, p13 }, FirstName = "Fael", LastName = "Faery", Age = 5, Avatar = a1 };
            Student s09 = new Student { StudentId = 09, Paintings = new List<Painting> { p14, p15 }, FirstName = "Amanda", LastName = "Diamond", Age = 5, Avatar = a1 };
            Student s10 = new Student { StudentId = 10, Paintings = new List<Painting> { p16, p23 }, FirstName = "Michael", LastName = "Shumy", Age = 5, Avatar = a1 };
            Student s11 = new Student { StudentId = 11, Paintings = new List<Painting> { p17 }, FirstName = "Will", LastName = "Smooth", Age = 6, Avatar = a1 };
            Student s12 = new Student { StudentId = 12, Paintings = new List<Painting> { p18, p19, p20, p21, p22 }, FirstName = "Bob", LastName = "Sfougg", Age = 6, Avatar = a1 };
            Student s13 = new Student { StudentId = 13, Paintings = new List<Painting> { p29, p46 }, FirstName = "Jenny", LastName = "Ntouzi", Age = 6, Avatar = a1 };
            Student s14 = new Student { StudentId = 14, Paintings = new List<Painting> { p31, p32 }, FirstName = "Mathiew", LastName = "MacTrack", Age = 6, Avatar = a1 };
            Student s15 = new Student { StudentId = 15, Paintings = new List<Painting> { p30, p33, p34, p35 }, FirstName = "Mairy", LastName = "Pops", Age = 6, Avatar = a1 };
            Student s16 = new Student { StudentId = 16, Paintings = new List<Painting> { p36 }, FirstName = "Triplos", LastName = "Kakos", Age = 6, Avatar = a1 };
            Student s17 = new Student { StudentId = 17, Paintings = new List<Painting> { p37, p45, p47 }, FirstName = "Diplos", LastName = "Arithmos", Age = 6, Avatar = a1 };
            Student s18 = new Student { StudentId = 18, Paintings = new List<Painting> { p48, p44 }, FirstName = "Monos", LastName = "Erimos", Age = 6, Avatar = a1 };
            Student s19 = new Student { StudentId = 19, Paintings = new List<Painting> { p42, p43 }, FirstName = "Notis", LastName = "Sfakias", Age = 6, Avatar = a1 };
            Student s20 = new Student { StudentId = 20, Paintings = new List<Painting> { p48 }, FirstName = "Lookia", LastName = "Kelaidoni", Age = 7, Avatar = a1 };
            Student s21 = new Student { StudentId = 21, Paintings = new List<Painting> { p49, p57 }, FirstName = "Mairy", LastName = "Dounia", Age = 7, Avatar = a1 };
            Student s22 = new Student { StudentId = 22, Paintings = new List<Painting> { p50, p62, p68 }, FirstName = "Xristina", LastName = "Mama", Age = 7, Avatar = a1 };
            Student s23 = new Student { StudentId = 23, Paintings = new List<Painting> { p51, p59 }, FirstName = "Jenny", LastName = "Mpotsi", Age = 7, Avatar = a1 };
            Student s24 = new Student { StudentId = 24, Paintings = new List<Painting> { p55, p56, p58 }, FirstName = "Zozo", LastName = "Markoulaki", Age = 7, Avatar = a1 };
            Student s25 = new Student { StudentId = 25, Paintings = new List<Painting> { p60, p63 }, FirstName = "Babis", LastName = "Lipsos", Age = 7, Avatar = a1 };
            Student s26 = new Student { StudentId = 26, Paintings = new List<Painting> { p61 }, FirstName = "Volos", LastName = "Mpilias", Age = 6, Avatar = a1 };
            Student s27 = new Student { StudentId = 27, Paintings = new List<Painting> { p66 }, FirstName = "Yiorgos", LastName = "Georgiou", Age = 7, Avatar = a1 };
            Student s28 = new Student { StudentId = 28, Paintings = new List<Painting> { p67 }, FirstName = "Ioannis", LastName = "Xaros", Age = 7, Avatar = a1 };
            Student s29 = new Student { StudentId = 29, Paintings = new List<Painting> { p71, p70 }, FirstName = "Vaggelis", LastName = "Giortis", Age = 7, Avatar = a1 };
            Student s30 = new Student { StudentId = 30, Paintings = new List<Painting> { p52, p53, p54 }, FirstName = "Artemis", LastName = "Matsas", Age = 8, Avatar = a1 };
            Student s31 = new Student { StudentId = 31, Paintings = new List<Painting> { p27, p28 }, FirstName = "Iosif", LastName = "Pateras", Age = 8, Avatar = a1 };
            Student s32 = new Student { StudentId = 32, Paintings = new List<Painting> { p38, p39 }, FirstName = "Kostas", LastName = "Karagkounis", Age = 8, Avatar = a1 };
            Student s33 = new Student { StudentId = 33, Paintings = new List<Painting> { p40, }, FirstName = "Elias", LastName = "Apalou", Age = 8, Avatar = a1 };
            Student s34 = new Student { StudentId = 34, Paintings = new List<Painting> { p41, }, FirstName = "Ektoras", LastName = "Limnios", Age = 8, Avatar = a1 };
            Student s35 = new Student { StudentId = 35, Paintings = new List<Painting> { p69, }, FirstName = "Ifigeneia", LastName = "Grevena", Age = 8, Avatar = a1 };
            Student s36 = new Student { StudentId = 36, Paintings = new List<Painting> { }, FirstName = "Manolis", LastName = "Kairos", Age = 8, Avatar = a1 };
            Student s37 = new Student { StudentId = 37, Paintings = new List<Painting> { }, FirstName = "Giannis", LastName = "Xromas", Age = 9, Avatar = a1 };
            Student s38 = new Student { StudentId = 38, Paintings = new List<Painting> { }, FirstName = "Nikos", LastName = "Gkagkas", Age = 9, Avatar = a1 };
            Student s39 = new Student { StudentId = 39, Paintings = new List<Painting> { }, FirstName = "Yiorgos", LastName = "Dedes", Age = 9, Avatar = a1 };
            Student s40 = new Student { StudentId = 40, Paintings = new List<Painting> { }, FirstName = "Betty", LastName = "Mpantianou", Age = 9, Avatar = a1 };
            Student s41 = new Student { StudentId = 41, Paintings = new List<Painting> { }, FirstName = "Michalis", LastName = "Karydas", Age = 9, Avatar = a1 };
            Student s42 = new Student { StudentId = 42, Paintings = new List<Painting> { p64, p65 }, FirstName = "Rea Ifigeneia", LastName = "Chorman", Age = 9, Avatar = a1 };
            Student s43 = new Student { StudentId = 43, Paintings = new List<Painting> { }, FirstName = "Johnnys", LastName = "Perpatitis", Age = 8, Avatar = a1 };
            Student s44 = new Student { StudentId = 44, Paintings = new List<Painting> { }, FirstName = "Dimitris", LastName = "Lymperis", Age = 10, Avatar = a1 };
            Student s45 = new Student { StudentId = 45, Paintings = new List<Painting> { }, FirstName = "Filippas", LastName = "Mpitsis", Age = 8, Avatar = a1 };
            Student s46 = new Student { StudentId = 46, Paintings = new List<Painting> { }, FirstName = "Alexis", LastName = "Prothypos", Age = 8, Avatar = a1 };
            Student s47 = new Student { StudentId = 47, Paintings = new List<Painting> { }, FirstName = "Konstantinos", LastName = "Torinos", Age = 10, Avatar = a1 };
            Student s48 = new Student { StudentId = 48, Paintings = new List<Painting> { }, FirstName = "Maria", LastName = "Maraki", Age = 10, Avatar = a1 };
            Student s49 = new Student { StudentId = 49, Paintings = new List<Painting> { }, FirstName = "Katerina", LastName = "Vafeidi", Age = 10, Avatar = a1 };
            Student s50 = new Student { StudentId = 50, Paintings = new List<Painting> { }, FirstName = "Vaggelitsa", LastName = "Grylou", Age = 9, Avatar = a1 };
            Student s51 = new Student { StudentId = 51, Paintings = new List<Painting> { }, FirstName = "Hector", LastName = "Gatsos", Age = 9, Avatar = a1 };
            Student s52 = new Student { StudentId = 52, Paintings = new List<Painting> { }, FirstName = "Mike", LastName = "Lawry", Age = 9, Avatar = a1 };
            Student s53 = new Student { StudentId = 53, Paintings = new List<Painting> { }, FirstName = "Vanessa", LastName = "Smith", Age = 10, Avatar = a1 };
            Student s54 = new Student { StudentId = 54, Paintings = new List<Painting> { }, FirstName = "Maria", LastName = "Mpihi", Age = 10, Avatar = a1 };
            Student s55 = new Student { StudentId = 55, Paintings = new List<Painting> { }, FirstName = "Kostas", LastName = "Malamoutis", Age = 10, Avatar = a1 };
            Student s56 = new Student { StudentId = 56, Paintings = new List<Painting> { }, FirstName = "Yiannis", LastName = "Noaa", Age = 10, Avatar = a1 };
            Student s57 = new Student { StudentId = 57, Paintings = new List<Painting> { }, FirstName = "Kaori", LastName = "Koyama", Age = 10, Avatar = a1 };
            Student s58 = new Student { StudentId = 58, Paintings = new List<Painting> { p73, p74 }, FirstName = "Jessica", LastName = "Nian", Age = 10, Avatar = a1 };
            Student s59 = new Student { StudentId = 59, Paintings = new List<Painting> { p72 }, FirstName = "Biki", LastName = "Valgeri", Age = 10, Avatar = a1 };
            Student s60 = new Student { StudentId = 60, Paintings = new List<Painting> { p24, p25, p26 }, FirstName = "Ifigeneia", LastName = "Fotopoulou", Age = 11, Avatar = a1 };

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
            School sh02 = new School { Name = "Little People", City = "Hangzhou", Adress = "156 XiWu", Tel = 210896542, Image = "school_02.jpg", Classroom = new List<Classroom> { cl3, cl4 } };
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
