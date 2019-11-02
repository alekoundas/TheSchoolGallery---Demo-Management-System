namespace Web_Front.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AvatarBackgrounds",
                c => new
                    {
                        AvatarBackgroundId = c.Int(nullable: false, identity: true),
                        ImageUrl = c.String(),
                    })
                .PrimaryKey(t => t.AvatarBackgroundId);
            
            CreateTable(
                "dbo.Avatars",
                c => new
                    {
                        AvatarId = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        BodyFK = c.Int(nullable: false),
                        BackgroundFK = c.Int(nullable: false),
                        HairFK = c.Int(nullable: false),
                        ClothingFK = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AvatarId)
                .ForeignKey("dbo.AvatarBodies", t => t.BodyFK, cascadeDelete: true)
                .ForeignKey("dbo.AvatarClothings", t => t.ClothingFK, cascadeDelete: true)
                .ForeignKey("dbo.AvatarHairs", t => t.HairFK, cascadeDelete: true)
                .ForeignKey("dbo.AvatarBackgrounds", t => t.BackgroundFK, cascadeDelete: true)
                .Index(t => t.BodyFK)
                .Index(t => t.BackgroundFK)
                .Index(t => t.HairFK)
                .Index(t => t.ClothingFK);
            
            CreateTable(
                "dbo.AvatarBodies",
                c => new
                    {
                        AvatarBodyId = c.Int(nullable: false, identity: true),
                        ImageUrl = c.String(),
                    })
                .PrimaryKey(t => t.AvatarBodyId);
            
            CreateTable(
                "dbo.AvatarClothings",
                c => new
                    {
                        AvatarClothingId = c.Int(nullable: false, identity: true),
                        ImageUrl = c.String(),
                    })
                .PrimaryKey(t => t.AvatarClothingId);
            
            CreateTable(
                "dbo.AvatarHairs",
                c => new
                    {
                        AvatarHairId = c.Int(nullable: false, identity: true),
                        ImageUrl = c.String(),
                    })
                .PrimaryKey(t => t.AvatarHairId);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        StudentId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        LastName = c.String(nullable: false, maxLength: 50),
                        Age = c.Int(nullable: false),
                        AvatarFK = c.Int(nullable: false),
                        ClassroomFK = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.StudentId)
                .ForeignKey("dbo.Avatars", t => t.AvatarFK, cascadeDelete: true)
                .ForeignKey("dbo.Classrooms", t => t.ClassroomFK, cascadeDelete: true)
                .Index(t => t.AvatarFK)
                .Index(t => t.ClassroomFK);
            
            CreateTable(
                "dbo.Classrooms",
                c => new
                    {
                        ClassroomId = c.Int(nullable: false, identity: true),
                        Image = c.String(),
                        Name = c.String(nullable: false, maxLength: 50),
                        Description = c.String(nullable: false, maxLength: 50),
                        TeacherFK = c.Int(nullable: false),
                        SchoolFK = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ClassroomId)
                .ForeignKey("dbo.Schools", t => t.SchoolFK, cascadeDelete: true)
                .ForeignKey("dbo.Teachers", t => t.TeacherFK, cascadeDelete: true)
                .Index(t => t.TeacherFK)
                .Index(t => t.SchoolFK);
            
            CreateTable(
                "dbo.Schools",
                c => new
                    {
                        SchoolId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        City = c.String(nullable: false, maxLength: 50),
                        Adress = c.String(nullable: false, maxLength: 50),
                        Tel = c.Long(nullable: false),
                        PlaceId = c.String(),
                    })
                .PrimaryKey(t => t.SchoolId);
            
            CreateTable(
                "dbo.Teachers",
                c => new
                    {
                        TeacherId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        LastName = c.String(nullable: false, maxLength: 50),
                        Avatar_AvatarId = c.Int(),
                    })
                .PrimaryKey(t => t.TeacherId)
                .ForeignKey("dbo.Avatars", t => t.Avatar_AvatarId)
                .Index(t => t.Avatar_AvatarId);
            
            CreateTable(
                "dbo.Paintings",
                c => new
                    {
                        PaintingId = c.Int(nullable: false, identity: true),
                        ImageUrl = c.String(),
                        PaintingTitle = c.String(nullable: false, maxLength: 50),
                        StudentFK = c.Int(nullable: false),
                        Price = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.PaintingId)
                .ForeignKey("dbo.Students", t => t.StudentFK, cascadeDelete: true)
                .Index(t => t.StudentFK);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.Avatars", "BackgroundFK", "dbo.AvatarBackgrounds");
            DropForeignKey("dbo.Paintings", "StudentFK", "dbo.Students");
            DropForeignKey("dbo.Classrooms", "TeacherFK", "dbo.Teachers");
            DropForeignKey("dbo.Teachers", "Avatar_AvatarId", "dbo.Avatars");
            DropForeignKey("dbo.Students", "ClassroomFK", "dbo.Classrooms");
            DropForeignKey("dbo.Classrooms", "SchoolFK", "dbo.Schools");
            DropForeignKey("dbo.Students", "AvatarFK", "dbo.Avatars");
            DropForeignKey("dbo.Avatars", "HairFK", "dbo.AvatarHairs");
            DropForeignKey("dbo.Avatars", "ClothingFK", "dbo.AvatarClothings");
            DropForeignKey("dbo.Avatars", "BodyFK", "dbo.AvatarBodies");
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.Paintings", new[] { "StudentFK" });
            DropIndex("dbo.Teachers", new[] { "Avatar_AvatarId" });
            DropIndex("dbo.Classrooms", new[] { "SchoolFK" });
            DropIndex("dbo.Classrooms", new[] { "TeacherFK" });
            DropIndex("dbo.Students", new[] { "ClassroomFK" });
            DropIndex("dbo.Students", new[] { "AvatarFK" });
            DropIndex("dbo.Avatars", new[] { "ClothingFK" });
            DropIndex("dbo.Avatars", new[] { "HairFK" });
            DropIndex("dbo.Avatars", new[] { "BackgroundFK" });
            DropIndex("dbo.Avatars", new[] { "BodyFK" });
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.Paintings");
            DropTable("dbo.Teachers");
            DropTable("dbo.Schools");
            DropTable("dbo.Classrooms");
            DropTable("dbo.Students");
            DropTable("dbo.AvatarHairs");
            DropTable("dbo.AvatarClothings");
            DropTable("dbo.AvatarBodies");
            DropTable("dbo.Avatars");
            DropTable("dbo.AvatarBackgrounds");
        }
    }
}
