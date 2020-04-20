using System.Collections.Generic;
using System.Threading.Tasks;
using DAL.Entities;
using DAL.DataContext;
using DAL.Interfaces;
using DAL.Utils;
using Microsoft.EntityFrameworkCore;


namespace DAL.Functions
{
    public class InsuranceFormFunctions : IInsuranceForm
    {
        private const int GeneratedSamples = 150;
        
        public async Task<InsuranceForm> AddInsuranceForm(
            string destinationState,
            string plannedArrivalDate,
            string plannedDepartureDate,
            int daysInCountry,
            string plan)
        {
            InsuranceForm insuranceForm = new InsuranceForm
            {
                DestinationState = destinationState,
                PlannedArrivalDate = plannedArrivalDate,
                PlannedDepartureDate = plannedDepartureDate,
                DaysInCountry = daysInCountry,
                InsurancePlan = plan
            };
            await using var context = new DatabaseContext(DatabaseContext.Ops.DbOptions);
            await context.InsuranceForms.AddAsync(insuranceForm);
            await context.SaveChangesAsync();
            return insuranceForm;
        }

        public async Task<List<InsuranceForm>> GetAllInsuranceForms()
        {
            await using var context = new DatabaseContext(DatabaseContext.Ops.DbOptions);
            var insuranceForms = await context.InsuranceForms.ToListAsync();
            return insuranceForms;
        }

        public static List<InsuranceForm> GenerateData()
        {
            var objects = new List<InsuranceForm>(GeneratedSamples);
            for (var i = 0; i < GeneratedSamples; ++i)
            {
                objects.Add(GeneratorUtils.GenerateDataForClass<InsuranceForm>());
            }

            return objects;
        }
    }
}
