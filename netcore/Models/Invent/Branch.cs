using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace netcore.Models.Invent
{
    public class Branch: INetcoreBasic, IBaseAddress
    {
        public Branch()
        {
            this.createdAt = DateTime.UtcNow;
            this.isDefaultBranch = false;
        }

        [StringLength(38)]
        [Display(Name = "Company Id")]
        public string branchId { get; set; }

        [StringLength(50)]
        [Display(Name = "Company Name")]
        [Required]
        public string branchName { get; set; }

        [StringLength(50)]
        [Display(Name = "Company information")]
        public string description { get; set; }

        [Display(Name = "Choose company as headquarters?")]
        public bool isDefaultBranch { get; set; } = false;

        //IBaseAddress
        [Display(Name = "Address 1")]
        [Required]
        [StringLength(50)]
        public string street1 { get; set; }

        [Display(Name = "Street2")]
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
    }
}
