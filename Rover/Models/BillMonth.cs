//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Rover.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class BillMonth
    {
        public BillMonth()
        {
            this.Bills = new HashSet<Bill>();
            this.Readings = new HashSet<Reading>();
        }
    
        public int BillMonthID { get; set; }
        public Nullable<System.DateTime> BillMonthDate { get; set; }
        public string BillMonthDesc { get; set; }
        public Nullable<bool> IsActiveBillMonth { get; set; }
    
        public virtual ICollection<Bill> Bills { get; set; }
        public virtual ICollection<Reading> Readings { get; set; }
    }
}