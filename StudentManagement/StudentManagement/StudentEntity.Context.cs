﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class StudentDBEntities : DbContext
    {
        public StudentDBEntities()
            : base("name=StudentDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AcademicMark> AcademicMark { get; set; }
        public virtual DbSet<ActivityGroup> ActivityGroup { get; set; }
        public virtual DbSet<Anouncement> Anouncement { get; set; }
        public virtual DbSet<BehaviorMark> BehaviorMark { get; set; }
        public virtual DbSet<Candre> Candre { get; set; }
        public virtual DbSet<Class> Class { get; set; }
        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<DiplomaProject> DiplomaProject { get; set; }
        public virtual DbSet<Discipline> Discipline { get; set; }
        public virtual DbSet<Exam> Exam { get; set; }
        public virtual DbSet<Faculty> Faculty { get; set; }
        public virtual DbSet<Parents> Parents { get; set; }
        public virtual DbSet<PlusFee> PlusFee { get; set; }
        public virtual DbSet<Policy> Policy { get; set; }
        public virtual DbSet<RegisterStudyUnit> RegisterStudyUnit { get; set; }
        public virtual DbSet<ScholarCondition> ScholarCondition { get; set; }
        public virtual DbSet<Scholarship> Scholarship { get; set; }
        public virtual DbSet<School> School { get; set; }
        public virtual DbSet<Semester> Semester { get; set; }
        public virtual DbSet<Student> Student { get; set; }
        public virtual DbSet<StudentUser> StudentUser { get; set; }
        public virtual DbSet<StudyFee> StudyFee { get; set; }
        public virtual DbSet<Teacher> Teacher { get; set; }
        public virtual DbSet<TeacherUser> TeacherUser { get; set; }
        public virtual DbSet<Users> Users { get; set; }
    
        public virtual ObjectResult<GetUser_Result> GetUser(string iD, string passWord)
        {
            var iDParameter = iD != null ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(string));
    
            var passWordParameter = passWord != null ?
                new ObjectParameter("PassWord", passWord) :
                new ObjectParameter("PassWord", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetUser_Result>("GetUser", iDParameter, passWordParameter);
        }
    
        public virtual ObjectResult<GetAcademicByID_Result> GetAcademicByID(string studentID)
        {
            var studentIDParameter = studentID != null ?
                new ObjectParameter("StudentID", studentID) :
                new ObjectParameter("StudentID", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetAcademicByID_Result>("GetAcademicByID", studentIDParameter);
        }
    
        public virtual ObjectResult<GetDetailDisciplineByID_Result> GetDetailDisciplineByID(string disciplineID)
        {
            var disciplineIDParameter = disciplineID != null ?
                new ObjectParameter("DisciplineID", disciplineID) :
                new ObjectParameter("DisciplineID", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetDetailDisciplineByID_Result>("GetDetailDisciplineByID", disciplineIDParameter);
        }
    }
}
