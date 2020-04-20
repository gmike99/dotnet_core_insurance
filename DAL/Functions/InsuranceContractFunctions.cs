using System.Collections.Generic;
using System.Threading.Tasks;
using DAL.Entities;
using DAL.DataContext;
using DAL.Interfaces;
using DAL.Utils;
using Microsoft.EntityFrameworkCore;

namespace DAL.Functions
{
    public class InsuranceContractFunctions : IInsuranceContract
    {
        private const int GeneratedSamples = 150;
        
        public async Task<InsuranceContract> AddInsuranceContract(string documentScanUrl, int companyId, int clientId)
        {
            InsuranceContract insuranceContract = new InsuranceContract
            {
                DocumentScanUrl = documentScanUrl,
                InsuranceCompanyId = companyId,
                InsuranceClientId = companyId
            };
            await using var context = new DatabaseContext(DatabaseContext.Ops.DbOptions);
            await context.InsuranceContracts.AddAsync(insuranceContract);
            await context.SaveChangesAsync();
            
            return insuranceContract;
        }

        public async Task<List<InsuranceContract>> GetAllInsuranceContracts()
        {
            await using var context = new DatabaseContext(DatabaseContext.Ops.DbOptions);
            var insuranceContracts = await context.InsuranceContracts.ToListAsync();
            return insuranceContracts;
        }

        public static List<InsuranceContract> GenerateData()
        {
            var objects = new List<InsuranceContract>(GeneratedSamples);
            for (var i = 0; i < GeneratedSamples; ++i)
            {
                objects.Add(GeneratorUtils.GenerateDataForClass<InsuranceContract>());
            }

            return objects;
        }
    }
}
