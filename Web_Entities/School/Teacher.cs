using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web_Entities
{
   public  class Teacher
    {

        public int TeacherId { get; set; }

        [Required(ErrorMessage = "Everybody has a Name")]
        [MinLength(2, ErrorMessage = "Name must be longer")]
        [MaxLength(12, ErrorMessage = "Name must be shorter")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Everybody has a Surname")]
        [MinLength(2, ErrorMessage = "Surname must be longer")]
        [MaxLength(12, ErrorMessage = "Surname must be shorter")]
        public string LastName { get; set; }

        // Has one Avatar ---------------------------------->>
        public  Avatar.Avatar Avatar { get; set; }

        // Has one Class ----------------------------------->>

        public ICollection<Classroom> Classroom { get; set; } 
    }
}
