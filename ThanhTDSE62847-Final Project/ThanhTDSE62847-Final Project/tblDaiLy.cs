//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ThanhTDSE62847_Final_Project
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblDaiLy
    {
        public tblDaiLy()
        {
            this.tblHoaDons = new HashSet<tblHoaDon>();
        }
    
        public string maDaiLy { get; set; }
        public string tenDaiLy { get; set; }
        public string tenChuDaiLy { get; set; }
        public string diaChi { get; set; }
        public string dienThoai { get; set; }
        public bool cungCap { get; set; }
    
        public virtual ICollection<tblHoaDon> tblHoaDons { get; set; }
    }
}
