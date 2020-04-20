using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DAL.Entities;


namespace DAL.Interfaces
{
    public interface IInsuranceContract
    {
        Task<InsuranceContract> AddInsuranceContract(
            string documentScanUrl,
            int companyId,
            int clientId
        );

        Task<List<InsuranceContract>> GetAllInsuranceContracts();
    }
}
