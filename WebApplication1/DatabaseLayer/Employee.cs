//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1.DatabaseLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class Employee
    {
        public int Id { get; set; }
        public Nullable<int> DepartmentId { get; set; }
        public Nullable<int> UserId { get; set; }
        public Nullable<int> LevelId { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
    
        public virtual Department Department { get; set; }
        public virtual EmployeeLevel EmployeeLevel { get; set; }
        public virtual User User { get; set; }
    }
}
