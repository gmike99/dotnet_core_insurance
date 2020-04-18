using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;
using DAL.DataContext;
using DAL.Interfaces;
using Microsoft.EntityFrameworkCore;


namespace DAL.Functions
{
    public class ApplicationFunctions : IApplication
    {
        public async Task<Application> AddApplication(
            int insuranceClientId,
            string appliedDate,
            string applicationStatus,
            int insuranceFormID)
        {
            Application application = new Application
            {
                InsuranceClientId = insuranceClientId,
                InsuranceFormId = insuranceFormID,
                AppliedDate = appliedDate,
                ApplicationStatus = applicationStatus
            };
            using (var context = new DatabaseContext(DatabaseContext.Ops.DbOptions))
            {
                await context.Applications.AddAsync(application);
                await context.SaveChangesAsync();
            };
            return application;
        }

        public async Task<List<Application>> GetAllApplications()
        {
            List<Application> applications = new List<Application>();
            using (var context = new DatabaseContext(DatabaseContext.Ops.DbOptions))
            {
                applications = await context.Applications.ToListAsync();
            }
            return applications;
        }
    }
}
