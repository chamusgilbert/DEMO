//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DemoEntity.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Shift
    {
        public int Id { get; set; }
        public string ShiftId { get; set; }
        public string ShiftDay { get; set; }
        public Nullable<System.DateTime> ShiftStart { get; set; }
        public Nullable<System.DateTime> ShiftEnd { get; set; }
        public string Description { get; set; }
        public Nullable<bool> Active { get; set; }
        public Nullable<System.DateTime> EntDate { get; set; }
    }
}
