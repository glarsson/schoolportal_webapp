using School_Portal.app.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using School_Portal.app.Models;
using Microsoft.EntityFrameworkCore;

namespace School_Portal.app.Services
{
    public class SchoolClassService
    {

        private StudentTeacherSchoolClassContext dbContext;

        public SchoolClassService(StudentTeacherSchoolClassContext dbContext)
        {
            this.dbContext = dbContext;
        }

        // List schoolClasss
        public async Task<List<SchoolClass>> GetSchoolClassAsync()
        {
            return await dbContext.SchoolClasses.ToListAsync();
        }

        // Add SchoolClass
        public async Task<SchoolClass> AddSchoolClassAsync(SchoolClass schoolClass)
        {
            try
            {
                dbContext.SchoolClasses.Add(schoolClass);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
            return schoolClass;
        }

        // Update SchoolClass
        public async Task<SchoolClass> UpdateSchoolClassAsync(SchoolClass schoolClass)
        {
            try
            {
                var schoolClassExist = dbContext.SchoolClasses.FirstOrDefault(p => p.SchoolClassID == schoolClass.SchoolClassID);
                if (schoolClassExist != null)
                {
                    dbContext.Update(schoolClass);
                    await dbContext.SaveChangesAsync();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return schoolClass;
        }

        // Delete SchoolClass
        public async Task DeleteSchoolClassAsync(SchoolClass schoolClass)
        {
            try
            {
                dbContext.SchoolClasses.Remove(schoolClass);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}

