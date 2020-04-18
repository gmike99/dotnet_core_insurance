using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;

namespace Logic.Interfaces
{
    public interface IApplicationLogic
    {
        Task<Boolean> AddApplication(
            int insuranceClientId,
            string appliedDate,
            string applicationStatus,
            int insuranceFormID
        );

        Task<List<Application>> GetAllApplications();
    }
}
