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
    
    public partial class Kullanici_Roller
    {
        public int id { get; set; }
        public int Kullanici_ref { get; set; }
        public int Rol_ref { get; set; }
        public Nullable<int> active { get; set; }
    
        public virtual Kullanici Kullanici { get; set; }
        public virtual Rol Rol { get; set; }
    }
}