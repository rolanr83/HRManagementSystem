//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HRManagementSystem
{
    using System;
    using System.Collections.Generic;
    
    public partial class Internal_Employment_History
    {
        public int InterEmpId { get; set; }
        public System.DateTime Date_Of_Employment { get; set; }
        public string Appointment_Authority { get; set; }
        public string Terms_Of_Appointment { get; set; }
        public Nullable<int> StaffId { get; set; }
        public Nullable<int> PositionId { get; set; }
        public Nullable<int> AppraisalId { get; set; }
    
        public virtual Appraisal Appraisal { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Position Position { get; set; }
    }
}
