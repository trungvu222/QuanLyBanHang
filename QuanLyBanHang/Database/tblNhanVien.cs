//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class tblNhanVien
    {
        public tblNhanVien()
        {
            this.tblHDBans = new HashSet<tblHDBan>();
        }
    
        public string MaNhanVien { get; set; }
        public string TenNhanVien { get; set; }
        public string GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }
        public Nullable<System.DateTime> NgaySinh { get; set; }
    
        public virtual ICollection<tblHDBan> tblHDBans { get; set; }
    }
}
