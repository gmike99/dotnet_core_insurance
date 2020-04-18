using System;
using System.Collections.Generic;
using System.Text;
using DAL.Entities;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IApplication
    {
        Task<Application> AddApplication(
            int insuranceClientId,
            string appliedDate,
            string applicationStatus,
            int insuranceFormID
        );

        Task<List<Application>> GetAllApplications();
    }
}
