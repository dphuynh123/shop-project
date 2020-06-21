﻿
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication13.Models
{
    public class LoaiSP
    {
        public int LoaiSPId { get; set; }
        [Required]
        public string TenLoai { get; set; }

        public string ChuThich { get; set; }
        public Boolean Xoa { get; set; }

    }
}