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
    
    public partial class Semester
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Semester()
        {
            this.RegisterStudyUnit = new HashSet<RegisterStudyUnit>();
            this.StudyFee = new HashSet<StudyFee>();
        }
    
        public string SemesterID { get; set; }
        public string SemesterName { get; set; }
        public Nullable<System.DateTime> StartDay { get; set; }
        public Nullable<System.DateTime> FinishDay { get; set; }
        public string Note { get; set; }
        public Nullable<System.DateTime> DateRegister { get; set; }
        public Nullable<bool> IsDateRegister { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RegisterStudyUnit> RegisterStudyUnit { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StudyFee> StudyFee { get; set; }
    }
}
