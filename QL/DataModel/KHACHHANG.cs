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
    
    public partial class KHACHHANG
    {
        public KHACHHANG()
        {
            this.CHITIETBAOCAOCONGNOes = new HashSet<CHITIETBAOCAOCONGNO>();
            this.PHIEUBANHANGs = new HashSet<PHIEUBANHANG>();
            this.PHIEUDICHVUs = new HashSet<PHIEUDICHVU>();
            this.PHIEUMUAHANGs = new HashSet<PHIEUMUAHANG>();
        }
    
        public int MaKhachHang { get; set; }
        public string TenKhachHang { get; set; }
        public int MaLoaiKhachHang { get; set; }
        public string DiaChi { get; set; }
        public Nullable<decimal> TienNoHienTai { get; set; }
    
        public virtual ICollection<CHITIETBAOCAOCONGNO> CHITIETBAOCAOCONGNOes { get; set; }
        public virtual LOAIKHACHHANG LOAIKHACHHANG { get; set; }
        public virtual ICollection<PHIEUBANHANG> PHIEUBANHANGs { get; set; }
        public virtual ICollection<PHIEUDICHVU> PHIEUDICHVUs { get; set; }
        public virtual ICollection<PHIEUMUAHANG> PHIEUMUAHANGs { get; set; }
    }
}