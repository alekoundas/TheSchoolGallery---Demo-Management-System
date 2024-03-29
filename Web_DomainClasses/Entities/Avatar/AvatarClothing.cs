﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web_DomainClasses.Entities.Avatar
{
    public class AvatarClothing
    {
        [ForeignKey("Avatar")]
        public int AvatarClothingId { get; set; }

        // The Clothes Variation Images
        public string ImageUrl { get; set; }

        // Has one Avatar ---------------------------------->>
        public List<Avatar> Avatar { get; set; }

    }
}
