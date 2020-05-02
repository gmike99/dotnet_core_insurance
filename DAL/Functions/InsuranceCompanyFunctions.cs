using System.Collections.Generic;
using System.Threading.Tasks;
using DAL.Entities;
using DAL.DataContext;
using DAL.Interfaces;
using DAL.Utils;
using Microsoft.EntityFrameworkCore;

namespace DAL.Functions
{
    public class InsuranceCompanyFunctions : IInsuranceCompany
    {
        private const int GeneratedSamples = 150;

        public async Task<InsuranceCompany> AddInsuranceCompany(string name, string state, int numEmployees, string specialty)
        {
            InsuranceCompany insuranceCompany = new InsuranceCompany
            {
                Name = name,
                State = state,
                NumEmployees = numEmployees,
                Specialty = specialty
            };
            await using var context = new DatabaseContext(DatabaseContext.Ops.DbOptions);
            await context.InsuranceCompanies.AddAsync(insuranceCompany);
            await context.SaveChangesAsync();

            return insuranceCompany;
        }

        public async Task<List<InsuranceCompany>> GetAllInsuranceCompanies()
        {
            await using var context = new DatabaseContext(DatabaseContext.Ops.DbOptions);
            var insuranceCompanies = await context.InsuranceCompanies.ToListAsync();
            return insuranceCompanies;
        }

        public static List<InsuranceCompany> GenerateData()
        {
            var objects = new List<InsuranceCompany>(GeneratedSamples);
            for (var i = 0; i < GeneratedSamples; ++i)
            {
                objects.Add(GeneratorUtils.GenerateDataForClass<InsuranceCompany>());
            }

            return objects;
        }
    }
}
