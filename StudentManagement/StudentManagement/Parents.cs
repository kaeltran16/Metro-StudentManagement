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
    
    public partial class Parents
    {
        public string StudentID { get; set; }
        public string ParentName { get; set; }
        public string PhoneNumber { get; set; }
        public bool Gender { get; set; }
    
        public virtual Student Student { get; set; }
    }
}
