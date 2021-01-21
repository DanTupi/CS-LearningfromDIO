using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IntroMvcWeb.Models
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int IdProduct { get; set; }

        [Display(Name = "Enter Product Code:")]
        [StringLength(20)]
        [Required(ErrorMessage = "{0} Is required.")]
        public string ProductCode { get; set; }

        [Display(Name = "Enter Product Type:")]
        [StringLength(40)]
        [Required(ErrorMessage = "{0} Is required.")]
        public string ProductType { get; set; }

        [Display(Name = "Enter Product Description:")]
        [StringLength(400)]
        public string Description { get; set; }

        [Display(Name = "Enter Product Price:")]
        [DisplayFormat(DataFormatString = "{0}:C")]
        [Required(ErrorMessage = "{0} Is required.")]
        public decimal UnitPrice { get; set; }

        [Display(Name = "Enter Quantity in Stock:")]
        [Required(ErrorMessage = "{0} Is required.")]
        public int QtyInStock { get; set; }

    }
}