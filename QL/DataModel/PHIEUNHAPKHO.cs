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
    
    public partial class PHIEUNHAPKHO
    {
        public PHIEUNHAPKHO()
        {
            this.CHITIETPHIEUNHAPKHOes = new HashSet<CHITIETPHIEUNHAPKHO>();
        }
    
        public int MaPhieuNhapKho { get; set; }
        public System.DateTime NgayNhapKho { get; set; }
        public decimal TongTien { get; set; }
        public int MaNhanVien { get; set; }
    
        public virtual ICollection<CHITIETPHIEUNHAPKHO> CHITIETPHIEUNHAPKHOes { get; set; }
        public virtual TAIKHOAN TAIKHOAN { get; set; }
    }
}