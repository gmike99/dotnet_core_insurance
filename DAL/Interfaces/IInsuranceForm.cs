using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;


namespace DAL.Interfaces
{
    public interface IInsuranceForm
    {
        Task<InsuranceForm> AddInsuranceForm(
            string destinationState,
            string plannedArrivalDate,
            string plannedDepartureDate,
            string daysInCountry,
            string insurancePlan
        );

        Task<InsuranceForm> GetAllInsuranceForms();
    }
}
