using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shipping.Models
{
    public class Items
    {
        

        public String Name { get; set; }
        public int Price { get; set; }
        public int ID { get; set; }
        public int Quantity { get; set; }
        public int Produces_ID { get; set; }
        public Product Produces_Pro { get; set; }
        public List<O_I> Orderlist { get; set; }
    }


    }

