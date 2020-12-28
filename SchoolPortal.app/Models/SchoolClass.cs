using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace School_Portal.app.Models
{
    public class SchoolClass
    {
        // With the below option we can set our own IDs, for now let the database automatically do it
        // [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SchoolClassID { get; set; }
        public string SchoolClassName { get; set; }
        public int Year { get; set; }

        public ICollection<StudentEnrollment> StudentEnrollments { get; set; }
        public ICollection<TeacherEnrollment> TeacherEnrollments { get; set; }
    }
}
