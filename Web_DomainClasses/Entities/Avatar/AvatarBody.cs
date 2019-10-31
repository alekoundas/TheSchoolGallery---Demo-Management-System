using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web_DomainClasses.Entities.Avatar
{
    public class AvatarBody
    {
        [ForeignKey("Avatar")]
        public int AvatarBodyId { get; set; }

        // The Body Variation Images
        public string ImageUrl { get; set; }

        // Has one Avatar ---------------------------------->>
        public Avatar Avatar { get; set; }
    }
}
