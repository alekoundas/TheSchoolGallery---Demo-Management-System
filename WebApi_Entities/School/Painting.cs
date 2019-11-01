using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi_Entities.School
{
    public class Painting
    {
        public int PaintingId { get; set; }

        // The Painting Image
        public string ImageUrl { get; set; }
        public string PaintingTitle { get; set; }

        // Has One Student ------------------------------>>
        [ForeignKey("StudentFK")]
        public  Student Student { get; set; }
        public int StudentFK { get; set; }

        // Has A Price ------------------------------>>
        public  double Price { get; set; }

        // Has Many Awards ------------------------------>>
        //public  ICollection<Award> Awards { get; set; }
    }
}
