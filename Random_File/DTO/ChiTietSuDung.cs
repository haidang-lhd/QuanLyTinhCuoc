//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Random_File.DTO
{
    using System;
    using System.Collections.Generic;
    
    public partial class ChiTietSuDung
    {
        public int ID { get; set; }
        public string IDSIM { get; set; }
        public Nullable<System.DateTime> TGBD { get; set; }
        public Nullable<System.DateTime> TGKT { get; set; }
        public Nullable<decimal> SoPhutSD7h23h { get; set; }
        public Nullable<decimal> SoPhutSD23h7h { get; set; }
    
        public virtual ThongTinSIM ThongTinSIM { get; set; }
    }
}