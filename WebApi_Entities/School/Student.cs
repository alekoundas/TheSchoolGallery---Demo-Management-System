using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;



namespace WebApi_Entities.School
{
   public  class Student
    {
        public int StudentId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }


        public int Age { get; set; }

        // Has many Paintings ------------------------------>>
        public  ICollection<Painting> Paintings { get; set; }

        // Has one Avatar ---------------------------------->>
        public  Avatar.Avatar Avatar { get; set; }

        // Has one Class ----------------------------------->>
        [ForeignKey("ClassroomFK")]
        public Classroom Classroom { get; set; }

        public int ClassroomFK { get; set; }
    }
}
