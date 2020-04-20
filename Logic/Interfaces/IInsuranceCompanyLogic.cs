using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DAL.Entities;

namespace Logic.Interfaces
{
    public interface IInsuranceCompanyLogic
    {
        Task<Boolean> AddInsuranceCompany(
            string name,
            string state,
            int numEmployees,
            string specialty
        );

        Task<List<InsuranceCompany>> GetAllInsuranceCompanies();
    }
}
