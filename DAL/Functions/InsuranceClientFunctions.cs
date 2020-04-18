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
    public class InsuranceClientFunctions : IInsuranceClient
    {
        public async Task<InsuranceClient> AddInsuranceClient(string fullName, string email)
        {
            InsuranceClient insuranceClient = new InsuranceClient
            {
                FullName = fullName,
                Email = email
            };
            using (var context = new DatabaseContext(DatabaseContext.Ops.DbOptions))
            {
                await context.InsuranceClients.AddAsync(insuranceClient);
                await context.SaveChangesAsync();
            };
            return insuranceClient;
        }

        public async Task<List<InsuranceClient>> GetAllInsuranceClients()
        {
            List<InsuranceClient> insuranceClients = new List<InsuranceClient>();
            using (var context = new DatabaseContext(DatabaseContext.Ops.DbOptions))
            {
                insuranceClients = await context.InsuranceClients.ToListAsync();
            }
            return insuranceClients;
        }
}
}
