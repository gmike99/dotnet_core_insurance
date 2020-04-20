using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DAL.Entities;
using Logic.Interfaces;
using DAL.Interfaces;

namespace Logic.Functions
{
    public class InsuranceCompanyLogic : IInsuranceCompanyLogic
    {
        private readonly IInsuranceCompany _insuranceCompany;

        public async Task<Boolean> AddInsuranceCompany(string name, string state, int numEmployees, string specialty)
        {
            try
            {
                var result = await _insuranceCompany.AddInsuranceCompany(name, state, numEmployees, specialty);
                if (result.Id > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
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
