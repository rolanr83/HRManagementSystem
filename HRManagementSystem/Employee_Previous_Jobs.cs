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
    
    public partial class Employee_Previous_Jobs
    {
        public int PreviousEmpId { get; set; }
        public System.DateTime Start_Year { get; set; }
        public System.DateTime End_Year { get; set; }
        public string Job_Title { get; set; }
        public string Organization { get; set; }
        public string Responsibilities { get; set; }
        public Nullable<int> StaffId { get; set; }
    
        public virtual Employee Employee { get; set; }
    }
}
