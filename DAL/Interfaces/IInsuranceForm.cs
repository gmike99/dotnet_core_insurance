using System.Collections.Generic;
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
            int daysInCountry,
            string plan
        );

        Task<List<InsuranceForm>> GetAllInsuranceForms();
        
        List<InsuranceForm> GenerateData();
    }
}
