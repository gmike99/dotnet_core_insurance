using DAL.Entities;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Logic.InsuranceClientLogic
{
    public class InsuranceClientLogic
    {
        // Injecting a DAL dependency into Logic class
        private readonly IInsuranceClient _insuranceClient = new DAL.Functions.InsuranceClientImpl();

        public async Task<Boolean> CreateNewInsuranceClient(string fullName, string email)
        {
            try
            {
                var result = await _insuranceClient.AddInsuranceClient(fullName, email);
                if (result.Id > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception error)
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
