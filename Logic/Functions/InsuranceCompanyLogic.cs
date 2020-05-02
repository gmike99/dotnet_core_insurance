using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DAL.Entities;
using Logic.Interfaces;
using DAL.Interfaces;
using DAL.Functions;

namespace Logic.Functions
{
    public class InsuranceCompanyLogic : IInsuranceCompanyLogic
    {
        private readonly IInsuranceCompany _insuranceCompany;

        public InsuranceCompanyLogic()
        {
            _insuranceCompany = new InsuranceCompanyFunctions();
        }

        public async Task<Boolean> AddInsuranceCompany(string name, string state, int numEmployees, string specialty)
        {
            try
            {
                var result = await _insuranceCompany.AddInsuranceCompany(name, state, numEmployees, specialty);
                return result.Id > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<List<InsuranceCompany>> GetAllInsuranceCompanies()
        {
            List<InsuranceCompany> insuranceCompanies = await _insuranceCompany.GetAllInsuranceCompanies();
            return insuranceCompanies;
        }
    }
}
