//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace S1G1_PVFAPP.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrderedLine
    {
        public string OrderID { get; set; }
        public string ProductID { get; set; }
        public string OrderedQuantity { get; set; }
        public string OrderdedLineID { get; set; }
    
        public virtual ORDER ORDER { get; set; }
        public virtual PRODUCT PRODUCT { get; set; }
    }
}
