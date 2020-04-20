using System;
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
    public class InsuranceCompanyFunctions : IInsuranceCompany
    {
        public async Task<InsuranceCompany> AddInsuranceCompany(string name, string state, int numEmployees, string specialty)
        {
            InsuranceCompany insuranceCompany = new InsuranceCompany
            {
                Name = name,
                State = state,
                NumEmployees = numEmployees,
                Specialty = specialty
            };
            using (var context = new DatabaseContext(DatabaseContext.Ops.DbOptions))
            {
                await context.InsuranceCompanies.AddAsync(insuranceCompany);
                await context.SaveChangesAsync();
            };
            return insuranceCompany;
        }

        public async Task<List<InsuranceCompany>> GetAllInsuranceCompanies()
        {
            List<InsuranceCompany> insuranceCompanies = new List<InsuranceCompany>();
            using (var context = new DatabaseContext(DatabaseContext.Ops.DbOptions))
            {
                insuranceCompanies = await context.InsuranceCompanies.ToListAsync();
            }
            return insuranceCompanies;
        }

        public Task<bool> GenerateData()
        {
            throw new NotImplementedException();
        }
    }
}
