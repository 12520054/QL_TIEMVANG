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
    
    public partial class BAOCAODOANHTHU
    {
        public int MaBaoCaoDoanhThu { get; set; }
        public Nullable<System.DateTime> NgayBaocao { get; set; }
        public Nullable<int> MaDanhSachKhoanThu { get; set; }
        public Nullable<int> MaDanhSachKhoanChi { get; set; }
        public Nullable<int> TonQuyBanDau { get; set; }
        public Nullable<int> TonQuyConLai { get; set; }
    
        public virtual DANHSACHKHOANCHI DANHSACHKHOANCHI { get; set; }
        public virtual DANHSACHKHOANTHU DANHSACHKHOANTHU { get; set; }
    }
}
