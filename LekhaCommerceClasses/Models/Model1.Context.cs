﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LekhaCommerceClasses.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class LekhaCommerceClassesEntities : DbContext
    {
        public LekhaCommerceClassesEntities()
            : base("name=LekhaCommerceClassesEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tbl_Admin> tbl_Admin { get; set; }
        public virtual DbSet<tbl_CourseManagment> tbl_CourseManagment { get; set; }
        public virtual DbSet<tbl_subCourses> tbl_subCourses { get; set; }
        public virtual DbSet<tbl_SubjectMaster> tbl_SubjectMaster { get; set; }
    }
}
