using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web_DomainClasses.Entities.GoogleMaps
{
    public class MapMarker
    {
        public ICollection<string> Place_IDs { get; set; }
        public ICollection<string> Titles { get; set; }
    }
}
