using System.Collections.Generic;
using System.Threading.Tasks;
using DAL.Entities;
using DAL.DataContext;
using DAL.Interfaces;
using DAL.Utils;
using Microsoft.EntityFrameworkCore;

namespace DAL.Functions
{
    public class InsuranceClientFunctions : IInsuranceClient
    {
        private const int GeneratedSamples = 150;
        
        public async Task<InsuranceClient> AddInsuranceClient(
            string fullName,
            string email,
            int age,
            string maritalStatus,
            string nationality,
            string residency,
            string citizenship,
            string address)
        {
            InsuranceClient insuranceClient = new InsuranceClient
            {
                FullName = fullName,
                Email = email,
                Age = age,
                MaritalStatus = maritalStatus,
                Nationality =nationality,
                Residency = residency,
                Citizenship = citizenship,
                Address = address
            };
            await using var context = new DatabaseContext(DatabaseContext.Ops.DbOptions);
            await context.InsuranceClients.AddAsync(insuranceClient);
            await context.SaveChangesAsync();
            return insuranceClient;
        }

        public async Task<List<InsuranceClient>> GetAllInsuranceClients()
        {
            await using var context = new DatabaseContext(DatabaseContext.Ops.DbOptions);
            var insuranceClients = await context.InsuranceClients.ToListAsync();
            return insuranceClients;
        }

        public static List<InsuranceClient> GenerateData()
        {
            var objects = new List<InsuranceClient>(GeneratedSamples);
            for (var i = 0; i < GeneratedSamples; ++i)
            {
                objects.Add(GeneratorUtils.GenerateDataForClass<InsuranceClient>());
            }

            return objects;
        }
    }
}
