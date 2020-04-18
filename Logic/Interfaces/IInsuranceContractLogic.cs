using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;

namespace Logic.Interfaces
{
    public interface IInsuranceContractLogic
    {
        Task<Boolean> AddInsuranceContract(
            string documentScanUrl,
            int insuranceCompanyId,
            int insuranceClientId
        );

        Task<List<InsuranceContract>> GetAllInsuranceContracts();
    }
}
