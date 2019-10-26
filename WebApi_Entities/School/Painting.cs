using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public  Student Student { get; set; }

        // Has A Price ------------------------------>>
        public  double Price { get; set; }

        // Has Many Awards ------------------------------>>
        //public  ICollection<Award> Awards { get; set; }
    }
}
