using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web_DomainClasses.Entities.SignalR
{
   public class MessageHistory
    {
        public int MessageHistoryId { get; set; }
        public string Name { get; set; }
        public string Message { get; set; }
    }
}
