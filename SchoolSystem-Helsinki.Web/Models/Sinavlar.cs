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
    
    public partial class Sinavlar
    {
        public int id { get; set; }
        public int ref_ders { get; set; }
        public int ref_personel { get; set; }
        public string durum { get; set; }
        public int puan { get; set; }
        public Nullable<int> active { get; set; }
    
        public virtual Der Der { get; set; }
        public virtual Personel Personel { get; set; }
    }
}