﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyBanHang.Database
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class QLBanHangEntities : DbContext
    {
        public QLBanHangEntities()
            : base("name=QLBanHangEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<tblChatLieu> tblChatLieux { get; set; }
        public DbSet<tblChiTietHDBan> tblChiTietHDBans { get; set; }
        public DbSet<tblHang> tblHangs { get; set; }
        public DbSet<tblHDBan> tblHDBans { get; set; }
        public DbSet<tblKhachHang> tblKhachHangs { get; set; }
        public DbSet<tblNhanVien> tblNhanViens { get; set; }
    }
}
