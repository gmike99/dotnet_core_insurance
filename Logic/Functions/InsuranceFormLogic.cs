using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;
using Logic.Interfaces;
using DAL.Interfaces;

namespace Logic.Functions
{
    public class InsuranceFormLogic : IInsuranceFormLogic
    {
        private readonly IInsuranceForm _insuranceForm;

        public async Task<Boolean> AddInsuranceForm(string destinationState, string plannedArrivalDate,
                                                    string plannedDepartureDate, int daysInCountry, string insurancePlan)
        {
            try
            {
                var result = await _insuranceForm.AddInsuranceForm(destinationState, plannedArrivalDate, plannedDepartureDate, daysInCountry, insurancePlan);
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

        public async Task<List<InsuranceForm>> GetAllInsuranceForms()
        {
            List<InsuranceForm> insuranceForms = await _insuranceForm.GetAllInsuranceForms();
            return insuranceForms;
        }
    }
}
