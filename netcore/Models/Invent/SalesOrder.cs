using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace netcore.Models.Invent
{
    public class SalesOrder : INetcoreMasterChild
    {
        public SalesOrder()
        {
            this.createdAt = DateTime.UtcNow;
            this.salesOrderNumber = DateTime.UtcNow.Date.ToString("yyyyMMdd") + Guid.NewGuid().ToString().Substring(0, 5).ToUpper() + "#SO";
            this.soDate = DateTime.UtcNow.Date;
            this.deliveryDate = this.soDate.AddDays(5);
            this.salesOrderStatus = SalesOrderStatus.Draft;
            this.totalDiscountAmount = 0m;
            this.totalOrderAmount = 0m;
        }

        [StringLength(38)]
        [Display(Name = "Sales Order Id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string salesOrderId { get; set; }

        [StringLength(20)]
        [Required]
        [Display(Name = "Sales Order Number")]
        public string salesOrderNumber { get; set; }

        [Display(Name = "Terms of payment")]
        public TOP top { get; set; }

        [Display(Name = "Date SO")]
        public DateTime soDate { get; set; }

        [Display(Name = "Delivery date")]
        public DateTime deliveryDate { get; set; }

        [StringLength(50)]
        [Display(Name = "Delivery place address")]
        public string deliveryAddress { get; set; }

        [StringLength(30)]
        [Display(Name = "Number of reference documents (Internal)")]
        public string referenceNumberInternal { get; set; }

        [StringLength(30)]
        [Display(Name = "Number of reference documents (Customers)")]
        public string referenceNumberExternal { get; set; }

        [StringLength(100)]
        [Display(Name = "Description information")]
        public string description { get; set; }

        [StringLength(38)]
        [Required]
        [Display(Name = "Unit company Id")]
        public string branchId { get; set; }

        [Display(Name = "Company unit")]
        public Branch branch { get; set; }

        [StringLength(38)]
        [Required]
        [Display(Name = "Client Id")]
        public string customerId { get; set; }

        [Display(Name = "Customer")]
        public Customer customer { get; set; }

        [StringLength(30)]
        [Required]
        [Display(Name = "The person who makes the request for shipment (internal)")]
        public string picInternal { get; set; }

        [StringLength(30)]
        [Required]
        [Display(Name = "Consignee (Customer)")]
        public string picCustomer { get; set; }

        [Display(Name = "SO state")]
        public SalesOrderStatus salesOrderStatus { get; set; }

        [Display(Name = "Total Discount")]
        public decimal totalDiscountAmount { get; set; }

        [Display(Name = "Total order amount")]
        public decimal totalOrderAmount { get; set; }

        [Display(Name = "Export shipment number")]
        public string salesShipmentNumber { get; set; }

        [Display(Name = "Sales Order Lines")]
        public List<SalesOrderLine> salesOrderLine { get; set; } = new List<SalesOrderLine>();
    }
}
