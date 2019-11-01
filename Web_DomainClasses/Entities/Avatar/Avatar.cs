using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Web_DomainClasses.Entities.School;

namespace Web_DomainClasses.Entities.Avatar
{
    public class Avatar
    {
        public int AvatarId { get; set; }
        public string Title { get; set; }

        public ICollection<Student> Students { get; set; }

        // Has One Avatar Element ------------------------------>>

        [ForeignKey("BodyFK")]
        public AvatarBody Body { get; set; }
        public int BodyFK { get; set; }


        [ForeignKey("BackgroundFK")]
        public AvatarBackground Background { get; set; }
        public int BackgroundFK { get; set; }


        [ForeignKey("HairFK")]
        public AvatarHair Hair { get; set; }
        public int HairFK { get; set; }


        [ForeignKey("ClothingFK")]
        public AvatarClothing Clothing { get; set; }
        public int ClothingFK { get; set; }

    }
}
