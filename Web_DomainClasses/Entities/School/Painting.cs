using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web_DomainClasses.Entities.School
{
    public class Painting
    {
        public int PaintingId { get; set; }

        // The Painting Image
        public string ImageUrl { get; set; }
        [Required(ErrorMessage = "You must name your Art.")]
        [MinLength(4, ErrorMessage = "Title must be longer")]
        [MaxLength(50, ErrorMessage = "Title must be shorter")]
        public string PaintingTitle { get; set; }

        // Has One Student ------------------------------>>
        [ForeignKey("StudentFK")]
        public Student Student { get; set; }
        public int StudentFK { get; set; }

        // Has A Price ------------------------------>>
        public double Price { get; set; }

        // Holds A Value For Curtain Occasions--------------->>
        public int Quantity { get; set; } = 0;
    }
}
