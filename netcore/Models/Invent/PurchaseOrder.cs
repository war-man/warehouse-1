﻿using System;
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
        [Display(Name = "Số PO")]
        public string purchaseOrderNumber { get; set; }
        
        [Display(Name = "Điều khoản thanh toán")]
        public TOP top { get; set; }

        [Display(Name = "Ngày PO")]
        public DateTime poDate { get; set; }

        [Display(Name = "Ngày giao hàng")]
        public DateTime deliveryDate { get; set; }

        [StringLength(50)]
        [Display(Name = "Địa chỉ giao hàng")]
        public string deliveryAddress { get; set; }

        [StringLength(30)]
        [Display(Name = "Số chứng từ tham chiếu (Nội bộ)")]
        public string referenceNumberInternal { get; set; }

        [StringLength(30)]
        [Display(Name = "Số chứng từ tham chiếu (Nhà cung cấp)")]
        public string referenceNumberExternal { get; set; }

        [StringLength(100)]
        [Display(Name = "Thông tin mô tả")]
        public string description { get; set; }

        [StringLength(38)]
        [Required]
        [Display(Name = "Đơn vị Công ty Id")]
        public string branchId { get; set; }

        [Display(Name = "Đơn vị Công ty")]
        public Branch branch { get; set; }

        [StringLength(38)]
        [Required]
        [Display(Name = "Nhà cung cấp Id")]
        public string vendorId { get; set; }

        [Display(Name = "Nhà cung cấp")]
        public Vendor vendor { get; set; }

        [StringLength(30)]
        [Required]
        [Display(Name = "Người lập đề nghị nhập hàng (Nội bộ)")]
        public string picInternal { get; set; }

        [StringLength(30)]
        [Required]
        [Display(Name = "Người giao hàng (Nhà cung cấp)")]
        public string picVendor { get; set; }

        [Display(Name = "Trạng thái PO")]
        public PurchaseOrderStatus purchaseOrderStatus { get; set; }

        [Display(Name = "Tổng tiền giảm giá")]
        public decimal totalDiscountAmount { get; set; }

        [Display(Name = "Tổng tiền đơn hàng")]
        public decimal totalOrderAmount { get; set; }

        [Display(Name = "Số lô hàng nhập")]
        public string purchaseReceiveNumber { get; set; }

        [Display(Name = "Purchase Order Lines")]
        public List<PurchaseOrderLine> purchaseOrderLine { get; set; } = new List<PurchaseOrderLine>();
    }
}
