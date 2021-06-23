using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IQISService.Models
{
    public class Mail
    {

        public string from { get; set; }
        public string from_name { get; set; }
        public string to_email { get; set; }
        public string subject { get; set; }
        public string message { get; set; }
        public Format format { get; set; }
    }

    public class Format
    {
        public string body_intro { get; set; }
        public string body_header { get; set; }
        public string body_message { get; set; }
        public string system_nm { get; set; }
        public string footer_nms { get; set; }
        public string footer_emails { get; set; }
    }
}