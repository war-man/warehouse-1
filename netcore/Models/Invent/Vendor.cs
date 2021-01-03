﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace netcore.Models.Invent
{
    public class Vendor : INetcoreMasterChild, IBaseAddress
    {
        public Vendor()
        {
            this.createdAt = DateTime.UtcNow;
        }

        [StringLength(38)]
        [Display(Name = "Nhà cung cấp Id")]
        public string vendorId { get; set; }

        [StringLength(50)]
        [Display(Name = "Tên nhà cung cấp")]
        [Required]
        public string vendorName { get; set; }

        [StringLength(50)]
        [Display(Name = "Thông tin nhà cung cấp")]
        public string description { get; set; }
        
        [Display(Name = "Quy mô kinh doanh")]
        public BusinessSize size { get; set; }

        //IBaseAddress
        [Display(Name = "Địa chỉ 1")]
        [Required]
        [StringLength(50)]
        public string street1 { get; set; }

        [Display(Name = "Địa chỉ 2")]
        [StringLength(50)]
        public string street2 { get; set; }

        [Display(Name = "Thành phố")]
        [StringLength(30)]
        public string city { get; set; }

        [Display(Name = "Tỉnh thành")]
        [StringLength(30)]
        public string province { get; set; }

        [Display(Name = "Quốc gia")]
        [StringLength(30)]
        public string country { get; set; }
        //IBaseAddress

        [Display(Name = "Vendor Contacts")]
        public List<VendorLine> vendorLine { get; set; } = new List<VendorLine>();
    }
}
