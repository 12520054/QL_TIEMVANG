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
    
    public partial class LOAITAIKHOAN
    {
        public LOAITAIKHOAN()
        {
            this.TAIKHOANs = new HashSet<TAIKHOAN>();
        }
    
        public int MaLoaiTaiKhoan { get; set; }
        public string TenLoaiTaiKhoan { get; set; }
    
        public virtual ICollection<TAIKHOAN> TAIKHOANs { get; set; }
    }
}
