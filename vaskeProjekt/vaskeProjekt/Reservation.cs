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
    
    public partial class Reservation
    {
        public int Id { get; set; }
        public Nullable<System.DateTime> ReservationDato { get; set; }
        public Nullable<int> BrugerId { get; set; }
        public Nullable<int> VaskeTidId { get; set; }
    
        public virtual Bruger Bruger { get; set; }
        public virtual VaskeTid VaskeTid { get; set; }
    }
}