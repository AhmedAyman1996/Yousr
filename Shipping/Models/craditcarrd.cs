using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Shipping.Models
{
    public class Craditcarrd
    {
        [Key]
        
        public int ID{get; set; }
        [StringLength(14, ErrorMessage = "limited")]
        public string C_name { get; set; }
        public string C_address { get; set; }
        public int C_Number { get; set; }
 [Required(ErrorMessage = "Vcs isRequired")]
        [Display(Name = "Vcs")]
        [StringLength(3, ErrorMessage = "limited")]
        public int Vcs { get; set; }
        [Required]
        [DisplayName("RegistrationDate")]
        [DataType(DataType.Time)]
        public String Expirydate { get; set; }
        public List<Customer> CustomersLIST { get; set; }
    }
}
