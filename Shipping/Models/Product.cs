using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shipping.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string P_Name { get; set; }
        public int Quantity { get; set; }
        public string Model { get; set; }
        public List<Order> OrdersLIST { get; set; }

        
        
    }
}
