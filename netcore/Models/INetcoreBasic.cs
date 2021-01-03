﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace netcore.Models
{
    public class INetcoreBasic
    {
        [Display(Name = "Thời gian tạo")]
        public DateTime createdAt { get; set; } = DateTime.UtcNow;
    }
}
