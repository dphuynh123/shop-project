﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication13.Models
{
    public class GioHang
    {
        ApplicationDbContext db = new ApplicationDbContext();
        public int gSanPhamId { get; set; }
        public string gTenSP { get; set; }
        public int gSoLuong { get; set; }
        public int gDonGia { get; set; }
        public int gGiamGia { get; set; }
        public int MaNV { get; set; }
        public int gThanhTien
        {
            get { return gSoLuong * (gDonGia - gGiamGia); }
        }

        public GioHang(int SanPhamId)
        {
            MaNV = 0;
            gSanPhamId = SanPhamId;
            SanPham SP = db.SanPhams.Single(n => n.SanPhamId == gSanPhamId);
            gTenSP = SP.TenSP;
            gSoLuong = 1;
            gDonGia = SP.DonGia;
        }
    }
}
