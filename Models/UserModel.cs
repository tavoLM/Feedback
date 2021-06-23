using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IQISService.Models
{
    public class UserModel
    {

        public string id { get; set; }
        public string password { get; set; }
        public string user_name { get; set; }
        public string role { get; set; }
        public bool isAdmin { get; set; }
        public Nullable<bool> active { get; set; }
        public string department { get; set; }
        public string email { get; set; }
        public bool isPic { get; set; }
    }
}