using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web_Entities.Avatar
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
