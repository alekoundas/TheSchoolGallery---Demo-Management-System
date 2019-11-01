using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web_DomainClasses.Entities.School
{
    public  class Student
    {
        public int StudentId { get; set; }

        [Required(ErrorMessage = "Everybody has a Name")]
        [MinLength(2, ErrorMessage = "Name must be longer")]
        [MaxLength(50, ErrorMessage = "Name must be shorter")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Everybody has a Surname")]
        [MinLength(2, ErrorMessage = "Surname must be longer")]
        [MaxLength(50, ErrorMessage = "Surname must be shorter")]
        public string LastName { get; set; }

        [Range(2, 20, ErrorMessage = "Age must be Between 2 and 20 years old")]
        public int Age { get; set; }

        // Has many Paintings ------------------------------>>
        public  ICollection<Painting> Paintings { get; set; }

        // Has one Avatar ---------------------------------->>
        [ForeignKey("AvatarFK")]
        public Avatar.Avatar Avatar { get; set; }
        public int AvatarFK { get; set; }

        // Has one Class ----------------------------------->>
        [ForeignKey("ClassroomFK")]
        public Classroom Classroom { get; set; }

        public int ClassroomFK { get; set; }
    }
}
