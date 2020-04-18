using DAL.Entities;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Logic.Interfaces;

namespace Logic.Functions
{
    public class InsuranceClientLogic : IInsuranceClientLogic
    {
        // Injecting a DAL dependency into Logic class
        private readonly IInsuranceClient _insuranceClient;

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

        public async Task<List<InsuranceClient>> GetAllInsuranceClients()
        {
            List<InsuranceClient> insuranceClients = await _insuranceClient.GetAllInsuranceClients();
            return insuranceClients;
        }
    }
}
