//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SchoolSystem_Helsinki.Web.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Oda_Personel
    {
        public int id { get; set; }
        public int ref_OdaId { get; set; }
        public int ref_PersonelId { get; set; }
        public Nullable<int> active { get; set; }
    
        public virtual Oda Oda { get; set; }
        public virtual Personel Personel { get; set; }
    }
}
