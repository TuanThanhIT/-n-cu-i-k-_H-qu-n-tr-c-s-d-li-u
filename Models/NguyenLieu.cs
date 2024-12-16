﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCSDL.Models
{
    public class NguyenLieu
    {
        private string maNL;
        private string tenNL;
        private decimal gia;
        private int soLuong;
        private bool tamThoi;
        private int soLuongCB;

        public NguyenLieu(string maNL, string tenNL, int soLuong, bool tamThoi, int soLuongCB)
        {
            this.maNL = maNL;
            this.tenNL = tenNL;
            this.soLuong = soLuong;
            this.tamThoi = tamThoi;
            this.soLuongCB = soLuongCB;
        }
        public NguyenLieu(string tenNL, decimal gia, int soLuong)
        {
            this.tenNL = tenNL;
            this.gia = gia;
            this.soLuong = soLuong;
        }

        public NguyenLieu(string maNL, string tenNL, decimal gia, int soLuong)
        {
            this.maNL = maNL;
            this.tenNL = tenNL;
            this.gia = gia;
            this.soLuong = soLuong;
        }
        public NguyenLieu(string maNL, string tenNL, decimal gia, int soLuong, bool tamThoi, int soLuongCB)
        {
            this.maNL = maNL;
            this.tenNL = tenNL;
            this.gia = gia;
            this.soLuong = soLuong;
            this.TamThoi = tamThoi;
            this.SoLuongCB = soLuongCB;
        }
        public string MaNL { get => maNL; set => maNL = value; }
        public string TenNL { get => tenNL; set => tenNL = value; }
        public decimal Gia { get => gia; set => gia = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public bool TamThoi { get => tamThoi; set => tamThoi = value; }
        public int SoLuongCB { get => soLuongCB; set => soLuongCB = value; }
    }
}
