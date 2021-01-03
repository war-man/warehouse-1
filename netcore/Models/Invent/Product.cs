using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace netcore.Models.Invent
{
    public class Product: INetcoreBasic
    {
        public Product()
        {
            this.createdAt = DateTime.UtcNow;
        }

        [StringLength(38)]
        [Display(Name = "Product Id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string productId { get; set; }

        [StringLength(50)]
        [Display(Name = "Product Code")]
        [Required]
        public string productCode { get; set; }

        [StringLength(50)]
        [Display(Name = "Product Name")]
        [Required]
        public string productName { get; set; }

        [StringLength(50)]
        [Display(Name = "Product Description")]
        public string description { get; set; }

        [StringLength(50)]
        [Display(Name = "Barcode")]
        public string barcode { get; set; }

        [StringLength(50)]
        [Display(Name = "Serial Number")]
        public string serialNumber { get; set; }

        
        [Display(Name = "Product Type")]
        public ProductType productType { get; set; }

       
        [Display(Name = "Unit")]
        public UOM uom { get; set; }
    }
}
