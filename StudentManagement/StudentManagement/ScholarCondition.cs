//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StudentManagement
{
    using System;
    using System.Collections.Generic;
    
    public partial class ScholarCondition
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ScholarCondition()
        {
            this.Scholarship = new HashSet<Scholarship>();
        }
    
        public string ConditionID { get; set; }
        public Nullable<double> BehaviorCondition { get; set; }
        public Nullable<double> MarkCondition { get; set; }
        public string Note { get; set; }
        public string PolicyID { get; set; }
    
        public virtual Policy Policy { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Scholarship> Scholarship { get; set; }
    }
}
