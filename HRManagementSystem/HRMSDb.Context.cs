﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class HRMSEntities2 : DbContext
    {
        public HRMSEntities2()
            : base("name=HRMSEntities2")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Appraisal> Appraisals { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Emergency> Emergencies { get; set; }
        public virtual DbSet<Employee_Previous_Jobs> Employee_Previous_Jobs { get; set; }
        public virtual DbSet<Internal_Employment_History> Internal_Employment_History { get; set; }
        public virtual DbSet<Leave_Type> Leave_Type { get; set; }
        public virtual DbSet<Position> Positions { get; set; }
        public virtual DbSet<Qualification> Qualifications { get; set; }
        public virtual DbSet<Relationsip> Relationsips { get; set; }
        public virtual DbSet<Staff_Education> Staff_Education { get; set; }
        public virtual DbSet<Staff_Leave> Staff_Leave { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserRole> UserRoles { get; set; }
        public virtual DbSet<EmploymentStatu> EmploymentStatus { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
    }
}
