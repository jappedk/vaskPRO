//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VaskeWEB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Betaling
    {
        public Betaling()
        {
            this.VaskePrograms = new HashSet<VaskeProgram>();
        }
    
        public int Id { get; set; }
        public Nullable<int> Pris { get; set; }
        public Nullable<System.DateTime> Fakturadato { get; set; }
        public string BrugerId { get; set; }
    
        public virtual Bruger Bruger { get; set; }
        public virtual ICollection<VaskeProgram> VaskePrograms { get; set; }
    }
}
