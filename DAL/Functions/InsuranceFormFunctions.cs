using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;
using DAL.DataContext;
using DAL.Interfaces;
using Microsoft.EntityFrameworkCore;


namespace DAL.Functions
{
    public class InsuranceFormFunctions : IInsuranceForm
    {
        public async Task<InsuranceForm> AddInsuranceForm(
            string destinationState,
            string plannedArrivalDate,
            string plannedDepartureDate,
            int daysInCountry,
            string insurancePlan)
        {
            InsuranceForm insuranceForm = new InsuranceForm
            {
                DestinationState = destinationState,
                PlannedArrivalDate = plannedArrivalDate,
                PlannedDepartureDate = plannedDepartureDate,
                DaysInCountry = daysInCountry,
                InsurancePlan = insurancePlan
            };
            using (var context = new DatabaseContext(DatabaseContext.Ops.DbOptions))
            {
                await context.InsuranceForms.AddAsync(insuranceForm);
                await context.SaveChangesAsync();
            };
            return insuranceForm;
        }

        public async Task<List<InsuranceForm>> GetAllInsuranceForms()
        {
            List<InsuranceForm> insuranceForms = new List<InsuranceForm>();
            using (var context = new DatabaseContext(DatabaseContext.Ops.DbOptions))
            {
                insuranceForms = await context.InsuranceForms.ToListAsync();
            }
            return insuranceForms;
        }
    }
}
