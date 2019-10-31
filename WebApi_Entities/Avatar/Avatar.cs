﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi_Entities.Avatar
{
    public class Avatar
    {
        public int AvatarId { get; set; }
        public string Title { get; set; }

        // Has many Avatar Elements ------------------------------>>
        [ForeignKey("BodyFK")]
        public AvatarBody Body { get; set; }
        public int BodyFK { get; set; }
        [ForeignKey("BackgroundFK")]
        public AvatarBackground Background { get; set; }
        public int BackgroundFK { get; set; }
        [ForeignKey("HairFK")]
        public  AvatarHair Hair { get; set; }
        public int HairFK { get; set; }
        [ForeignKey("ClothingFK")]
        public  AvatarClothing Clothing { get; set; }
        public int ClothingFK { get; set; }

    }
}
