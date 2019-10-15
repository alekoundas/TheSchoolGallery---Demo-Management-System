using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi_Entities
{
    public class Painting
    {
        public int PaintingId { get; set; }

        // The Painting Image
        public string ImageUrl { get; set; }

        [Required(ErrorMessage = "You must name your Art.")]
        [MinLength(4, ErrorMessage = "Title must be longer")]
        [MaxLength(18, ErrorMessage = "Title must be shorter")]
        public string PaintingTitle { get; set; }

        // Has One Student ------------------------------>>
        public  Student Student { get; set; }

        // Has Many Prices ------------------------------>>
        //public  ICollection<Price> Prices { get; set; }

        // Has Many Awards ------------------------------>>
        //public  ICollection<Award> Awards { get; set; }
    }
}
