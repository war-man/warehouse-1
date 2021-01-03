using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace netcore.Models.Invent
{
    public class PurchaseOrder : INetcoreMasterChild
    {
        public PurchaseOrder()
        {
            this.createdAt = DateTime.UtcNow;
            this.purchaseOrderNumber = DateTime.UtcNow.Date.ToString("yyyyMMdd") + Guid.NewGuid().ToString().Substring(0, 5).ToUpper() + "#PO";
            this.poDate = DateTime.UtcNow.Date;
            this.deliveryDate = this.poDate.AddDays(5);
            this.purchaseOrderStatus = PurchaseOrderStatus.Draft;
            this.totalDiscountAmount = 0m;
            this.totalOrderAmount = 0m;
        }

        [StringLength(38)]
        [Display(Name = "Purchase Order Id")]
        public string purchaseOrderId { get; set; }

        [StringLength(20)]
        [Required]
        [Display(Name = "Purchage Order Number")]
        public string purchaseOrderNumber { get; set; }
        
        [Display(Name = "Terms of payment")]
        public TOP top { get; set; }

        [Display(Name = "PO Date")]
        public DateTime poDate { get; set; }

        [Display(Name = "Delivery date")]
        public DateTime deliveryDate { get; set; }

        [StringLength(50)]
        [Display(Name = "Delivery address")]
        public string deliveryAddress { get; set; }

        [StringLength(30)]
        [Display(Name = "Number of reference documents (Internal)")]
        public string referenceNumberInternal { get; set; }

        [StringLength(30)]
        [Display(Name = "Number of reference documents (Supplier)")]
        public string referenceNumberExternal { get; set; }

        [StringLength(100)]
        [Display(Name = "Description")]
        public string description { get; set; }

        [StringLength(38)]
        [Required]
        [Display(Name = "Unit Company Id")]
        public string branchId { get; set; }

        [Display(Name = "Company unit")]
        public Branch branch { get; set; }

        [StringLength(38)]
        [Required]
        [Display(Name = "Provider Id")]
        public string vendorId { get; set; }

        [Display(Name = "Supplier")]
        public Vendor vendor { get; set; }

        [StringLength(30)]
        [Required]
        [Display(Name = "The applicant for importing goods(Internal)")]
        public string picInternal { get; set; }

        [StringLength(30)]
        [Required]
        [Display(Name = "Người giao hàng (Nhà cung cấp)")]
        public string picVendor { get; set; }

        [Display(Name = "Purchage Order Status")]
        public PurchaseOrderStatus purchaseOrderStatus { get; set; }

        [Display(Name = "Total Discount")]
        public decimal totalDiscountAmount { get; set; }

        [Display(Name = "Total Order Amount")]
        public decimal totalOrderAmount { get; set; }

        [Display(Name = "Purchage Recive Number")]
        public string purchaseReceiveNumber { get; set; }

        [Display(Name = "Purchase Order Lines")]
        public List<PurchaseOrderLine> purchaseOrderLine { get; set; } = new List<PurchaseOrderLine>();
    }
}
