using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi_Entities.Avatar
{
    public class AvatarBody
    {
        public int AvatarBodyId { get; set; }

        // The Body Variation Images
        public string ImageUrl { get; set; }

        // Has one Avatar ---------------------------------->>
        public Avatar Avatar { get; set; }
    }
}
