using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi_Entities.Avatar;

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
        public  Classroom Classroom { get; set; }
    }
}
