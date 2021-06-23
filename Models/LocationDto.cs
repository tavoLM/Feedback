using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IQISService.Models
{
    public class LocationDto
    {
        public int id { get; set; }
        public string name { get; set; }
        public int seq { get; set; }
        public Nullable<int> partId { get; set; }
        public int active { get; set; }
        public string shop { get; set; }
        public string process { get; set; }
    }
}