using System;
using System.Collections.Generic;
using System.Text;

namespace School_Portal.app.Models
{
    public class StudentEnrollment
    {
        public int StudentEnrollmentID { get; set; }
        public int SchoolClassID { get; set; }
        public int StudentID { get; set; }
        public SchoolClass SchoolClass { get; set; }
        public Student Student { get; set; }
    }
}
