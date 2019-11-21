using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web_DomainClasses.Entities.Sales
{
    public class PurchacedItem
    {
        public int PurchacedItemId { get; set; }
        public int PurchasedPaintingId { get; set; }
        public int Quantity { get; set; } = 1;


    }
}
