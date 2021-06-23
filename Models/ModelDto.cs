using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IQISService.Models
{
    public class ModelDto
    {

        public int id { get; set; }
        public string name { get; set; }
        public int active { get; set; }
        public string Description { get; set; }
        public string shop { get; set; }
        public string process { get; set; }
        public string code { get; set; }
    }
}