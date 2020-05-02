using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DAL.Entities;
using DAL.Functions;
using Logic.Interfaces;
using DAL.Interfaces;

namespace Logic.Functions
{
    public class ApplicationLogic : IApplicationLogic
    {
        private readonly IApplication _application;

        public ApplicationLogic()
        {
            _application = new ApplicationFunctions();
        }

        public async Task<Boolean> AddApplication(int insuranceClientId, string appliedDate, string applicationStatus, int insuranceFormID)
        {
            try
            {
                var result = await _application.AddApplication(insuranceClientId, appliedDate, applicationStatus, insuranceFormID);
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

        public async Task<List<Application>> GetAllApplications()
        {
            List<Application> applications = await _application.GetAllApplications();
            return applications;
        }
    }
}
