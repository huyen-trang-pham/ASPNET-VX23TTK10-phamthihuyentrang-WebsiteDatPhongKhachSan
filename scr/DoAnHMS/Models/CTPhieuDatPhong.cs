//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DoAnHMS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CTPhieuDatPhong
    {
        public string maPDP { get; set; }
        public string maP { get; set; }
        public decimal tienCoc { get; set; }
    
        public virtual Phong Phong { get; set; }
        public virtual PhieuDatPhong PhieuDatPhong { get; set; }
    }
}
