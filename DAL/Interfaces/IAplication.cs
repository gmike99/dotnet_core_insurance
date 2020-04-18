using System;
using System.Collections.Generic;
using System.Text;
using DAL.Entities;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IAplication
    {
        Task<Application> AddApplication(
            int insuranceClientId,
            string appliedDate,
            string applicationStatus,
            string riskDecision,
            int insuranceFormID
        );

        Task<List<Application>> GetAllApplications();
    }
}
