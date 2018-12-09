using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shipping.Models
{
    public class Order
    {
        

        [Required]

        public int ID { get; set; }
        [StringLength(14, ErrorMessage = "limited")]
        public string Quality { get; set; }
        public int Price { get; set; }
        public int Shippingcost { get; set; }
        
        public List<O_I> Itemslist{ get; set; }
    }
}
