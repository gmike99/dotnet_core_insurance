using DAL.Entities;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DAL.Functions;
using Logic.Interfaces;

namespace Logic.Functions
{
    public class InsuranceClientLogic : IInsuranceClientLogic
    {
        private readonly IInsuranceClient _insuranceClient;

        public InsuranceClientLogic()
        {
            _insuranceClient = new InsuranceClientFunctions();
        }

        public async Task<Boolean> AddInsuranceClient(
            string fullName,
            string email,
            int age,
            string maritalStatus,
            string nationality,
            string citizenship,
            string residency,
            string address)
        {
            try
            {
                var result = await _insuranceClient.AddInsuranceClient(fullName, email, age, maritalStatus, nationality, citizenship, residency, address);
                return result.Id > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<List<InsuranceClient>> GetAllInsuranceClients()
        {
            List<InsuranceClient> insuranceClients = await _insuranceClient.GetAllInsuranceClients();
            return insuranceClients;
        }
    }
}
