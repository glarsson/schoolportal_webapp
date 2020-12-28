using School_Portal.app.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using School_Portal.app.Models;
using Microsoft.EntityFrameworkCore;

namespace School_Portal.app.Services
{
    public class TeacherService
    {

        private StudentTeacherSchoolClassContext dbContext;

        public TeacherService(StudentTeacherSchoolClassContext dbContext)
        {
            this.dbContext = dbContext;
        }

        // List students
        public async Task<List<Teacher>> GetTeacherAsync()
        {
            return await dbContext.Teachers.ToListAsync();
        }

        // Add student
        public async Task<Teacher> AddTeacherAsync(Teacher teacher)
        {
            try
            {
                dbContext.Teachers.Add(teacher);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
            return teacher;
        }

        // Update student
        public async Task<Teacher> UpdateTeacherAsync(Teacher teacher)
        {
            try
            {
                var teacherExist = dbContext.Teachers.FirstOrDefault(p => p.TeacherID == teacher.TeacherID);
                if (teacherExist != null)
                {
                    dbContext.Update(teacher);
                    await dbContext.SaveChangesAsync();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return teacher;
        }

        // Delete student
        public async Task DeleteTeacherAsync(Teacher teacher)
        {
            try
            {
                dbContext.Teachers.Remove(teacher);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}

