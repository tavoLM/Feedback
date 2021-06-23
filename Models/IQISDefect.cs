using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IQISService.Models
{
    public class IQISDefect
    {
        public string plnt { get; set; }
        public string shop { get; set; }
        public string line { get; set; }
        public string mnpr { get; set; }
        public string sbpr { get; set; }
        public string bodyNo { get; set; }
        public string part { get; set; }
        public string defc { get; set; }
        public string loct { get; set; }
        public string spt1 { get; set; }
        public string spt2 { get; set; }
        public int rptn { get; set; }

        public string partName { get; set; }
        public string defectName { get; set; }
        public string imageName { get; set; }
        public string imageString { get; set; }
        public string userId { get; set; }
        public int responsible { get; set; }
        public String description { get; set; }
    }
}