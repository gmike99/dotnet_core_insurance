using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;


namespace DAL.Interfaces
{
    public interface IInsuranceContract
    {
        Task<InsuranceContract> AddInsuranceContract(
            string documentScanUrl,
            int insuranceCompanyId,
            int insuranceClientId
        );

        Task<List<InsuranceContract>> GetAllInsuranceContracts();
    }
}
