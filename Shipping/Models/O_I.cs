using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shipping.Models
{
    public class O_I
    {
     

        public int O_ID { get; set; }
        public Order Order_Order{ get; set; }
        public int I_ID { get; set; }
        public Items Items_Items{ get; set; }
    }
}
