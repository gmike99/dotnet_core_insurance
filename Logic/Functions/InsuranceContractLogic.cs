using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DAL.Entities;
using Logic.Interfaces;
using DAL.Interfaces;
using DAL.Functions;

namespace Logic.Functions
{
    public class InsuranceContractLogic : IInsuranceContractLogic
    {
        private readonly IInsuranceContract _insuranceContract;

        public InsuranceContractLogic()
        {
            _insuranceContract = new InsuranceContractFunctions();
        }

        public async Task<Boolean> AddInsuranceContract(string documentScanUrl, int insuranceCompanyId, int insuranceClientId)
        {
            try
            {
                var result = await _insuranceContract.AddInsuranceContract(documentScanUrl, insuranceCompanyId, insuranceClientId);
                return result.Id > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<List<InsuranceContract>> GetAllInsuranceContracts()
        {
            var insuranceContracts = await _insuranceContract.GetAllInsuranceContracts();
            return insuranceContracts;
        }
    }
}
