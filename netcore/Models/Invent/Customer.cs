using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace netcore.Models.Invent
{
    public class Customer : INetcoreMasterChild, IBaseAddress
    {
        public Customer()
        {
            this.createdAt = DateTime.UtcNow;
        }

        [StringLength(38)]
        [Display(Name = "Customer Id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string customerId { get; set; }

        [StringLength(50)]
        [Display(Name = "Customer Name")]
        [Required]
        public string customerName { get; set; }

        [StringLength(50)]
        [Display(Name = "Customer information")]
        public string description { get; set; }

        [Display(Name = "Business scale")]
        public BusinessSize size { get; set; }

        //IBaseAddress
        [Display(Name = "Stree1")]
        [Required]
        [StringLength(50)]
        public string street1 { get; set; }

        [Display(Name = "Address2")]
        [StringLength(50)]
        public string street2 { get; set; }

        [Display(Name = "City")]
        [StringLength(30)]
        public string city { get; set; }

        [Display(Name = "State")]
        [StringLength(30)]
        public string province { get; set; }

        [Display(Name = "Country")]
        [StringLength(30)]
        public string country { get; set; }
        //IBaseAddress

        [Display(Name = "Customer Contacts")]
        public List<CustomerLine> customerLine { get; set; } = new List<CustomerLine>();
    }
}
