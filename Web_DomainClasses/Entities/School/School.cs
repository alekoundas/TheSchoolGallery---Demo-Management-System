using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web_DomainClasses.Entities.School
{
    public class School
    {
        public int SchoolId { get; set; }

        [Required(ErrorMessage = "A School has a Name")]
        [MinLength(2, ErrorMessage = "Name must be longer")]
        [MaxLength(50, ErrorMessage = "Name must be shorter")]
        public string Name { get; set; }

        [Required(ErrorMessage = "A City has a Name")]
        [MinLength(5, ErrorMessage = "City Name must be longer")]
        [MaxLength(50, ErrorMessage = "City Name must be shorter")]
        public string City { get; set; }

        [Required(ErrorMessage = "You have to give an Address")]
        [MinLength(2, ErrorMessage = "Adress must be longer")]
        [MaxLength(50, ErrorMessage = "Adress must be shorter")]
        public string Adress { get; set; }

        [Display(Name = "Telephone")]
        public long Tel { get; set; }
        public string PlaceId { get; set; }

        // Has many Goals ---------------------------------->>
        //public virtual ICollection<Goal> Goals { get; set; }

        // Has many Classes -------------------------------->>
        public ICollection<Classroom> Classroom { get; set; }
    }
}
