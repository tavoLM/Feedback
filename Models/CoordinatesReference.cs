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
    
    public partial class CoordinatesReference
    {
        public int idCoordinate { get; set; }
        public int idArea { get; set; }
        public string Side { get; set; }
        public double xmin { get; set; }
        public double xmax { get; set; }
        public double ymin { get; set; }
        public double ymax { get; set; }
        public int idLocation { get; set; }
        public Nullable<int> position { get; set; }
        public Nullable<int> version { get; set; }
    
        public virtual area area { get; set; }
        public virtual location location { get; set; }
    }
}
