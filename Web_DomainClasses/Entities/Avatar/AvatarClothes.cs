using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web_DomainClasses.Entities.Avatar
{
    public class AvatarClothes
    {
        public int AvatarClothesId { get; set; }

        // The Clothes Variation Images
        public string ImageUrl { get; set; }

        // Has one Avatar ---------------------------------->>
        public Avatar Avatar { get; set; }
    }
}
