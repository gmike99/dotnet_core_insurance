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
    public class InsuranceContractFunctions : IInsuranceContract
    {
        public async Task<InsuranceContract> AddInsuranceContract(string documentScanUrl, int insuranceCompanyId, int insuranceClientId)
        {
            InsuranceContract insuranceContract = new InsuranceContract
            {
                DocumentScanUrl = documentScanUrl,
                InsuranceCompanyId = insuranceCompanyId,
                InsuranceClientId = insuranceCompanyId
            };
            using (var context = new DatabaseContext(DatabaseContext.Ops.DbOptions))
            {
                await context.InsuranceContracts.AddAsync(insuranceContract);
                await context.SaveChangesAsync();
            };
            return insuranceContract;
        }

        public async Task<List<InsuranceContract>> GetAllInsuranceContracts()
        {
            List<InsuranceContract> insuranceContracts = new List<InsuranceContract>();
            using (var context = new DatabaseContext(DatabaseContext.Ops.DbOptions))
            {
                insuranceContracts = await context.InsuranceContracts.ToListAsync();
            }
            return insuranceContracts;
        }
    }
}
