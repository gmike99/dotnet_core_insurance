using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;

namespace Logic.Interfaces
{
    public interface IInsuranceClientLogic
    {
        Task<Boolean> AddInsuranceClient(
            string fullName,
            string email,
            int age,
            string maritalStatus,
            string nationality,
            string citizenship,
            string residency,
            string address
        );

        Task<List<InsuranceClient>> GetAllInsuranceClients();
    }
}
