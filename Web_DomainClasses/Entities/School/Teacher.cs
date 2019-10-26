using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Web_DomainClasses.Entities.School
{
    public  class Teacher
    {

        public int TeacherId { get; set; }

        [Required(ErrorMessage = "Everybody has a Name")]
        [MinLength(2, ErrorMessage = "Name must be longer")]
        [MaxLength(50, ErrorMessage = "Name must be shorter")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Everybody has a Surname")]
        [MinLength(2, ErrorMessage = "Surname must be longer")]
        [MaxLength(50, ErrorMessage = "Surname must be shorter")]
        public string LastName { get; set; }

        // Has one Avatar ---------------------------------->>
        public  Avatar.Avatar Avatar { get; set; }

        // Has one Class ----------------------------------->>

        public ICollection<Classroom> Classrooms { get; set; } 
    }
}
