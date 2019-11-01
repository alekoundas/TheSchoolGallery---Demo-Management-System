using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace Web_DomainClasses.Entities.Avatar
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
