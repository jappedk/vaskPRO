//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace vaskeProjekt
{
    using System;
    using System.Collections.Generic;
    
    public partial class Vaskeri
    {
        public Vaskeri()
        {
            this.Brugers = new HashSet<Bruger>();
            this.Maskines = new HashSet<Maskine>();
            this.VaskeTids = new HashSet<VaskeTid>();
        }
    
        public int Id { get; set; }
        public string Navn { get; set; }
    
        public virtual ICollection<Bruger> Brugers { get; set; }
        public virtual ICollection<Maskine> Maskines { get; set; }
        public virtual ICollection<VaskeTid> VaskeTids { get; set; }
        public override string ToString()
        {
            return "ID: " + Id + "Navn: " + Navn;
        }
    }
    
}
