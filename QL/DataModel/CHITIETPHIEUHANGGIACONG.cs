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
    
    public partial class CHITIETPHIEUHANGGIACONG
    {
        public int MaChiTietPhieuHangGiaCong { get; set; }
        public Nullable<int> MaPhieuHangGiaCong { get; set; }
        public Nullable<int> MaHangGiaCong { get; set; }
        public Nullable<int> SoLuong { get; set; }
        public Nullable<decimal> ThanhTien { get; set; }
    
        public virtual HANGGIACONG HANGGIACONG { get; set; }
        public virtual PHIEUHANGGIACONG PHIEUHANGGIACONG { get; set; }
    }
}
