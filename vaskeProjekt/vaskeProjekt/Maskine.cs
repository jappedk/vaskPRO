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
    
    public partial class Maskine
    {
        public Maskine()
        {
            this.VaskePrograms = new HashSet<VaskeProgram>();
        }
    
        public int Id { get; set; }
        public string Maskintype { get; set; }
        public Nullable<int> Antal { get; set; }
        public Nullable<bool> Defect { get; set; }
        public Nullable<int> VaskeriId { get; set; }
    
        public virtual Vaskeri Vaskeri { get; set; }
        public virtual ICollection<VaskeProgram> VaskePrograms { get; set; }
    }
}