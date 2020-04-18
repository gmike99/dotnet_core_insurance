using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;
using Logic.Interfaces;
using DAL.Interfaces;

namespace Logic.Functions
{
    public class InsuranceContractLogic : IInsuranceContractLogic
    {
        private readonly IInsuranceContract _insuranceContract;

        public async Task<Boolean> AddInsuranceContract(string documentScanUrl, int insuranceCompanyId, int insuranceClientId)
        {
            try
            {
                var result = await _insuranceContract.AddInsuranceContract(documentScanUrl, insuranceCompanyId, insuranceClientId);
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

        public async Task<List<InsuranceContract>> GetAllInsuranceContracts()
        {
            List<InsuranceContract> insuranceContracts = await _insuranceContract.GetAllInsuranceContracts();
            return insuranceContracts;
        }
    }
}
