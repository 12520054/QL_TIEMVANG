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
    
    public partial class PHIEUDICHVU
    {
        public PHIEUDICHVU()
        {
            this.CHITIETPHIEUDICHVUs = new HashSet<CHITIETPHIEUDICHVU>();
        }
    
        public int MaPhieuDichVu { get; set; }
        public Nullable<int> MaDanhSachKhoanThu { get; set; }
        public Nullable<int> MaKhachHang { get; set; }
        public Nullable<System.DateTime> NgayDangKy { get; set; }
        public Nullable<System.DateTime> NgayGiao { get; set; }
        public Nullable<decimal> TongCong { get; set; }
    
        public virtual ICollection<CHITIETPHIEUDICHVU> CHITIETPHIEUDICHVUs { get; set; }
        public virtual DANHSACHKHOANTHU DANHSACHKHOANTHU { get; set; }
        public virtual KHACHHANG KHACHHANG { get; set; }
    }
}
