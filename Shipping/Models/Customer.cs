using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Shipping.Models
{
    public class Customer
    {
        [Key]

        public int Id { get; set; }
        [Required(ErrorMessage = "NameisRequired")]
        [Display(Name = "CustomerName")]

        public string Name { get; set; }
        [Required]
        [DisplayName("RegistrationDate")]
        [DataType(DataType.Date)]

        public DateTime Regist_Date { get; set; }
        [Required]
        [DisplayName("CustomerNumber")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal CustomerNumber { get; set; }

        public string Phone { get; set; }
        public string Address { get; set; }

        public string E_Mail { get; set; }

        public int C_ID{get; set; }
        public Craditcarrd Creditcard { get; set; }
    }
}
