using DAL.Utils;
using System.Collections.Generic;
using System.Threading.Tasks;
using DAL.Entities;
using DAL.DataContext;
using DAL.Interfaces;
using Microsoft.EntityFrameworkCore;


namespace DAL.Functions
{
    public class ApplicationFunctions : IApplication
    {
        private const int GeneratedSamples = 150;

        public async Task<Application> AddApplication(
            int clientId,
            string appliedDate,
            string applicationStatus,
            int formId)
        {
            var application = new Application
            {
                InsuranceClientId = clientId,
                InsuranceFormId = formId,
                AppliedDate = appliedDate,
                ApplicationStatus = applicationStatus
            };
            await using var context = new DatabaseContext(DatabaseContext.Ops.DbOptions);
            await context.Applications.AddAsync(application);
            await context.SaveChangesAsync();
            return application;
        }

        public async Task<List<Application>> GetAllApplications()
        {
            await using var context = new DatabaseContext(DatabaseContext.Ops.DbOptions);
            var applications = await context.Applications.ToListAsync();
            return applications;
        }

        public static List<Application> GenerateData()
        {
            var objects = new List<Application>(GeneratedSamples);
            for (var i = 0; i < GeneratedSamples; ++i)
            {
                objects.Add(GeneratorUtils.GenerateDataForClass<Application>());
            }

            return objects;
        }
    }
}
