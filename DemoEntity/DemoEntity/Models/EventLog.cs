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
    
    public partial class EventLog
    {
        public int Id { get; set; }
        public string EventId { get; set; }
        public string EventErrorCode { get; set; }
        public string EventError { get; set; }
        public Nullable<System.DateTime> EventDateTime { get; set; }
    }
}
