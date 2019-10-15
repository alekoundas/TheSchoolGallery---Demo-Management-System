using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Web_DomainClasses.Entities.School
{
    public  class Student
    {
        public int StudentId { get; set; }

        [Required(ErrorMessage = "Everybody has a Name")]
        [MinLength(2, ErrorMessage = "Name must be longer")]
        [MaxLength(12, ErrorMessage = "Name must be shorter")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Everybody has a Surname")]
        [MinLength(2, ErrorMessage = "Surname must be longer")]
        [MaxLength(12, ErrorMessage = "Surname must be shorter")]
        public string LastName { get; set; }

        [Range(2, 20, ErrorMessage = "Age must be Between 2 and 20 years old")]
        public int Age { get; set; }

        // Has many Paintings ------------------------------>>
        public  ICollection<Painting> Paintings { get; set; }

        // Has one Avatar ---------------------------------->>
        public  Avatar.Avatar Avatar { get; set; }

        // Has one Class ----------------------------------->>
        public  Classroom Classroom { get; set; }
    }
}
