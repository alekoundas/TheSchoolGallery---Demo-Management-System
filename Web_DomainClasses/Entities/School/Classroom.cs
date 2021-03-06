﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web_DomainClasses.Entities.School
{

    public class Classroom
    {
        public int ClassroomId { get; set; }

        // The Class Image
        public string Image { get; set; }

        [Required(ErrorMessage = "A Class has a Name")]
        [MinLength(2, ErrorMessage = "Name must be longer")]
        [MaxLength(50, ErrorMessage = "Name must be shorter")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Describe the Class")]
        [MinLength(5, ErrorMessage = "You have to say more.")]
        [MaxLength(50, ErrorMessage = "You have said too much.")]
        public string Description { get; set; }

        // Has many Students ------------------------------>>
        public ICollection<Student> Students { get; set; }

        // Has one Teacher ---------------------------------->>
        [ForeignKey("TeacherFK")]
        public Teacher Teacher { get; set; }
        public int TeacherFK { get; set; }

        // Has one School ---------------------------------->>
        [ForeignKey("SchoolFK")]
        public School School { get; set; }
        public int SchoolFK { get; set; }
    }
}
