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
    
    public partial class tblChatLieu
    {
        public tblChatLieu()
        {
            this.tblHangs = new HashSet<tblHang>();
        }
    
        public int maChatLieu { get; set; }
        public string MaChatLieu { get; set; }
        public string TenChatLieu { get; set; }
    
        public virtual ICollection<tblHang> tblHangs { get; set; }
    }
}
