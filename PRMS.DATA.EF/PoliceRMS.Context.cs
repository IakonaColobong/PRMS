﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PRMS.DATA.EF
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PoliceRMSEntities : DbContext
    {
        public PoliceRMSEntities()
            : base("name=PoliceRMSEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Ammunition> Ammunitions { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Firearm> Firearms { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Training> Trainings { get; set; }
        public virtual DbSet<Vehicle> Vehicles { get; set; }
    }
}
