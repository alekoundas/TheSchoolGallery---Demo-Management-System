﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi_Entities;
using WebApi_Entities.Avatar;
using WebApi_Entities.School;
using WebApi_Entities.SignalR;
using WebApi_Entities.Sales;

namespace WebApi_Database
{
    public class GalleryDbContext : DbContext
    {
        public GalleryDbContext() : base("name=ConnStringAPI")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }


        public DbSet<Avatar> AvatarDb { get; set; }
        public DbSet<AvatarBackground> AvatarBackgroundDb { get; set; }
        public DbSet<AvatarHair> AvatarHairDb { get; set; }
        public DbSet<AvatarBody> AvatarBodyDb { get; set; }
        public DbSet<AvatarClothing> AvatarClothingDb { get; set; }
        public DbSet<Student> StudentDb { get; set; }
        public DbSet<Teacher> TeacherDb { get; set; }
        public DbSet<Classroom> ClassroomsDb { get; set; }
        public DbSet<School> SchoolsDb { get; set; }
        public DbSet<Painting> PaintingsDb { get; set; }
        public DbSet<MessageHistory> MessageHistoryDb { get; set; }
        public DbSet<PurchacedItem> PurchacedItemDb { get; set; }
        public DbSet<Sale> SaleDb { get; set; }
    }
}
