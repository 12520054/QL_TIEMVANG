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
    
    public partial class CHITIETPHIEUCHI
    {
        public int MaChiTietPhieuChi { get; set; }
        public int MaPhieuChi { get; set; }
        public int MaKhoanPhi { get; set; }
        public decimal ThanhTien { get; set; }
    
        public virtual KHOANPHI KHOANPHI { get; set; }
        public virtual PHIEUCHI PHIEUCHI { get; set; }
    }
}
