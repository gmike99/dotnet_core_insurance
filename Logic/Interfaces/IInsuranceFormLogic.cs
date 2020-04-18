using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;

namespace Logic.Interfaces
{
    public interface IInsuranceFormLogic
    {
        Task<Boolean> AddInsuranceForm(
            string destinationState,
            string plannedArrivalDate,
            string plannedDepartureDate,
            int daysInCountry,
            string insurancePlan
        );

        Task<List<InsuranceForm>> GetAllInsuranceForms();
    }
}
