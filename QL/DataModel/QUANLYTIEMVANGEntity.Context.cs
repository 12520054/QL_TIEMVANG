﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class QUANLYTIEMVANGEntities : DbContext
    {
        public QUANLYTIEMVANGEntities()
            : base("name=QUANLYTIEMVANGEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<BAOCAOCONGNO> BAOCAOCONGNOes { get; set; }
        public DbSet<BAOCAODOANHTHU> BAOCAODOANHTHUs { get; set; }
        public DbSet<BAOCAOTON> BAOCAOTONs { get; set; }
        public DbSet<CHITIETBAOCAOCONGNO> CHITIETBAOCAOCONGNOes { get; set; }
        public DbSet<CHITIETBAOCAOTON> CHITIETBAOCAOTONs { get; set; }
        public DbSet<CHITIETPHIEUBANHANG> CHITIETPHIEUBANHANGs { get; set; }
        public DbSet<CHITIETPHIEUCHI> CHITIETPHIEUCHIs { get; set; }
        public DbSet<CHITIETPHIEUDICHVU> CHITIETPHIEUDICHVUs { get; set; }
        public DbSet<CHITIETPHIEUHANGGIACONG> CHITIETPHIEUHANGGIACONGs { get; set; }
        public DbSet<CHITIETPHIEUMUAHANG> CHITIETPHIEUMUAHANGs { get; set; }
        public DbSet<CHITIETPHIEUNHAPKHO> CHITIETPHIEUNHAPKHOes { get; set; }
        public DbSet<DANHSACHKHOANCHI> DANHSACHKHOANCHIs { get; set; }
        public DbSet<DANHSACHKHOANTHU> DANHSACHKHOANTHUs { get; set; }
        public DbSet<DICHVU> DICHVUs { get; set; }
        public DbSet<HANGGIACONG> HANGGIACONGs { get; set; }
        public DbSet<KHACHHANG> KHACHHANGs { get; set; }
        public DbSet<KHOANPHI> KHOANPHIs { get; set; }
        public DbSet<LOAIKHACHHANG> LOAIKHACHHANGs { get; set; }
        public DbSet<LOAISANPHAM> LOAISANPHAMs { get; set; }
        public DbSet<LOAITAIKHOAN> LOAITAIKHOANs { get; set; }
        public DbSet<PHIEUBANHANG> PHIEUBANHANGs { get; set; }
        public DbSet<PHIEUCHI> PHIEUCHIs { get; set; }
        public DbSet<PHIEUDICHVU> PHIEUDICHVUs { get; set; }
        public DbSet<PHIEUHANGGIACONG> PHIEUHANGGIACONGs { get; set; }
        public DbSet<PHIEUMUAHANG> PHIEUMUAHANGs { get; set; }
        public DbSet<PHIEUNHAPKHO> PHIEUNHAPKHOes { get; set; }
        public DbSet<PHIEUNO> PHIEUNOes { get; set; }
        public DbSet<QUIDINH> QUIDINHs { get; set; }
        public DbSet<SANPHAM> SANPHAMs { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<TAIKHOAN> TAIKHOANs { get; set; }
        public DbSet<THOGIACONG> THOGIACONGs { get; set; }
    }
}