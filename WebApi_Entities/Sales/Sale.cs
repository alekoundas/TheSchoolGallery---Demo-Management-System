using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi_Entities.Sales
{
    public class Sale
    {
        public int SaleId { get; set; }
        public ICollection<PurchacedItem> purchacedItems { get; set; }
    }
}
