﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi_Entities.School
{

    public class Classroom
    {
        public int ClassroomId { get; set; }

        // The Class Image
        public string Image { get; set; }
  
        public string Name { get; set; }

        public string Description { get; set; }

        // Has many Students ------------------------------>>
        public ICollection<Student> Students { get; set; }

        // Has one Teacher ---------------------------------->>
        public Teacher Teacher { get; set; }

        // Has one School ---------------------------------->>
        public School School { get; set; }
    }
}
