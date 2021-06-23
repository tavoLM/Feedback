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
    
    public partial class FEEDBACK_DATA
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
        public System.DateTime RGDT { get; set; }
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
    
        public virtual area area1 { get; set; }
        public virtual ColorCode ColorCode { get; set; }
        public virtual defect defect1 { get; set; }
        public virtual model model { get; set; }
        public virtual location location1 { get; set; }
        public virtual part part1 { get; set; }
        public virtual responsible responsible1 { get; set; }
        public virtual screen screen { get; set; }
        public virtual user user { get; set; }
        public virtual WeldingCoordinate WeldingCoordinate { get; set; }
    }
}