//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class CHITIETPHIEUMUAHANG
    {
        public int MaChiTietPhieuMuaHang { get; set; }
        public Nullable<int> MaPhieuMuaHang { get; set; }
        public Nullable<int> MaSanPham { get; set; }
        public Nullable<int> SoLuongMua { get; set; }
        public Nullable<decimal> DonGiaMua { get; set; }
        public Nullable<decimal> ThanhTien { get; set; }
    
        public virtual PHIEUMUAHANG PHIEUMUAHANG { get; set; }
        public virtual SANPHAM SANPHAM { get; set; }
    }
}