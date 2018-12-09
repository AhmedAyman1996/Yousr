using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shipping.Models
{
    internal class KeyAttribute : Attribute
    {
       public int Id { get; set; }
        [Required(ErrorMessage = "NamisRequired")]
        [Display(Name = "CustomerName")]

        public string Name { get; set; }
        [Required]
        [DisplayName("RegistrationDate")]
        [DataType(DataType.Time)]

        public DateTime Regist_Date { get; set; }
        [Required]
        [DisplayName("CustomerNumber")]
        [Column(TypeName = "Decimal(1,2)")]
        public decimal CustomerNumber { get; set; }
    }
    }
