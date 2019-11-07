﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi_Entities.School
{
    public class School
    {
        public int SchoolId { get; set; }

        // The School Image
        public string Name { get; set; }

        public string City { get; set; }

        public string Adress { get; set; }

        public long Tel { get; set; }
        public string PlaceId { get; set; }

        // Has many Goals ---------------------------------->>
        //public virtual ICollection<Goal> Goals { get; set; }

        // Has many Classes -------------------------------->>
        public ICollection<Classroom> Classrooms { get; set; }
        //public object Teacher { get; set; }
        //public object Students { get; set; }
    }
}
