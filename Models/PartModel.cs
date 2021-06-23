using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IQISService.Models
{
    public class PartModel
    {

        public int id { get; set; }
        public string name { get; set; }
        public int seq { get; set; }
        public int active { get; set; }
        public Nullable<int> idArea { get; set; }
        public string shop { get; set; }
        public string process { get; set; }
        public Nullable<int> idOverflow { get; set; }

    }
}