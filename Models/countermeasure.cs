//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IQISService.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class countermeasure
    {
        public int id { get; set; }
        public int model { get; set; }
        public int part { get; set; }
        public int defect { get; set; }
        public Nullable<int> location { get; set; }
        public Nullable<int> coordinate { get; set; }
        public int quantity { get; set; }
        public int responsible { get; set; }
        public string countermeasure1 { get; set; }
        public Nullable<System.DateTime> duedate { get; set; }
        public int status { get; set; }
        public System.DateTime regdt { get; set; }
        public string requestedby { get; set; }
        public byte[] cfile { get; set; }
        public Nullable<System.DateTime> approveddt { get; set; }
        public string approvedby { get; set; }
        public string process { get; set; }
        public string description { get; set; }
        public string bodyno { get; set; }
    
        public virtual defect defect1 { get; set; }
        public virtual location location1 { get; set; }
        public virtual model model1 { get; set; }
        public virtual part part1 { get; set; }
        public virtual responsible responsible1 { get; set; }
        public virtual user user { get; set; }
        public virtual user user1 { get; set; }
        public virtual WeldingCoordinate WeldingCoordinate { get; set; }
    }
}