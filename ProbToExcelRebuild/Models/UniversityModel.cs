namespace ProbToExcelRebuild.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class UniversityModel : DbContext
    {
        public UniversityModel()
            : base("name=UniversityModel")
        {
        }

        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Job_Title> Job_Title { get; set; }
        public virtual DbSet<New_Associate_Professor_Average_Salary> New_Associate_Professor_Average_Salary { get; set; }
        public virtual DbSet<Per_Job_Per_Department> Per_Job_Per_Department { get; set; }
        public virtual DbSet<Specialty_Code> Specialty_Code { get; set; }
        public virtual DbSet<University> Universities { get; set; }
        public virtual DbSet<EmployeeView> EmployeeViews { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>()
                .Property(e => e.ID_DEPARTMENT)
                .IsUnicode(false);

            modelBuilder.Entity<Department>()
                .HasMany(e => e.Employees)
                .WithRequired(e => e.Department)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Department>()
                .HasMany(e => e.New_Associate_Professor_Average_Salary)
                .WithRequired(e => e.Department)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.ID_DEPARTMENT)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.TOTAL_SALARY)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Job_Title>()
                .Property(e => e.JOB_TITLE_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<Job_Title>()
                .HasMany(e => e.Employees)
                .WithRequired(e => e.Job_Title)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Job_Title>()
                .HasMany(e => e.Per_Job_Per_Department)
                .WithRequired(e => e.Job_Title)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<New_Associate_Professor_Average_Salary>()
                .Property(e => e.ID_DEPARTMENT)
                .IsUnicode(false);

            modelBuilder.Entity<New_Associate_Professor_Average_Salary>()
                .Property(e => e.AVERAGE_SALARY)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Per_Job_Per_Department>()
                .Property(e => e.ID_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<Per_Job_Per_Department>()
                .Property(e => e.AVERAGE_SALARY)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Specialty_Code>()
                .Property(e => e.ID_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<Specialty_Code>()
                .Property(e => e.ID_DEPARTMENT)
                .IsUnicode(false);

            modelBuilder.Entity<Specialty_Code>()
                .HasMany(e => e.Per_Job_Per_Department)
                .WithRequired(e => e.Specialty_Code)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<University>()
                .Property(e => e.UNIVERSITY_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<University>()
                .HasMany(e => e.Employees)
                .WithRequired(e => e.University)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<University>()
                .HasMany(e => e.Per_Job_Per_Department)
                .WithRequired(e => e.University)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EmployeeView>()
                .Property(e => e.TOTAL_SALARY)
                .HasPrecision(19, 4);

            modelBuilder.Entity<EmployeeView>()
                .Property(e => e.UNIVERSITY_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<EmployeeView>()
                .Property(e => e.ID_DEPARTMENT)
                .IsUnicode(false);

            modelBuilder.Entity<EmployeeView>()
                .Property(e => e.JOB_TITLE_NAME)
                .IsUnicode(false);
        }
    }
}
