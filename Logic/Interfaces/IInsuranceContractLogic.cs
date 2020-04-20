using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DAL.Entities;

namespace Logic.Interfaces
{
    public interface IInsuranceContractLogic
    {
        Task<Boolean> AddInsuranceContract(
            string documentScanUrl,
            int companyId,
            int clientId
        );

        Task<List<InsuranceContract>> GetAllInsuranceContracts();
    }
}
