using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using School_Portal.app.Models;

namespace School_Portal.app.Data
{
    public static class SeedDbStudentTeacherSchoolClass
    {

        public static IHost DevelopmentDatabaseInitialization(this IHost host)
        {
            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                try
                {
                    var context = services.GetRequiredService<StudentTeacherSchoolClassContext>();
                    SeedDbStudentTeacherSchoolClass.Initialize(context);
                }
                catch (Exception ex)
                {
                    var logger = services.GetRequiredService<ILogger<Program>>();
                    logger.LogError(ex, "An error occurred creating the DB.");
                    Console.WriteLine("An error occurred seeding the DB.\n");
                }
            }
            return host;
        }
        public static void Initialize(StudentTeacherSchoolClassContext context)
        {
            context.Database.EnsureCreated();
            Console.WriteLine("Checking if StudentTeacherSchoolClass entities are populated...\n");
            // Look for any students.
            if (context.Students.Any())
            {
                Console.WriteLine("StudentTeacherSchoolClass entities have already been populated.\n");
                return;   // DB has been seeded
            }
            Console.WriteLine("Seeding StudentTeacherSchoolClass entities...\n");

            var schoolClasses = new SchoolClass[]
            {
                new SchoolClass{SchoolClassName="Red",Year=2020},
                new SchoolClass{SchoolClassName="Green",Year=2020}
            };
            foreach (SchoolClass c in schoolClasses)
            {
                context.SchoolClasses.Add(c);
            }
            context.SaveChanges();

            var students = new Student[]
            {
                new Student{FirstMiddleName="Carson",LastName="Alexander",BirthDate=DateTime.Parse("1995-09-01"),EnrollmentDate=DateTime.Parse("2005-09-01")},
                new Student{FirstMiddleName="Meredith",LastName="Alonso",BirthDate=DateTime.Parse("1995-09-01"),EnrollmentDate=DateTime.Parse("2002-09-01")},
                new Student{FirstMiddleName="Arturo",LastName="Anand",BirthDate=DateTime.Parse("1995-09-01"),EnrollmentDate=DateTime.Parse("2003-09-01")},
                new Student{FirstMiddleName="Gytis",LastName="Barzdukas",BirthDate=DateTime.Parse("1995-09-01"),EnrollmentDate=DateTime.Parse("2002-09-01")},
                new Student{FirstMiddleName="Yan",LastName="Li",BirthDate=DateTime.Parse("1995-09-01"),EnrollmentDate=DateTime.Parse("2002-09-01")},
                new Student{FirstMiddleName="Peggy",LastName="Justice",BirthDate=DateTime.Parse("1995-09-01"),EnrollmentDate=DateTime.Parse("2001-09-01")},
                new Student{FirstMiddleName="Laura",LastName="Norman",BirthDate=DateTime.Parse("1995-09-01"),EnrollmentDate=DateTime.Parse("2003-09-01")},
                new Student{FirstMiddleName="Nino",LastName="Olivetto",BirthDate=DateTime.Parse("1995-09-01"),EnrollmentDate=DateTime.Parse("2005-09-01")},
                new Student{FirstMiddleName="John",LastName="Ballzac",BirthDate=DateTime.Parse("1995-09-01"),EnrollmentDate=DateTime.Parse("2005-09-01")},
                new Student{FirstMiddleName="Blastoise",LastName="Pokemongo",BirthDate=DateTime.Parse("1995-09-01"),EnrollmentDate=DateTime.Parse("2002-09-01")},
                new Student{FirstMiddleName="Jenny",LastName="Eriksson",BirthDate=DateTime.Parse("1995-09-01"),EnrollmentDate=DateTime.Parse("2003-09-01")},
                new Student{FirstMiddleName="Peter",LastName="Badeter",BirthDate=DateTime.Parse("1995-09-01"),EnrollmentDate=DateTime.Parse("2002-09-01")},
                new Student{FirstMiddleName="Meredith",LastName="Svensson",BirthDate=DateTime.Parse("1995-09-01"),EnrollmentDate=DateTime.Parse("2002-09-01")},
                new Student{FirstMiddleName="Sally",LastName="Fields",BirthDate=DateTime.Parse("1995-09-01"),EnrollmentDate=DateTime.Parse("2001-09-01")},
                new Student{FirstMiddleName="Laura",LastName="Baura",BirthDate=DateTime.Parse("1995-09-01"),EnrollmentDate=DateTime.Parse("2003-09-01")},
                new Student{FirstMiddleName="Ninja",LastName="Warrior",BirthDate=DateTime.Parse("1995-09-01"),EnrollmentDate=DateTime.Parse("2005-09-01")}
            };
            foreach (Student s in students)
            {
                context.Students.Add(s);
            }
            context.SaveChanges();

            var studentEnrollments = new StudentEnrollment[]
            {
                new StudentEnrollment{StudentID=1,SchoolClassID=1},
                new StudentEnrollment{StudentID=2,SchoolClassID=1},
                new StudentEnrollment{StudentID=3,SchoolClassID=1},
                new StudentEnrollment{StudentID=4,SchoolClassID=1},
                new StudentEnrollment{StudentID=5,SchoolClassID=1},
                new StudentEnrollment{StudentID=6,SchoolClassID=1},
                new StudentEnrollment{StudentID=7,SchoolClassID=1},
                new StudentEnrollment{StudentID=8,SchoolClassID=1},
                new StudentEnrollment{StudentID=9,SchoolClassID=2},
                new StudentEnrollment{StudentID=10,SchoolClassID=2},
                new StudentEnrollment{StudentID=11,SchoolClassID=2},
                new StudentEnrollment{StudentID=12,SchoolClassID=2},
                new StudentEnrollment{StudentID=13,SchoolClassID=2},
                new StudentEnrollment{StudentID=14,SchoolClassID=2},
                new StudentEnrollment{StudentID=15,SchoolClassID=2},
                new StudentEnrollment{StudentID=16,SchoolClassID=2},
            };
            foreach (StudentEnrollment se in studentEnrollments)
            {
                context.StudentEnrollments.Add(se);
            }
            context.SaveChanges();

            var teachers = new Teacher[]
            {
                new Teacher{FirstMiddleName="Bram",LastName="Stoker"},
                new Teacher{FirstMiddleName="James",LastName="Bond"}
            };
            foreach (Teacher t in teachers)
            {
                context.Teachers.Add(t);
            }
            context.SaveChanges();

            var teacherEnrollments = new TeacherEnrollment[]
            {
                new TeacherEnrollment{TeacherID=1,SchoolClassID=1},
                new TeacherEnrollment{TeacherID=2,SchoolClassID=2}
            };
            foreach (TeacherEnrollment te in teacherEnrollments)
            {
                context.TeacherEnrollments.Add(te);
            }
            context.SaveChanges();
            Console.WriteLine("Finished seeding StudentTeacherSchoolClass entities in database.\n");
        }
    }
}
