//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class tbl_subCourses
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_subCourses()
        {
            this.tbl_SubjectMaster = new HashSet<tbl_SubjectMaster>();
        }
    
        public int Id { get; set; }
        public Nullable<int> CourseId { get; set; }
        public string SubCourseName { get; set; }
        public string SubCourseDescription { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
    
        public virtual tbl_CourseManagment tbl_CourseManagment { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_SubjectMaster> tbl_SubjectMaster { get; set; }
    }
}
