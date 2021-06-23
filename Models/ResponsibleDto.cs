using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IQISService.Models
{
    public class ResponsibleDto
    {
        public int id { get; set; }
        public string name { get; set; }
        public string shop { get; set; }
        public string process { get; set; }
        public Nullable<bool> active { get; set; }
        public Nullable<int> responsibleGroup { get; set; }
    }
}