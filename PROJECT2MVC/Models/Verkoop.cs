//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PROJECT2MVC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Verkoop
    {
        public Verkoop()
        {
            this.VerkoopRegels = new HashSet<VerkoopRegel>();
        }
    
        public int VerkoopId { get; set; }
        public int Persoon_Id { get; set; }
        public System.DateTime Datum { get; set; }
        public int Bevestigd { get; set; }
        public int Betaald { get; set; }
    
        public virtual Persoon Persoon { get; set; }
        public virtual ICollection<VerkoopRegel> VerkoopRegels { get; set; }
    }
}
