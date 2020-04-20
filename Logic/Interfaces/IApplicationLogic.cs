using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DAL.Entities;

namespace Logic.Interfaces
{
    public interface IApplicationLogic
    {
        Task<Boolean> AddApplication(
            int clientId,
            string appliedDate,
            string applicationStatus,
            int formId
        );

        Task<List<Application>> GetAllApplications();
    }
}
