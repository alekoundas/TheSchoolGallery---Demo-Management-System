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
            context.SaveChanges();

            // TEACHER ------------------------------------------------------------------------------->>  
            Teacher t01 = new Teacher { FirstName = "Mpampis", LastName = "Sougias", Avatar = a1 };
            Teacher t02 = new Teacher { FirstName = "Maria", LastName = "Omorfi", Avatar = a1 };
            Teacher t03 = new Teacher { FirstName = "Nikolas", LastName = "Tipotas", Avatar = a1 };
            Teacher t04 = new Teacher { FirstName = "Dioni", LastName = "Marka", Avatar = a1 };
            Teacher t05 = new Teacher { FirstName = "Yioo", LastName = "Choo", Avatar = a1 };
            Teacher t06 = new Teacher { FirstName = "Alex", LastName = "Laeder", Avatar = a1 };
            Teacher t07 = new Teacher { FirstName = "Josef", LastName = "Josefou", Avatar = a1 };
            Teacher t08 = new Teacher { FirstName = "Vaggelis", LastName = "Maxairas", Avatar = a1 };
            Teacher t09 = new Teacher { FirstName = "Nikolas", LastName = "Fonias", Avatar = a1 };
            Teacher t10 = new Teacher { FirstName = "Afroditi", LastName = "Koukla", Avatar = a1 };
            Teacher t11 = new Teacher { FirstName = "Jessica", LastName = "Bearit", Avatar = a1 };
            Teacher t12 = new Teacher { FirstName = "Kostas", LastName = "Ntounias", Avatar = a1 };
            Teacher t13 = new Teacher { FirstName = "Giannis", LastName = "Mpampinis", Avatar = a1 };
            Teacher t14 = new Teacher { FirstName = "Alex", LastName = "Smith", Avatar = a1 };
            context.TeacherDb.AddOrUpdate(t01);
            context.TeacherDb.AddOrUpdate(t02);
            context.TeacherDb.AddOrUpdate(t03);
            context.TeacherDb.AddOrUpdate(t04);
            context.TeacherDb.AddOrUpdate(t05);
            context.TeacherDb.AddOrUpdate(t06);
            context.TeacherDb.AddOrUpdate(t07);
            context.TeacherDb.AddOrUpdate(t08);
            context.TeacherDb.AddOrUpdate(t09);
            context.TeacherDb.AddOrUpdate(t10);
            context.TeacherDb.AddOrUpdate(t11);
            context.TeacherDb.AddOrUpdate(t12);
            context.TeacherDb.AddOrUpdate(t13);
            context.TeacherDb.AddOrUpdate(t14);


            // STUDENTS ------------------------------------------------------------------------------->>  
            Student s01 = new Student { FirstName = "James", LastName = "Hernandez", Age = 5, Avatar = a1 };
            Student s02 = new Student { FirstName = "David", LastName = "Smith", Age = 5, Avatar = a1 };
            Student s03 = new Student { FirstName = "Robert", LastName = "Rodriguez", Age = 5, Avatar = a1 };
            Student s04 = new Student { FirstName = "Maria", LastName = "Garcia", Age = 5, Avatar = a1 };
            Student s05 = new Student { FirstName = "Fumiko", LastName = "Koyama", Age = 5, Avatar = a1 };
            Student s06 = new Student { FirstName = "Ryoya", LastName = "Urehara", Age = 5, Avatar = a1 };
            Student s07 = new Student { FirstName = "Kim", LastName = "Yun", Age = 5, Avatar = a1 };
            Student s08 = new Student { FirstName = "Fael", LastName = "Faery", Age = 5, Avatar = a1 };
            Student s09 = new Student { FirstName = "Amanda", LastName = "Diamond", Age = 5, Avatar = a1 };
            Student s10 = new Student { FirstName = "Michael", LastName = "Shumy", Age = 5, Avatar = a1 };
            Student s11 = new Student { FirstName = "Will", LastName = "Smooth", Age = 6, Avatar = a1 };
            Student s12 = new Student { FirstName = "Bob", LastName = "Sfougg", Age = 6, Avatar = a1 };
            Student s13 = new Student { FirstName = "Jenny", LastName = "Ntouzi", Age = 6, Avatar = a1 };
            Student s14 = new Student { FirstName = "Mathiew", LastName = "MacTrack", Age = 6, Avatar = a1 };
            Student s15 = new Student { FirstName = "Mairy", LastName = "Pops", Age = 6, Avatar = a1 };
            Student s16 = new Student { FirstName = "Triplos", LastName = "Kakos", Age = 6, Avatar = a1 };
            Student s17 = new Student { FirstName = "Diplos", LastName = "Arithmos", Age = 6, Avatar = a1 };
            Student s18 = new Student { FirstName = "Monos", LastName = "Erimos", Age = 6, Avatar = a1 };
            Student s19 = new Student { FirstName = "Notis", LastName = "Sfakias", Age = 6, Avatar = a1 };
            Student s20 = new Student { FirstName = "Lookia", LastName = "Kelaidoni", Age = 7, Avatar = a1 };
            Student s21 = new Student { FirstName = "Mairy", LastName = "Dounia", Age = 7, Avatar = a1 };
            Student s22 = new Student { FirstName = "Xristina", LastName = "Mama", Age = 7, Avatar = a1 };
            Student s23 = new Student { FirstName = "Jenny", LastName = "Mpotsi", Age = 7, Avatar = a1 };
            Student s24 = new Student { FirstName = "Zozo", LastName = "Markoulaki", Age = 7, Avatar = a1 };
            Student s25 = new Student { FirstName = "Babis", LastName = "Lipsos", Age = 7, Avatar = a1 };
            Student s26 = new Student { FirstName = "Volos", LastName = "Mpilias", Age = 6, Avatar = a1 };
            Student s27 = new Student { FirstName = "Yiorgos", LastName = "Georgiou", Age = 7, Avatar = a1 };
            Student s28 = new Student { FirstName = "Ioannis", LastName = "Xaros", Age = 7, Avatar = a1 };
            Student s29 = new Student { FirstName = "Vaggelis", LastName = "Giortis", Age = 7, Avatar = a1 };
            Student s30 = new Student { FirstName = "Artemis", LastName = "Matsas", Age = 8, Avatar = a1 };
            Student s31 = new Student { FirstName = "Iosif", LastName = "Pateras", Age = 8, Avatar = a1 };
            Student s32 = new Student { FirstName = "Kostas", LastName = "Karagkounis", Age = 8, Avatar = a1 };
            Student s33 = new Student { FirstName = "Elias", LastName = "Apalou", Age = 8, Avatar = a1 };
            Student s34 = new Student { FirstName = "Ektoras", LastName = "Limnios", Age = 8, Avatar = a1 };
            Student s35 = new Student { FirstName = "Ifigeneia", LastName = "Grevena", Age = 8, Avatar = a1 };
            Student s36 = new Student { FirstName = "Manolis", LastName = "Kairos", Age = 8, Avatar = a1 };
            Student s37 = new Student { FirstName = "Giannis", LastName = "Xromas", Age = 9, Avatar = a1 };
            Student s38 = new Student { FirstName = "Nikos", LastName = "Gkagkas", Age = 9, Avatar = a1 };
            Student s39 = new Student { FirstName = "Yiorgos", LastName = "Dedes", Age = 9, Avatar = a1 };
            Student s40 = new Student { FirstName = "Betty", LastName = "Mpantianou", Age = 9, Avatar = a1 };
            Student s41 = new Student { FirstName = "Michalis", LastName = "Karydas", Age = 9, Avatar = a1 };
            Student s42 = new Student { FirstName = "Rea Ifigeneia", LastName = "Chorman", Age = 9, Avatar = a1 };
            Student s43 = new Student { FirstName = "Johnnys", LastName = "Perpatitis", Age = 8, Avatar = a1 };
            Student s44 = new Student { FirstName = "Dimitris", LastName = "Lymperis", Age = 10, Avatar = a1 };
            Student s45 = new Student { FirstName = "Filippas", LastName = "Mpitsis", Age = 8, Avatar = a1 };
            Student s46 = new Student { FirstName = "Alexis", LastName = "Prothypos", Age = 8, Avatar = a1 };
            Student s47 = new Student { FirstName = "Konstantinos", LastName = "Torinos", Age = 10, Avatar = a1 };
            Student s48 = new Student { FirstName = "Maria", LastName = "Maraki", Age = 10, Avatar = a1 };
            Student s49 = new Student { FirstName = "Katerina", LastName = "Vafeidi", Age = 10, Avatar = a1 };
            Student s50 = new Student { FirstName = "Vaggelitsa", LastName = "Grylou", Age = 9, Avatar = a1 };
            Student s51 = new Student { FirstName = "Hector", LastName = "Gatsos", Age = 9, Avatar = a1 };
            Student s52 = new Student { FirstName = "Mike", LastName = "Lawry", Age = 9, Avatar = a1 };
            Student s53 = new Student { FirstName = "Vanessa", LastName = "Smith", Age = 10, Avatar = a1 };
            Student s54 = new Student { FirstName = "Maria", LastName = "Mpihi", Age = 10, Avatar = a1 };
            Student s55 = new Student { FirstName = "Kostas", LastName = "Malamoutis", Age = 10, Avatar = a1 };
            Student s56 = new Student { FirstName = "Yiannis", LastName = "Noaa", Age = 10, Avatar = a1 };
            Student s57 = new Student { FirstName = "Kaori", LastName = "Koyama", Age = 10, Avatar = a1 };
            Student s58 = new Student { FirstName = "Jessica", LastName = "Nian", Age = 10, Avatar = a1 };
            Student s59 = new Student { FirstName = "Biki", LastName = "Valgeri", Age = 10, Avatar = a1 };
            Student s60 = new Student { FirstName = "Ifigeneia", LastName = "Fotopoulou", Age = 11, Avatar = a1 };
            context.StudentDb.AddOrUpdate(s01);
            context.StudentDb.AddOrUpdate(s02);
            context.StudentDb.AddOrUpdate(s03);
            context.StudentDb.AddOrUpdate(s04);
            context.StudentDb.AddOrUpdate(s05);
            context.StudentDb.AddOrUpdate(s06);
            context.StudentDb.AddOrUpdate(s07);
            context.StudentDb.AddOrUpdate(s08);
            context.StudentDb.AddOrUpdate(s09);
            context.StudentDb.AddOrUpdate(s10);
            context.StudentDb.AddOrUpdate(s11);
            context.StudentDb.AddOrUpdate(s12);
            context.StudentDb.AddOrUpdate(s13);
            context.StudentDb.AddOrUpdate(s14);
            context.StudentDb.AddOrUpdate(s15);
            context.StudentDb.AddOrUpdate(s16);
            context.StudentDb.AddOrUpdate(s17);
            context.StudentDb.AddOrUpdate(s18);
            context.StudentDb.AddOrUpdate(s19);
            context.StudentDb.AddOrUpdate(s20);
            context.StudentDb.AddOrUpdate(s21);
            context.StudentDb.AddOrUpdate(s22);
            context.StudentDb.AddOrUpdate(s23);
            context.StudentDb.AddOrUpdate(s24);
            context.StudentDb.AddOrUpdate(s25);
            context.StudentDb.AddOrUpdate(s26);
            context.StudentDb.AddOrUpdate(s27);
            context.StudentDb.AddOrUpdate(s28);
            context.StudentDb.AddOrUpdate(s29);
            context.StudentDb.AddOrUpdate(s30);
            context.StudentDb.AddOrUpdate(s31);
            context.StudentDb.AddOrUpdate(s32);
            context.StudentDb.AddOrUpdate(s33);
            context.StudentDb.AddOrUpdate(s34);
            context.StudentDb.AddOrUpdate(s35);
            context.StudentDb.AddOrUpdate(s36);
            context.StudentDb.AddOrUpdate(s37);
            context.StudentDb.AddOrUpdate(s38);
            context.StudentDb.AddOrUpdate(s39);
            context.StudentDb.AddOrUpdate(s50);
            context.StudentDb.AddOrUpdate(s51);
            context.StudentDb.AddOrUpdate(s52);
            context.StudentDb.AddOrUpdate(s53);
            context.StudentDb.AddOrUpdate(s54);
            context.StudentDb.AddOrUpdate(s55);
            context.StudentDb.AddOrUpdate(s56);
            context.StudentDb.AddOrUpdate(s57);
            context.StudentDb.AddOrUpdate(s58);
            context.StudentDb.AddOrUpdate(s59);
            context.StudentDb.AddOrUpdate(s60);


            // CLASS ------------------------------------------------------------------------------->>  
            Classroom cl1 = new Classroom
            {
                Name = "Preliminary",
                Description = "Η ταξη του 2017",
                Image = "grade_00.jpg",
                Teacher = t01,
                Students = new List<Student>
            { s01, s02, s03, s04, s05, s06, s07, s08, s09, s13  }
            };
            Classroom cl2 = new Classroom
            {
                Name = "First Grade",
                Description = "Η ταξη του 2017",
                Image = "grade_01.jpg",
                Teacher = t05,
                Students = new List<Student>
            { s10, s11, s12, s14, s15, s16, s17, s18, s19  }
            };
            Classroom cl3 = new Classroom
            {
                Name = "Second Grade",
                Description = "Η ταξη του 2018",
                Image = "grade_02.jpg",
                Teacher = t06,
                Students = new List<Student>
            { s20, s21, s22, s24, s25, s26  }
            };
            Classroom cl4 = new Classroom
            {
                Name = "Third Grade",
                Description = "Η ταξη του 2019",
                Image = "grade_03.jpg",
                Teacher = t02,
                Students = new List<Student>
            { s30, s31, s32, s34, s35, s36, s27, s28, s29  }
            };
            Classroom cl5 = new Classroom
            {
                Name = "Fourth Grade",
                Description = "Η ταξη του 2020",
                Image = "grade_04.jpg",
                Teacher = t03,
                Students = new List<Student>
            { s40, s41, s42, s44, s45, s46, s59   }
            };
            Classroom cl6 = new Classroom
            {
                Name = "Fifth Grade",
                Description = "Η ταξη του 2020",
                Image = "grade_05.jpg",
                Teacher = t07,
                Students = new List<Student>
            { s37, s38, s39, s50, s51, s52, s60 }
            };
            Classroom cl7 = new Classroom
            {
                Name = "Sixth Grade",
                Description = "Η ταξη του 2020",
                Image = "grade_06.jpg",
                Teacher = t04,
                Students = new List<Student>
            { s47, s48, s49, s53, s54, s55, s56, s57, s58  }
            };

            // SCHOOLS ------------------------------------------------------------------------------->>  
            School sh01 = new School
            {
                Name = "The Lindle School",
                City = "London",
                Adress = "59 Picabou Str. SQ9 DZ8 London",
                Tel = 2109299999,
                Image = "school_01.jpg",
                Classroom = new List<Classroom>
            { cl1, cl2 }
            };
            School sh02 = new School
            {
                Name = "Joan Barckley School",
                City = "New York",
                Adress = "13 Abenue Vrt. Banhattan",
                Tel = 2108422222,
                Image = "school_02.jpg",
                Classroom = new List<Classroom>
            { cl3, cl4 }
            };
            School sh03 = new School
            {
                Name = "Nipio",
                City = "Limnos",
                Adress = "27 Hroon Str. TK81100 Myrina",
                Tel = 2109788888,
                Image = "school_03.jpg",
                Classroom = new List<Classroom>
            { cl5, cl6 }
            };
            School sh04 = new School
            {
                Name = "Faliro School of Arts",
                City = "Athens",
                Adress = "56 Agiou Alexandrou TK17561 P.Faliro",
                Tel = 2106822222,
                Image = "school_04.jpg",
                Classroom = new List<Classroom>
            { cl7 }
            };

            // PAINTINGS ------------------------------------------------------------------------------->>  
            Painting p01 = new Painting { ImageUrl = "painting_001.jpg", PaintingTitle = "I am Title", Price = 1, Student = s01 };
            Painting p02 = new Painting { ImageUrl = "painting_002.jpg", PaintingTitle = "I am Title", Price = 1, Student = s02 };
            Painting p03 = new Painting { ImageUrl = "painting_003.jpg", PaintingTitle = "I am Title", Price = 1, Student = s03 };
            Painting p04 = new Painting { ImageUrl = "painting_004.jpg", PaintingTitle = "I am Title", Price = 1, Student = s04 };
            Painting p05 = new Painting { ImageUrl = "painting_005.jpg", PaintingTitle = "I am Title", Price = 1, Student = s05 };
            Painting p06 = new Painting { ImageUrl = "painting_006.jpg", PaintingTitle = "I am Title", Price = 1, Student = s06 };
            Painting p07 = new Painting { ImageUrl = "painting_007.jpg", PaintingTitle = "I am Title", Price = 1, Student = s07 };
            Painting p08 = new Painting { ImageUrl = "painting_008.jpg", PaintingTitle = "I am Title", Price = 1, Student = s08 };
            Painting p09 = new Painting { ImageUrl = "painting_009.jpg", PaintingTitle = "I am Title", Price = 1, Student = s09 };

            Painting p10 = new Painting { ImageUrl = "painting_010.jpg", PaintingTitle = "I am Title", Price = 1, Student = s10 };
            Painting p11 = new Painting { ImageUrl = "painting_011.jpg", PaintingTitle = "I am Title", Price = 1, Student = s11 };
            Painting p12 = new Painting { ImageUrl = "painting_012.jpg", PaintingTitle = "I am Title", Price = 1, Student = s12 };
            Painting p13 = new Painting { ImageUrl = "painting_013.jpg", PaintingTitle = "I am Title", Price = 1, Student = s13 };
            Painting p14 = new Painting { ImageUrl = "painting_014.jpg", PaintingTitle = "I am Title", Price = 1, Student = s14 };
            Painting p15 = new Painting { ImageUrl = "painting_015.jpg", PaintingTitle = "I am Title", Price = 1, Student = s15 };
            Painting p16 = new Painting { ImageUrl = "painting_016.jpg", PaintingTitle = "I am Title", Price = 1, Student = s16 };
            Painting p17 = new Painting { ImageUrl = "painting_017.jpg", PaintingTitle = "I am Title", Price = 1, Student = s17 };
            Painting p18 = new Painting { ImageUrl = "painting_018.jpg", PaintingTitle = "I am Title", Price = 1, Student = s18 };
            Painting p19 = new Painting { ImageUrl = "painting_019.jpg", PaintingTitle = "I am Title", Price = 1, Student = s19 };

            Painting p20 = new Painting { ImageUrl = "painting_020.jpg", PaintingTitle = "I am Title", Price = 1, Student = s20 };
            Painting p21 = new Painting { ImageUrl = "painting_021.jpg", PaintingTitle = "I am Title", Price = 1, Student = s21 };
            Painting p22 = new Painting { ImageUrl = "painting_022.jpg", PaintingTitle = "I am Title", Price = 1, Student = s22 };
            Painting p23 = new Painting { ImageUrl = "painting_023.jpg", PaintingTitle = "I am Title", Price = 1, Student = s23 };
            Painting p24 = new Painting { ImageUrl = "painting_024.jpg", PaintingTitle = "I am Title", Price = 1, Student = s24 };
            Painting p25 = new Painting { ImageUrl = "painting_025.jpg", PaintingTitle = "I am Title", Price = 1, Student = s25 };
            Painting p26 = new Painting { ImageUrl = "painting_026.jpg", PaintingTitle = "I am Title", Price = 1, Student = s26 };
            Painting p27 = new Painting { ImageUrl = "painting_027.jpg", PaintingTitle = "I am Title", Price = 1, Student = s27 };
            Painting p28 = new Painting { ImageUrl = "painting_028.jpg", PaintingTitle = "I am Title", Price = 1, Student = s28 };
            Painting p29 = new Painting { ImageUrl = "painting_029.jpg", PaintingTitle = "I am Title", Price = 1, Student = s29 };

            Painting p30 = new Painting { ImageUrl = "painting_030.jpg", PaintingTitle = "I am Title", Price = 1, Student = s30 };
            Painting p31 = new Painting { ImageUrl = "painting_031.jpg", PaintingTitle = "I am Title", Price = 1, Student = s31 };
            Painting p32 = new Painting { ImageUrl = "painting_032.jpg", PaintingTitle = "I am Title", Price = 1, Student = s32 };
            Painting p33 = new Painting { ImageUrl = "painting_033.jpg", PaintingTitle = "I am Title", Price = 1, Student = s33 };
            Painting p34 = new Painting { ImageUrl = "painting_034.jpg", PaintingTitle = "I am Title", Price = 1, Student = s34 };
            Painting p35 = new Painting { ImageUrl = "painting_035.jpg", PaintingTitle = "I am Title", Price = 1, Student = s35 };
            Painting p36 = new Painting { ImageUrl = "painting_036.jpg", PaintingTitle = "I am Title", Price = 1, Student = s36 };
            Painting p37 = new Painting { ImageUrl = "painting_037.jpg", PaintingTitle = "I am Title", Price = 1, Student = s37 };
            Painting p38 = new Painting { ImageUrl = "painting_038.jpg", PaintingTitle = "I am Title", Price = 1, Student = s38 };
            Painting p39 = new Painting { ImageUrl = "painting_039.jpg", PaintingTitle = "I am Title", Price = 1, Student = s39 };

            Painting p40 = new Painting { ImageUrl = "painting_040.jpg", PaintingTitle = "I am Title", Price = 1, Student = s40 };
            Painting p41 = new Painting { ImageUrl = "painting_041.jpg", PaintingTitle = "I am Title", Price = 1, Student = s41 };
            Painting p42 = new Painting { ImageUrl = "painting_042.jpg", PaintingTitle = "I am Title", Price = 1, Student = s42 };
            Painting p43 = new Painting { ImageUrl = "painting_043.jpg", PaintingTitle = "I am Title", Price = 1, Student = s43 };
            Painting p44 = new Painting { ImageUrl = "painting_044.jpg", PaintingTitle = "I am Title", Price = 1, Student = s44 };
            Painting p45 = new Painting { ImageUrl = "painting_045.jpg", PaintingTitle = "I am Title", Price = 1, Student = s45 };
            Painting p46 = new Painting { ImageUrl = "painting_046.jpg", PaintingTitle = "I am Title", Price = 1, Student = s46 };
            Painting p47 = new Painting { ImageUrl = "painting_047.jpg", PaintingTitle = "I am Title", Price = 1, Student = s47 };
            Painting p48 = new Painting { ImageUrl = "painting_048.jpg", PaintingTitle = "I am Title", Price = 1, Student = s48 };
            Painting p49 = new Painting { ImageUrl = "painting_049.jpg", PaintingTitle = "I am Title", Price = 1, Student = s49 };

            Painting p50 = new Painting { ImageUrl = "painting_050.jpg", PaintingTitle = "I am Title", Price = 1, Student = s50 };
            Painting p51 = new Painting { ImageUrl = "painting_051.jpg", PaintingTitle = "I am Title", Price = 1, Student = s51 };
            Painting p52 = new Painting { ImageUrl = "painting_052.jpg", PaintingTitle = "I am Title", Price = 1, Student = s52 };
            Painting p53 = new Painting { ImageUrl = "painting_053.jpg", PaintingTitle = "I am Title", Price = 1, Student = s53 };
            Painting p54 = new Painting { ImageUrl = "painting_054.jpg", PaintingTitle = "I am Title", Price = 1, Student = s54 };
            Painting p55 = new Painting { ImageUrl = "painting_055.jpg", PaintingTitle = "I am Title", Price = 1, Student = s55 };
            Painting p56 = new Painting { ImageUrl = "painting_056.jpg", PaintingTitle = "I am Title", Price = 1, Student = s56 };
            Painting p57 = new Painting { ImageUrl = "painting_057.jpg", PaintingTitle = "I am Title", Price = 1, Student = s57 };
            Painting p58 = new Painting { ImageUrl = "painting_058.jpg", PaintingTitle = "I am Title", Price = 1, Student = s58 };
            Painting p59 = new Painting { ImageUrl = "painting_059.jpg", PaintingTitle = "I am Title", Price = 1, Student = s59 };

            Painting p60 = new Painting { ImageUrl = "painting_060.jpg", PaintingTitle = "I am Title", Price = 1, Student = s60 };
        }
    }
}
