using System;
using System.Collections.Generic;
using System.Text;

namespace School_Portal.app.Models
{
    public class Teacher
    {
        public int TeacherID { get; set; }
        #nullable enable
        public string? TeacherEmail { get; set; }
        #nullable disable
        public string FirstMiddleName { get; set; }
        public string LastName { get; set; }
        #nullable enable
        public string? AvatarImagePath { get; set; }
        #nullable disable

        public ICollection<TeacherEnrollment> TeacherEnrollments { get; set; }
    }
}