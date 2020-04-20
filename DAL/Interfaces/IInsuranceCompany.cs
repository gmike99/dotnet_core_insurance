using System.Collections.Generic;
using System.Threading.Tasks;
using DAL.Entities;

namespace DAL.Interfaces
{
    public interface IInsuranceCompany
    {
        Task<InsuranceCompany> AddInsuranceCompany(
            string name,
            string state,
            int numEmployees,
            string specialty
        );

        Task<List<InsuranceCompany>> GetAllInsuranceCompanies();
    }
}
