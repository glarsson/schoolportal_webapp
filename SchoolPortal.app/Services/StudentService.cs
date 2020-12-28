using School_Portal.app.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using School_Portal.app.Models;
using Microsoft.EntityFrameworkCore;

namespace School_Portal.app.Services
{
    public class StudentService
    {

        private StudentTeacherSchoolClassContext dbContext;

        public StudentService(StudentTeacherSchoolClassContext dbContext)
        {
            this.dbContext = dbContext;
        }

        // List students
        public async Task<List<Student>> GetStudentAsync()
        {
            return await dbContext.Students.ToListAsync();
        }

        // Add student
        public async Task<Student> AddStudentAsync(Student student)
        {
            try
            {
                dbContext.Students.Add(student);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
            return student;
        }

        // Update student
        public async Task<Student> UpdateStudentAsync(Student student)
        {
            try
            {
                var studentExist = dbContext.Students.FirstOrDefault(p => p.StudentID == student.StudentID);
                if (studentExist != null)
                {
                    dbContext.Update(student);
                    await dbContext.SaveChangesAsync();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return student;
        }

        // Delete student
        public async Task DeleteStudentAsync(Student student)
        {
            try
            {
                dbContext.Students.Remove(student);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}

