using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi_Entities.Avatar
{
    public class AvatarHair
    {
        [ForeignKey("Avatar")]
        public int AvatarHairId { get; set; }

        // The Hair Variation Images
        public string ImageUrl { get; set; }

        // Has one Avatar ---------------------------------->>
        public List<Avatar> Avatar { get; set; }

    }
}
