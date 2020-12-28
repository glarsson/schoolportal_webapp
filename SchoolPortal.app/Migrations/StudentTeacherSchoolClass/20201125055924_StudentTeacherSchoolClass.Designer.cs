﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using School_Portal.app.Data;

namespace School_Portal.app.Migrations.StudentTeacherSchoolClass
{
    [DbContext(typeof(StudentTeacherSchoolClassContext))]
    [Migration("20201125055924_StudentTeacherSchoolClass")]
    partial class StudentTeacherSchoolClass
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("School_Portal.app.Models.SchoolClass", b =>
                {
                    b.Property<int>("SchoolClassID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("SchoolClassName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("SchoolClassID");

                    b.ToTable("SchoolClass");
                });

            modelBuilder.Entity("School_Portal.app.Models.Student", b =>
                {
                    b.Property<int>("StudentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("AvatarImagePath")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("EnrollmentDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("FirstMiddleName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("LastName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("ParentEmail")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("StudentID");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("School_Portal.app.Models.StudentEnrollment", b =>
                {
                    b.Property<int>("StudentEnrollmentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("SchoolClassID")
                        .HasColumnType("int");

                    b.Property<int>("StudentID")
                        .HasColumnType("int");

                    b.HasKey("StudentEnrollmentID");

                    b.HasIndex("SchoolClassID");

                    b.HasIndex("StudentID");

                    b.ToTable("StudentEnrollment");
                });

            modelBuilder.Entity("School_Portal.app.Models.Teacher", b =>
                {
                    b.Property<int>("TeacherID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("AvatarImagePath")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("FirstMiddleName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("LastName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("TeacherEmail")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("TeacherID");

                    b.ToTable("Teacher");
                });

            modelBuilder.Entity("School_Portal.app.Models.TeacherEnrollment", b =>
                {
                    b.Property<int>("TeacherEnrollmentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("SchoolClassID")
                        .HasColumnType("int");

                    b.Property<int>("TeacherID")
                        .HasColumnType("int");

                    b.HasKey("TeacherEnrollmentID");

                    b.HasIndex("SchoolClassID");

                    b.HasIndex("TeacherID");

                    b.ToTable("TeacherEnrollment");
                });

            modelBuilder.Entity("School_Portal.app.Models.StudentEnrollment", b =>
                {
                    b.HasOne("School_Portal.app.Models.SchoolClass", "SchoolClass")
                        .WithMany("StudentEnrollments")
                        .HasForeignKey("SchoolClassID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("School_Portal.app.Models.Student", "Student")
                        .WithMany("StudentEnrollments")
                        .HasForeignKey("StudentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SchoolClass");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("School_Portal.app.Models.TeacherEnrollment", b =>
                {
                    b.HasOne("School_Portal.app.Models.SchoolClass", "SchoolClass")
                        .WithMany("TeacherEnrollments")
                        .HasForeignKey("SchoolClassID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("School_Portal.app.Models.Teacher", "Teacher")
                        .WithMany("TeacherEnrollments")
                        .HasForeignKey("TeacherID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SchoolClass");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("School_Portal.app.Models.SchoolClass", b =>
                {
                    b.Navigation("StudentEnrollments");

                    b.Navigation("TeacherEnrollments");
                });

            modelBuilder.Entity("School_Portal.app.Models.Student", b =>
                {
                    b.Navigation("StudentEnrollments");
                });

            modelBuilder.Entity("School_Portal.app.Models.Teacher", b =>
                {
                    b.Navigation("TeacherEnrollments");
                });
#pragma warning restore 612, 618
        }
    }
}
