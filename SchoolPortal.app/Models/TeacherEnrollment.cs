using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School_Portal.app.Models
{
    public class TeacherEnrollment
    {
        public int TeacherEnrollmentID { get; set; }
        public int SchoolClassID { get; set; }
        public int TeacherID { get; set; }
        public SchoolClass SchoolClass { get; set; }
        public Teacher Teacher { get; set; }
    }
}
