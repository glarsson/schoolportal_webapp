using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using School_Portal.app.Models;

namespace School_Portal.app.Data
{
    public class StudentTeacherSchoolClassContext : DbContext
    {
        public StudentTeacherSchoolClassContext(DbContextOptions<StudentTeacherSchoolClassContext> options) : base(options)
        {
        }

        public DbSet<SchoolClass> SchoolClasses { get; set; }
        public DbSet<StudentEnrollment> StudentEnrollments { get; set; }
        public DbSet<TeacherEnrollment> TeacherEnrollments { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SchoolClass>().ToTable("SchoolClass");
            modelBuilder.Entity<Student>().ToTable("Student");
            modelBuilder.Entity<Teacher>().ToTable("Teacher");
            modelBuilder.Entity<StudentEnrollment>().ToTable("StudentEnrollment");
            modelBuilder.Entity<TeacherEnrollment>().ToTable("TeacherEnrollment");
        }
    }
}
