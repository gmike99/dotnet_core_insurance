using System.Collections.Generic;
using DAL.Entities;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IApplication
    {
        Task<Application> AddApplication(
            int clientId,
            string appliedDate,
            string applicationStatus,
            int formId
        );

        Task<List<Application>> GetAllApplications();
    }
}
