using System.Collections.Generic;
using Web_DomainClasses.Entities.Avatar;

namespace Web_DomainClasses.ViewModels
{
    public class AvatarCreateVM
    {
        public Avatar Avatar { get; set; }
        public int SelectedSchoolID { get; set; }
        public ICollection<AvatarBackground> AvatarBackgrounds { get; set; }
        public ICollection<AvatarHair> AvatarHairs { get; set; }
        public ICollection<AvatarBody> AvatarBodys { get; set; }
        public ICollection<AvatarClothing> AvatarClothings { get; set; }
        public int SelectedBackgroundID { get; set; }
        public int SelectedHairID { get; set; }
        public int SelectedBodyID { get; set; }
        public int SelectedClothingID { get; set; }


    }
}
