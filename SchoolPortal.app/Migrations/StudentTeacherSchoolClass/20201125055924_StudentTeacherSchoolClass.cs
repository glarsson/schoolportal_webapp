using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace School_Portal.app.Migrations.StudentTeacherSchoolClass
{
    public partial class StudentTeacherSchoolClass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SchoolClass",
                columns: table => new
                {
                    SchoolClassID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    SchoolClassName = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Year = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SchoolClass", x => x.SchoolClassID);
                });

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    StudentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ParentEmail = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    FirstMiddleName = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    LastName = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    BirthDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    AvatarImagePath = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    EnrollmentDate = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.StudentID);
                });

            migrationBuilder.CreateTable(
                name: "Teacher",
                columns: table => new
                {
                    TeacherID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TeacherEmail = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    FirstMiddleName = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    LastName = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    AvatarImagePath = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teacher", x => x.TeacherID);
                });

            migrationBuilder.CreateTable(
                name: "StudentEnrollment",
                columns: table => new
                {
                    StudentEnrollmentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    SchoolClassID = table.Column<int>(type: "int", nullable: false),
                    StudentID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentEnrollment", x => x.StudentEnrollmentID);
                    table.ForeignKey(
                        name: "FK_StudentEnrollment_SchoolClass_SchoolClassID",
                        column: x => x.SchoolClassID,
                        principalTable: "SchoolClass",
                        principalColumn: "SchoolClassID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentEnrollment_Student_StudentID",
                        column: x => x.StudentID,
                        principalTable: "Student",
                        principalColumn: "StudentID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TeacherEnrollment",
                columns: table => new
                {
                    TeacherEnrollmentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    SchoolClassID = table.Column<int>(type: "int", nullable: false),
                    TeacherID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeacherEnrollment", x => x.TeacherEnrollmentID);
                    table.ForeignKey(
                        name: "FK_TeacherEnrollment_SchoolClass_SchoolClassID",
                        column: x => x.SchoolClassID,
                        principalTable: "SchoolClass",
                        principalColumn: "SchoolClassID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TeacherEnrollment_Teacher_TeacherID",
                        column: x => x.TeacherID,
                        principalTable: "Teacher",
                        principalColumn: "TeacherID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StudentEnrollment_SchoolClassID",
                table: "StudentEnrollment",
                column: "SchoolClassID");

            migrationBuilder.CreateIndex(
                name: "IX_StudentEnrollment_StudentID",
                table: "StudentEnrollment",
                column: "StudentID");

            migrationBuilder.CreateIndex(
                name: "IX_TeacherEnrollment_SchoolClassID",
                table: "TeacherEnrollment",
                column: "SchoolClassID");

            migrationBuilder.CreateIndex(
                name: "IX_TeacherEnrollment_TeacherID",
                table: "TeacherEnrollment",
                column: "TeacherID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentEnrollment");

            migrationBuilder.DropTable(
                name: "TeacherEnrollment");

            migrationBuilder.DropTable(
                name: "Student");

            migrationBuilder.DropTable(
                name: "SchoolClass");

            migrationBuilder.DropTable(
                name: "Teacher");
        }
    }
}
