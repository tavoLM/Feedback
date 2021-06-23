using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IQISService.Models
{
    public class FeedbackDto
    {

        public int CAR_TYPE { get; set; }
        public string BODY_NO { get; set; }
        public int PART { get; set; }
        public int DEFECT { get; set; }
        public int LOCATION { get; set; }
        public string ROUND { get; set; }
        public string RESPONSIBLE { get; set; }
        public string PROCESS { get; set; }
        public Nullable<System.DateTime> STDT { get; set; }
        public System.DateTime ENDT { get; set; }
        public Nullable<System.DateTime> RGDT { get; set; }
        public string COMMENT { get; set; }
        public string PICTURE { get; set; }
        public string PICTUREPATH { get; set; }
        public int Id { get; set; }
        public Nullable<int> RESPID { get; set; }
        public string USERID { get; set; }
        public Nullable<int> SCREENID { get; set; }
        public Nullable<int> AREA { get; set; }
        public Nullable<int> SHIFT { get; set; }
        public string SIDE { get; set; }
        public Nullable<int> IDCOORD { get; set; }
        public Nullable<int> IDCOLOR { get; set; }
        public Nullable<int> LINE { get; set; }
        public string imageString { get; set; }
    }
}