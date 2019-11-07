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
            Avatar a2 = new Avatar { Background = b02, Hair = h02, Body = bd01, Clothing = c01 };
            Avatar a3 = new Avatar { Background = b03, Hair = h03, Body = bd01, Clothing = c01 };
            Avatar a4 = new Avatar { Background = b04, Hair = h04, Body = bd09, Clothing = c09 };
            Avatar a5 = new Avatar { Background = b05, Hair = h05, Body = bd08, Clothing = c08 };
            Avatar a6 = new Avatar { Background = b06, Hair = h06, Body = bd07, Clothing = c07 };
            Avatar a7 = new Avatar { Background = b07, Hair = h07, Body = bd06, Clothing = c06 };
            Avatar a8 = new Avatar { Background = b08, Hair = h08, Body = bd05, Clothing = c05 };
            Avatar a9 = new Avatar { Background = b09, Hair = h09, Body = bd04, Clothing = c04 };
            Avatar a10 = new Avatar { Background = b01, Hair = h09, Body = bd03, Clothing = c03 };
            Avatar a11 = new Avatar { Background = b02, Hair = h08, Body = bd02, Clothing = c02 };
            Avatar a12 = new Avatar { Background = b03, Hair = h07, Body = bd01, Clothing = c01 };
            Avatar a13 = new Avatar { Background = b04, Hair = h06, Body = bd09, Clothing = c09 };
            Avatar a14 = new Avatar { Background = b05, Hair = h05, Body = bd07, Clothing = c07 };
            Avatar a15 = new Avatar { Background = b06, Hair = h04, Body = bd05, Clothing = c05 };
            Avatar a16 = new Avatar { Background = b07, Hair = h03, Body = bd04, Clothing = c04 };
            Avatar a17 = new Avatar { Background = b08, Hair = h02, Body = bd06, Clothing = c06 };
            Avatar a18 = new Avatar { Background = b09, Hair = h01, Body = bd08, Clothing = c08 };
            Avatar a19 = new Avatar { Background = b01, Hair = h01, Body = bd09, Clothing = c09 };
            Avatar a20 = new Avatar { Background = b02, Hair = h02, Body = bd08, Clothing = c08 };
            Avatar a21 = new Avatar { Background = b03, Hair = h03, Body = bd07, Clothing = c07 };
            Avatar a22 = new Avatar { Background = b04, Hair = h04, Body = bd06, Clothing = c06 };
            Avatar a23 = new Avatar { Background = b05, Hair = h05, Body = bd05, Clothing = c05 };
            Avatar a24 = new Avatar { Background = b06, Hair = h06, Body = bd04, Clothing = c04 };
            Avatar a25 = new Avatar { Background = b07, Hair = h07, Body = bd03, Clothing = c03 };
            Avatar a26 = new Avatar { Background = b08, Hair = h08, Body = bd02, Clothing = c02 };
            Avatar a27 = new Avatar { Background = b09, Hair = h09, Body = bd01, Clothing = c01 };
            Avatar a28 = new Avatar { Background = b01, Hair = h09, Body = bd09, Clothing = c09 };
            Avatar a29 = new Avatar { Background = b02, Hair = h08, Body = bd09, Clothing = c09 };
            Avatar a30 = new Avatar { Background = b03, Hair = h07, Body = bd09, Clothing = c09 };
            Avatar a31 = new Avatar { Background = b04, Hair = h06, Body = bd08, Clothing = c08 };
            Avatar a32 = new Avatar { Background = b05, Hair = h05, Body = bd07, Clothing = c07 };
            Avatar a33 = new Avatar { Background = b06, Hair = h04, Body = bd06, Clothing = c06 };
            Avatar a34 = new Avatar { Background = b07, Hair = h03, Body = bd05, Clothing = c05 };
            Avatar a35 = new Avatar { Background = b08, Hair = h02, Body = bd04, Clothing = c04 };
            Avatar a36 = new Avatar { Background = b09, Hair = h01, Body = bd03, Clothing = c03 };
            Avatar a37 = new Avatar { Background = b01, Hair = h03, Body = bd02, Clothing = c02 };
            Avatar a38 = new Avatar { Background = b02, Hair = h03, Body = bd01, Clothing = c01 };
            Avatar a39 = new Avatar { Background = b03, Hair = h04, Body = bd08, Clothing = c08 };
            Avatar a40 = new Avatar { Background = b04, Hair = h03, Body = bd07, Clothing = c07 };
            Avatar a41 = new Avatar { Background = b05, Hair = h02, Body = bd07, Clothing = c07 };
            Avatar a42 = new Avatar { Background = b06, Hair = h09, Body = bd08, Clothing = c08 };
            Avatar a43 = new Avatar { Background = b07, Hair = h08, Body = bd09, Clothing = c09 };
            Avatar a44 = new Avatar { Background = b08, Hair = h07, Body = bd05, Clothing = c05 };
            Avatar a45 = new Avatar { Background = b09, Hair = h06, Body = bd09, Clothing = c09 };
            Avatar a46 = new Avatar { Background = b01, Hair = h05, Body = bd08, Clothing = c08 };
            Avatar a47 = new Avatar { Background = b02, Hair = h04, Body = bd07, Clothing = c07 };
            Avatar a48 = new Avatar { Background = b03, Hair = h03, Body = bd06, Clothing = c06 };
            Avatar a49 = new Avatar { Background = b04, Hair = h02, Body = bd05, Clothing = c05 };
            Avatar a50 = new Avatar { Background = b05, Hair = h01, Body = bd04, Clothing = c04 };
            Avatar a51 = new Avatar { Background = b06, Hair = h07, Body = bd03, Clothing = c03 };
            Avatar a52 = new Avatar { Background = b07, Hair = h04, Body = bd02, Clothing = c02 };
            Avatar a53 = new Avatar { Background = b08, Hair = h09, Body = bd01, Clothing = c01 };
            Avatar a54 = new Avatar { Background = b09, Hair = h08, Body = bd09, Clothing = c09 };
            Avatar a55 = new Avatar { Background = b01, Hair = h07, Body = bd08, Clothing = c08 };
            Avatar a56 = new Avatar { Background = b02, Hair = h06, Body = bd07, Clothing = c07 };
            Avatar a57 = new Avatar { Background = b03, Hair = h05, Body = bd06, Clothing = c06 };
            Avatar a58 = new Avatar { Background = b04, Hair = h04, Body = bd05, Clothing = c05 };
            Avatar a59 = new Avatar { Background = b05, Hair = h03, Body = bd04, Clothing = c04 };
            Avatar a60 = new Avatar { Background = b06, Hair = h02, Body = bd03, Clothing = c03 };


            context.AvatarDb.Add( a1 );
            context.AvatarDb.Add( a2 );
            context.AvatarDb.Add( a3 );
            context.AvatarDb.Add( a4 );
            context.AvatarDb.Add( a5 );
            context.AvatarDb.Add( a6 );
            context.AvatarDb.Add( a7 );
            context.AvatarDb.Add( a8 );
            context.AvatarDb.Add( a9 );
            context.AvatarDb.Add( a10);
            context.AvatarDb.Add( a11);
            context.AvatarDb.Add( a12);
            context.AvatarDb.Add( a13);
            context.AvatarDb.Add( a14);
            context.AvatarDb.Add( a15);
            context.AvatarDb.Add( a16);
            context.AvatarDb.Add( a17);
            context.AvatarDb.Add( a18);
            context.AvatarDb.Add( a19);
            context.AvatarDb.Add( a20);
            context.AvatarDb.Add( a21);
            context.AvatarDb.Add( a22);
            context.AvatarDb.Add( a23);
            context.AvatarDb.Add( a24);
            context.AvatarDb.Add( a25);
            context.AvatarDb.Add( a26);
            context.AvatarDb.Add( a27);
            context.AvatarDb.Add( a28);
            context.AvatarDb.Add( a29);
            context.AvatarDb.Add( a30);
            context.AvatarDb.Add( a31);
            context.AvatarDb.Add( a32);
            context.AvatarDb.Add( a33);
            context.AvatarDb.Add( a34);
            context.AvatarDb.Add( a35);
            context.AvatarDb.Add( a36);
            context.AvatarDb.Add( a37);
            context.AvatarDb.Add( a38);
            context.AvatarDb.Add( a39);
            context.AvatarDb.Add( a40);
            context.AvatarDb.Add( a41);
            context.AvatarDb.Add( a42);
            context.AvatarDb.Add( a43);
            context.AvatarDb.Add( a44);
            context.AvatarDb.Add( a45);
            context.AvatarDb.Add( a46);
            context.AvatarDb.Add( a47);
            context.AvatarDb.Add( a48);
            context.AvatarDb.Add( a49);
            context.AvatarDb.Add( a50);
            context.AvatarDb.Add( a51);
            context.AvatarDb.Add( a52);
            context.AvatarDb.Add( a53);
            context.AvatarDb.Add( a54);
            context.AvatarDb.Add( a55);
            context.AvatarDb.Add( a56);
            context.AvatarDb.Add( a57);
            context.AvatarDb.Add( a58);
            context.AvatarDb.Add( a59);
            context.AvatarDb.Add( a60);
            context.SaveChanges();

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


            // PAINTINGS ------------------------------------------------------------------------------->>  
            Painting p00 = new Painting { ImageUrl = "painting_000.jpg", Price = 1, PaintingTitle = "No Painting" };
            Painting p01 = new Painting { ImageUrl = "painting_001.jpg", Price = 1, PaintingTitle = "Fall" };
            Painting p02 = new Painting { ImageUrl = "painting_002.jpg", Price = 1, PaintingTitle = "Fall Again" };
            Painting p03 = new Painting { ImageUrl = "painting_003.jpg", Price = 1, PaintingTitle = "Old China" };
            Painting p04 = new Painting { ImageUrl = "painting_004.jpg", Price = 1, PaintingTitle = "Old China" };
            Painting p05 = new Painting { ImageUrl = "painting_005.jpg", Price = 1, PaintingTitle = "Red Panda" };
            Painting p06 = new Painting { ImageUrl = "painting_006.jpg", Price = 1, PaintingTitle = "90 Degrees" };
            Painting p07 = new Painting { ImageUrl = "painting_007.jpg", Price = 1, PaintingTitle = "Rouster" };
            Painting p08 = new Painting { ImageUrl = "painting_008.jpg", Price = 1, PaintingTitle = "Lake Xu" };
            Painting p09 = new Painting { ImageUrl = "painting_009.jpg", Price = 1, PaintingTitle = "Bird" };
            Painting p10 = new Painting { ImageUrl = "painting_010.jpg", Price = 1, PaintingTitle = "Lake Tai" };
            Painting p11 = new Painting { ImageUrl = "painting_011.jpg", Price = 1, PaintingTitle = "Outside Table" };
            Painting p12 = new Painting { ImageUrl = "painting_012.jpg", Price = 1, PaintingTitle = "Birdies" };
            Painting p13 = new Painting { ImageUrl = "painting_013.jpg", Price = 1, PaintingTitle = "Lake Side" };
            Painting p14 = new Painting { ImageUrl = "painting_014.jpg", Price = 1, PaintingTitle = "Village" };
            Painting p15 = new Painting { ImageUrl = "painting_015.jpg", Price = 1, PaintingTitle = "Outside" };
            Painting p16 = new Painting { ImageUrl = "painting_016.jpg", Price = 1, PaintingTitle = "Bottles" };
            Painting p17 = new Painting { ImageUrl = "painting_017.jpg", Price = 1, PaintingTitle = "Taiger" };
            Painting p18 = new Painting { ImageUrl = "painting_018.jpg", Price = 1, PaintingTitle = "Gafild" };
            Painting p19 = new Painting { ImageUrl = "painting_019.jpg", Price = 1, PaintingTitle = "Spotty" };
            Painting p20 = new Painting { ImageUrl = "painting_020.jpg", Price = 1, PaintingTitle = "Jacky" };
            Painting p21 = new Painting { ImageUrl = "painting_021.jpg", Price = 1, PaintingTitle = "Boofy" };
            Painting p22 = new Painting { ImageUrl = "painting_022.jpg", Price = 1, PaintingTitle = "Spark" };
            Painting p23 = new Painting { ImageUrl = "painting_023.jpg", Price = 1, PaintingTitle = "Cat at Window" };
            Painting p24 = new Painting { ImageUrl = "painting_024.jpg", Price = 1, PaintingTitle = "Kitchen" };
            Painting p25 = new Painting { ImageUrl = "painting_025.jpg", Price = 1, PaintingTitle = "Kitchen" };
            Painting p26 = new Painting { ImageUrl = "painting_026.jpg", Price = 1, PaintingTitle = "Bottles" };
            Painting p27 = new Painting { ImageUrl = "painting_027.jpg", Price = 1, PaintingTitle = "Village Celebration" };
            Painting p28 = new Painting { ImageUrl = "painting_028.jpg", Price = 1, PaintingTitle = "Blue Mist" };
            Painting p29 = new Painting { ImageUrl = "painting_029.jpg", Price = 1, PaintingTitle = "Under Water" };
            Painting p30 = new Painting { ImageUrl = "painting_030.jpg", Price = 1, PaintingTitle = "Mountain Home" };
            Painting p31 = new Painting { ImageUrl = "painting_031.jpg", Price = 1, PaintingTitle = "Flowers" };
            Painting p32 = new Painting { ImageUrl = "painting_032.jpg", Price = 1, PaintingTitle = "Pastel Flowers" };
            Painting p33 = new Painting { ImageUrl = "painting_033.jpg", Price = 1, PaintingTitle = "Green" };
            Painting p34 = new Painting { ImageUrl = "painting_034.jpg", Price = 1, PaintingTitle = "I made a Mess" };
            Painting p35 = new Painting { ImageUrl = "painting_035.jpg", Price = 1, PaintingTitle = "Our Cow" };
            Painting p36 = new Painting { ImageUrl = "painting_036.jpg", Price = 1, PaintingTitle = "Snoopy" };
            Painting p37 = new Painting { ImageUrl = "painting_037.jpg", Price = 1, PaintingTitle = "Old man Li" };
            Painting p38 = new Painting { ImageUrl = "painting_038.jpg", Price = 1, PaintingTitle = "Villagers" };
            Painting p39 = new Painting { ImageUrl = "painting_039.jpg", Price = 1, PaintingTitle = "Suburbs" };
            Painting p40 = new Painting { ImageUrl = "painting_040.jpg", Price = 1, PaintingTitle = "Villagers" };
            Painting p41 = new Painting { ImageUrl = "painting_041.jpg", Price = 1, PaintingTitle = "Villagers" };
            Painting p42 = new Painting { ImageUrl = "painting_042.jpg", Price = 1, PaintingTitle = "Valley" };
            Painting p43 = new Painting { ImageUrl = "painting_043.jpg", Price = 1, PaintingTitle = "One Brush" };
            Painting p44 = new Painting { ImageUrl = "painting_044.jpg", Price = 1, PaintingTitle = "Blue Wet" };
            Painting p45 = new Painting { ImageUrl = "painting_045.jpg", Price = 1, PaintingTitle = "I Broke my Pen" };
            Painting p46 = new Painting { ImageUrl = "painting_046.jpg", Price = 1, PaintingTitle = "Pattern" };
            Painting p47 = new Painting { ImageUrl = "painting_047.jpg", Price = 1, PaintingTitle = "Trees" };
            Painting p48 = new Painting { ImageUrl = "painting_048.jpg", Price = 1, PaintingTitle = "Ma Favorit" };
            Painting p49 = new Painting { ImageUrl = "painting_049.jpg", Price = 1, PaintingTitle = "War is Bad" };
            Painting p50 = new Painting { ImageUrl = "painting_050.jpg", Price = 1, PaintingTitle = "War is Bad" };
            Painting p51 = new Painting { ImageUrl = "painting_051.jpg", Price = 1, PaintingTitle = "War is Bad" };
            Painting p52 = new Painting { ImageUrl = "painting_052.jpg", Price = 1, PaintingTitle = "El Esdi" };
            Painting p53 = new Painting { ImageUrl = "painting_053.jpg", Price = 1, PaintingTitle = "Ellen Sdee" };
            Painting p54 = new Painting { ImageUrl = "painting_054.jpg", Price = 1, PaintingTitle = "Eles Dee" };
            Painting p55 = new Painting { ImageUrl = "painting_055.jpg", Price = 1, PaintingTitle = "Sea" };
            Painting p56 = new Painting { ImageUrl = "painting_056.jpg", Price = 1, PaintingTitle = "Sleeping Birds" };
            Painting p57 = new Painting { ImageUrl = "painting_057.jpg", Price = 1, PaintingTitle = "My Home" };
            Painting p58 = new Painting { ImageUrl = "painting_058.jpg", Price = 1, PaintingTitle = "Fishy" };
            Painting p59 = new Painting { ImageUrl = "painting_059.jpg", Price = 1, PaintingTitle = "Fishy" };
            Painting p60 = new Painting { ImageUrl = "painting_060.jpg", Price = 1, PaintingTitle = "My Village" };
            Painting p61 = new Painting { ImageUrl = "painting_061.jpg", Price = 1, PaintingTitle = "Home" };
            Painting p62 = new Painting { ImageUrl = "painting_062.jpg", Price = 1, PaintingTitle = "Fish" };
            Painting p63 = new Painting { ImageUrl = "painting_063.jpg", Price = 1, PaintingTitle = "Pasxalitsa", };
            Painting p64 = new Painting { ImageUrl = "painting_064.jpg", Price = 1, PaintingTitle = "Stary Sky" };
            Painting p65 = new Painting { ImageUrl = "painting_065.jpg", Price = 1, PaintingTitle = "Stary Sky" };
            Painting p66 = new Painting { ImageUrl = "painting_066.jpg", Price = 1, PaintingTitle = "Neberhood" };
            Painting p67 = new Painting { ImageUrl = "painting_067.jpg", Price = 1, PaintingTitle = "Neiberhood" };
            Painting p68 = new Painting { ImageUrl = "painting_068.jpg", Price = 1, PaintingTitle = "Birdy" };
            Painting p69 = new Painting { ImageUrl = "painting_069.jpg", Price = 1, PaintingTitle = "Neberhoud" };
            Painting p70 = new Painting { ImageUrl = "painting_070.jpg", Price = 1, PaintingTitle = "Neiberhud" };
            Painting p71 = new Painting { ImageUrl = "painting_071.jpg", Price = 1, PaintingTitle = "Moon Home" };
            Painting p72 = new Painting { ImageUrl = "painting_072.jpg", Price = 1, PaintingTitle = "Mai Tri" };
            Painting p73 = new Painting { ImageUrl = "painting_073.jpg", Price = 1, PaintingTitle = "Mi Tree" };
            Painting p74 = new Painting { ImageUrl = "painting_074.jpg", Price = 1, PaintingTitle = "Ma Tri" };

















            // STUDENTS ------------------------------------------------------------------------------->>  
            Student s01 = new Student { StudentId = 01, Age = 5, AvatarFK = 1 , Paintings = new List<Painting> { p01, p02 }, FirstName = "James", LastName = "Hernandez" };
            Student s02 = new Student { StudentId = 02, Age = 5, AvatarFK = 2 , Paintings = new List<Painting> { p03, p04 }, FirstName = "Senzieng", LastName = "Hou" };
            Student s03 = new Student { StudentId = 03, Age = 5, AvatarFK = 3 , Paintings = new List<Painting> { p06 }, FirstName = "Robert", LastName = "Rodriguez" };
            Student s04 = new Student { StudentId = 04, Age = 5, AvatarFK = 4 , Paintings = new List<Painting> { p00 }, FirstName = "Maria", LastName = "Garcia" };
            Student s05 = new Student { StudentId = 05, Age = 5, AvatarFK = 5 , Paintings = new List<Painting> { p07, p09, p05 }, FirstName = "Fumiko", LastName = "Koyama" };
            Student s06 = new Student { StudentId = 06, Age = 5, AvatarFK = 6 , Paintings = new List<Painting> { p08, p10 }, FirstName = "Ryoya", LastName = "Urehara" };
            Student s07 = new Student { StudentId = 07, Age = 5, AvatarFK = 7 , Paintings = new List<Painting> { p11 }, FirstName = "Kim", LastName = "Yun" };
            Student s08 = new Student { StudentId = 08, Age = 5, AvatarFK = 8 , Paintings = new List<Painting> { p12, p13 }, FirstName = "Fael", LastName = "Faery" };
            Student s09 = new Student { StudentId = 09, Age = 5, AvatarFK = 9 , Paintings = new List<Painting> { p14, p15 }, FirstName = "Amanda", LastName = "Diamond" };
            Student s10 = new Student { StudentId = 10, Age = 5, AvatarFK = 10, Paintings = new List<Painting> { p16, p23 }, FirstName = "Michael", LastName = "Shumy" };
            Student s11 = new Student { StudentId = 11, Age = 6, AvatarFK = 11, Paintings = new List<Painting> { p17 }, FirstName = "Will", LastName = "Smooth" };
            Student s12 = new Student { StudentId = 12, Age = 6, AvatarFK = 12, Paintings = new List<Painting> { p18, p19, p20, p21, p22 }, FirstName = "Bob", LastName = "Sfougg" };
            Student s13 = new Student { StudentId = 13, Age = 6, AvatarFK = 13, Paintings = new List<Painting> { p29, p46 }, FirstName = "Jenny", LastName = "Ntouzi" };
            Student s14 = new Student { StudentId = 14, Age = 6, AvatarFK = 14, Paintings = new List<Painting> { p31, p32 }, FirstName = "Mathiew", LastName = "MacTrack" };
            Student s15 = new Student { StudentId = 15, Age = 6, AvatarFK = 15, Paintings = new List<Painting> { p30, p33, p34, p35 }, FirstName = "Mairy", LastName = "Pops" };
            Student s16 = new Student { StudentId = 16, Age = 6, AvatarFK = 16, Paintings = new List<Painting> { p36 }, FirstName = "Triplos", LastName = "Kakos" };
            Student s17 = new Student { StudentId = 17, Age = 6, AvatarFK = 17, Paintings = new List<Painting> { p37, p45, p47 }, FirstName = "Diplos", LastName = "Arithmos" };
            Student s18 = new Student { StudentId = 18, Age = 6, AvatarFK = 18, Paintings = new List<Painting> { p48, p44 }, FirstName = "Monos", LastName = "Erimos" };
            Student s19 = new Student { StudentId = 19, Age = 6, AvatarFK = 19, Paintings = new List<Painting> { p42, p43 }, FirstName = "Notis", LastName = "Sfakias" };
            Student s20 = new Student { StudentId = 20, Age = 7, AvatarFK = 20, Paintings = new List<Painting> { p48 }, FirstName = "Lookia", LastName = "Kelaidoni" };
            Student s21 = new Student { StudentId = 21, Age = 7, AvatarFK = 21, Paintings = new List<Painting> { p49, p57 }, FirstName = "Mairy", LastName = "Dounia" };
            Student s22 = new Student { StudentId = 22, Age = 7, AvatarFK = 22, Paintings = new List<Painting> { p50, p62, p68 }, FirstName = "Xristina", LastName = "Mama" };
            Student s23 = new Student { StudentId = 23, Age = 7, AvatarFK = 23, Paintings = new List<Painting> { p51, p59 }, FirstName = "Jenny", LastName = "Mpotsi" };
            Student s24 = new Student { StudentId = 24, Age = 7, AvatarFK = 24, Paintings = new List<Painting> { p55, p56, p58 }, FirstName = "Zozo", LastName = "Markoulaki" };
            Student s25 = new Student { StudentId = 25, Age = 7, AvatarFK = 25, Paintings = new List<Painting> { p60, p63 }, FirstName = "Babis", LastName = "Lipsos" };
            Student s26 = new Student { StudentId = 26, Age = 6, AvatarFK = 26, Paintings = new List<Painting> { p61 }, FirstName = "Volos", LastName = "Mpilias" };
            Student s27 = new Student { StudentId = 27, Age = 7, AvatarFK = 27, Paintings = new List<Painting> { p66 }, FirstName = "Yiorgos", LastName = "Georgiou" };
            Student s28 = new Student { StudentId = 28, Age = 7, AvatarFK = 28, Paintings = new List<Painting> { p67 }, FirstName = "Ioannis", LastName = "Xaros" };
            Student s29 = new Student { StudentId = 29, Age = 7, AvatarFK = 29, Paintings = new List<Painting> { p71, p70 }, FirstName = "Vaggelis", LastName = "Giortis" };
            Student s30 = new Student { StudentId = 30, Age = 8, AvatarFK = 30, Paintings = new List<Painting> { p52, p53, p54 }, FirstName = "Artemis", LastName = "Matsas" };
            Student s31 = new Student { StudentId = 31, Age = 8, AvatarFK = 31, Paintings = new List<Painting> { p27, p28 }, FirstName = "Iosif", LastName = "Pateras" };
            Student s32 = new Student { StudentId = 32, Age = 8, AvatarFK = 32, Paintings = new List<Painting> { p38, p39 }, FirstName = "Kostas", LastName = "Karagkounis" };
            Student s33 = new Student { StudentId = 33, Age = 8, AvatarFK = 33, Paintings = new List<Painting> { p40, }, FirstName = "Elias", LastName = "Apalou" };
            Student s34 = new Student { StudentId = 34, Age = 8, AvatarFK = 34, Paintings = new List<Painting> { p41, }, FirstName = "Ektoras", LastName = "Limnios" };
            Student s35 = new Student { StudentId = 35, Age = 8, AvatarFK = 35, Paintings = new List<Painting> { p69, }, FirstName = "Ifigeneia", LastName = "Grevena" };
            Student s36 = new Student { StudentId = 36, Age = 8, AvatarFK = 36, Paintings = new List<Painting> { }, FirstName = "Manolis", LastName = "Kairos" };
            Student s37 = new Student { StudentId = 37, Age = 9, AvatarFK = 37, Paintings = new List<Painting> { }, FirstName = "Giannis", LastName = "Xromas" };
            Student s38 = new Student { StudentId = 38, Age = 9, AvatarFK = 38, Paintings = new List<Painting> { }, FirstName = "Nikos", LastName = "Gkagkas" };
            Student s39 = new Student { StudentId = 39, Age = 9, AvatarFK = 39, Paintings = new List<Painting> { }, FirstName = "Yiorgos", LastName = "Dedes" };
            Student s40 = new Student { StudentId = 40, Age = 9, AvatarFK = 40, Paintings = new List<Painting> { }, FirstName = "Betty", LastName = "Mpantianou" };
            Student s41 = new Student { StudentId = 41, Age = 9, AvatarFK = 41, Paintings = new List<Painting> { }, FirstName = "Michalis", LastName = "Karydas" };
            Student s42 = new Student { StudentId = 42, Age = 9, AvatarFK = 42, Paintings = new List<Painting> { p64, p65 }, FirstName = "Rea Ifigeneia", LastName = "Chorman" };
            Student s43 = new Student { StudentId = 43, Age = 8, AvatarFK = 43, Paintings = new List<Painting> { }, FirstName = "Johnnys", LastName = "Perpatitis" };
            Student s44 = new Student { StudentId = 44, Age = 10,AvatarFK = 44, Paintings = new List<Painting> { }, FirstName = "Dimitris", LastName = "Lymperis" };
            Student s45 = new Student { StudentId = 45, Age = 8, AvatarFK = 45, Paintings = new List<Painting> { }, FirstName = "Filippas", LastName = "Mpitsis" };
            Student s46 = new Student { StudentId = 46, Age = 8, AvatarFK = 46, Paintings = new List<Painting> { }, FirstName = "Alexis", LastName = "Prothypos" };
            Student s47 = new Student { StudentId = 47, Age = 10,AvatarFK = 47, Paintings = new List<Painting> { }, FirstName = "Konstantinos", LastName = "Torinos" };
            Student s48 = new Student { StudentId = 48, Age = 10,AvatarFK = 48, Paintings = new List<Painting> { }, FirstName = "Maria", LastName = "Maraki" };
            Student s49 = new Student { StudentId = 49, Age = 10,AvatarFK = 49, Paintings = new List<Painting> { }, FirstName = "Katerina", LastName = "Vafeidi" };
            Student s50 = new Student { StudentId = 50, Age = 9, AvatarFK = 50, Paintings = new List<Painting> { }, FirstName = "Vaggelitsa", LastName = "Grylou" };
            Student s51 = new Student { StudentId = 51, Age = 9, AvatarFK = 51, Paintings = new List<Painting> { }, FirstName = "Hector", LastName = "Gatsos" };
            Student s52 = new Student { StudentId = 52, Age = 9, AvatarFK = 52, Paintings = new List<Painting> { }, FirstName = "Mike", LastName = "Lawry" };
            Student s53 = new Student { StudentId = 53, Age = 10,AvatarFK = 53, Paintings = new List<Painting> { }, FirstName = "Vanessa", LastName = "Smith" };
            Student s54 = new Student { StudentId = 54, Age = 10,AvatarFK = 54, Paintings = new List<Painting> { }, FirstName = "Maria", LastName = "Mpihi" };
            Student s55 = new Student { StudentId = 55, Age = 10,AvatarFK = 55, Paintings = new List<Painting> { }, FirstName = "Kostas", LastName = "Malamoutis" };
            Student s56 = new Student { StudentId = 56, Age = 10,AvatarFK = 56, Paintings = new List<Painting> { }, FirstName = "Yiannis", LastName = "Noaa" };
            Student s57 = new Student { StudentId = 57, Age = 10,AvatarFK = 57, Paintings = new List<Painting> { }, FirstName = "Kaori", LastName = "Koyama" };
            Student s58 = new Student { StudentId = 58, Age = 10,AvatarFK = 58, Paintings = new List<Painting> { p73, p74 }, FirstName = "Jessica", LastName = "Nian" };
            Student s59 = new Student { StudentId = 59, Age = 10,AvatarFK = 59, Paintings = new List<Painting> { p72 }, FirstName = "Biki", LastName = "Valgeri" };
            Student s60 = new Student { StudentId = 60, Age = 11, AvatarFK = 60, Paintings = new List<Painting> { p24, p25, p26 }, FirstName = "Ifigeneia", LastName = "Fotopoulou" };
                                                                          

            // CLASSROOM ------------------------------------------------------------------------------->>  
            List<Student> slist = new List<Student> { s01, s02, s03, s04, s05, s06, s07, s08, s09, s13 };
            Classroom cl1 = new Classroom { ClassroomId = 1, Name = "Preliminary", Description = "Η ταξη του 2017", Image = "grade_00.jpg", Teacher = t01, Students = new List<Student> { s01, s02, s03, s04, s05, s06, s07, s08, s09, s13 } };
            Classroom cl2 = new Classroom { ClassroomId = 2, Name = "First Grade", Description = "Η ταξη του 2017", Image = "grade_01.jpg", Teacher = t05, Students = new List<Student> { s10, s11, s12, s14, s15, s16, s17, s18, s19 } };
            Classroom cl3 = new Classroom { ClassroomId = 3, Name = "Second Grade", Description = "Η ταξη του 2018", Image = "grade_02.jpg", Teacher = t06, Students = new List<Student> { s20, s21, s22, s24, s25, s26 } };
            Classroom cl4 = new Classroom { ClassroomId = 4, Name = "Third Grade", Description = "Η ταξη του 2019", Image = "grade_03.jpg", Teacher = t02, Students = new List<Student> { s30, s31, s32, s34, s35, s36, s27, s28, s29 } };
            Classroom cl5 = new Classroom { ClassroomId = 5, Name = "Fourth Grade", Description = "Η ταξη του 2020", Image = "grade_04.jpg", Teacher = t03, Students = new List<Student> { s40, s41, s42, s44, s45, s46, s59 } };
            Classroom cl6 = new Classroom { ClassroomId = 6, Name = "Fifth Grade", Description = "Η ταξη του 2020", Image = "grade_05.jpg", Teacher = t07, Students = new List<Student> { s37, s38, s39, s50, s51, s52, s60 } };
            Classroom cl7 = new Classroom { ClassroomId = 7, Name = "Sixth Grade", Description = "Η ταξη του 2020", Image = "grade_06.jpg", Teacher = t04, Students = new List<Student> { s47, s48, s49, s53, s54, s55, s56, s57, s58 } };



            // SCHOOLS ------------------------------------------------------------------------------->>  
            School sh01 = new School { Name = "The Lindle School", City = "London", Adress = "59 Picabou Str. SQ9 DZ8 London", Tel = 2109299999, Classrooms = new List<Classroom> { cl1, cl2 } };
            School sh02 = new School { Name = "Little People", City = "Hangzhou", Adress = "156 XiWu", Tel = 210896542, Classrooms = new List<Classroom> { cl3, cl4 } };
            School sh03 = new School { Name = "Nipio", City = "Limnos", Adress = "27 Hroon Str. TK81100 Myrina", Tel = 2109788888, Classrooms = new List<Classroom> {/* cl5, cl6*/ } };
            School sh04 = new School { Name = "Faliro School of Arts", City = "Athens", Adress = "56 Agiou Alexandrou TK17561 P.Faliro", Tel = 2106822222, Classrooms = new List<Classroom> { cl7 } };



            context.SchoolsDb.AddOrUpdate(sh01);
            context.SchoolsDb.AddOrUpdate(sh02);
            //context.SchoolsDb.AddOrUpdate(sh03);//has error!!! DONT RUN
            context.SchoolsDb.AddOrUpdate(sh04);

            context.SaveChanges();


        }
    }
}
