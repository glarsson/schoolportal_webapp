using System;
using System.Collections.Generic;
using System.Text;

namespace School_Portal.app.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        #nullable enable
        public string? ParentEmail { get; set; }
        #nullable disable
        public string FirstMiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        #nullable enable
        public string? AvatarImagePath { get; set; }
        #nullable disable
        public DateTime EnrollmentDate { get; set; }

        public ICollection<StudentEnrollment> StudentEnrollments { get; set; }
    }
}