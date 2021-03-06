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
    
    public partial class PRODUCT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PRODUCT()
        {
            this.OrderedLines = new HashSet<OrderedLine>();
            this.USES = new HashSet<US>();
        }
    
        public string ProductID { get; set; }
        public string ProductDescription { get; set; }
        public string ProductFinish { get; set; }
        public string ProductStandardPrice { get; set; }
        public string ProductLineID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderedLine> OrderedLines { get; set; }
        public virtual PRODUCT_LINE PRODUCT_LINE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<US> USES { get; set; }
        public virtual WORKCENTER WORKCENTER { get; set; }
    }
}
