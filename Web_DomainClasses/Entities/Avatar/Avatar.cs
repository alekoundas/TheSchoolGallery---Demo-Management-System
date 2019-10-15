using System.Collections.Generic;

namespace Web_DomainClasses.Entities.Avatar
{
    public class Avatar
    {
        public int AvatarId { get; set; }
        public string Title { get; set; }

        // Has many Avatar Elements ------------------------------>>
        public ICollection<AvatarBody> Bodys { get; set; }
        public ICollection<AvatarBackground> Backgrounds { get; set; }
        public  ICollection<AvatarHair> Hairs { get; set; }
        public  ICollection<AvatarClothes> Clothes { get; set; }


    }
}
