﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi_Entities.Avatar
{
    public class AvatarBackground
    {
        [ForeignKey("Avatar")]
        public int AvatarBackgroundId { get; set; }

        // The Background Variation Images
        public string ImageUrl { get; set; }

        // Has one Avatar ---------------------------------->>
        public ICollection<Avatar> Avatar { get; set; }
    }
}
