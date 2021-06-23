using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IQISService.Models
{
    public class CountermeasureDto
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
    }
}