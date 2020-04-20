using DAL.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IInsuranceClient
    {
        Task<InsuranceClient> AddInsuranceClient(
            string fullName,
            string email,
            int age,
            string maritalStatus,
            string nationality,
            string residency,
            string citizenship,
            string address
        );

        Task<List<InsuranceClient>> GetAllInsuranceClients();
    }
}
