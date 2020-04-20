using System.Collections.Generic;
using System.Threading.Tasks;
using DAL.Entities;
using DAL.DataContext;
using DAL.Interfaces;
using DAL.Utils;
using Microsoft.EntityFrameworkCore;


namespace DAL.Functions
{
    public class RiskDecisionFunctions : IRiskDecision
    {
        private const int GeneratedSamples = 150;
        
        public async Task<RiskDecision> AddRiskDecision(
            string decisionDescription,
            double evaluatedRiskDamage,
            double evaluatedDamageChance,
            double evaluatedInsuranceFee,
            int applicationId)
        {
            RiskDecision riskDecision = new RiskDecision
            {
                DecisionDescription = decisionDescription,
                EvaluaetedRiskDamage = evaluatedRiskDamage,
                EvaluatedDamageChance = evaluatedDamageChance,
                EvaluatedInsuranceFee = evaluatedInsuranceFee,
                ApplicationId = applicationId
            };
            await using var context = new DatabaseContext(DatabaseContext.Ops.DbOptions);
            await context.RiskDecisions.AddAsync(riskDecision);
            await context.SaveChangesAsync();
            
            return riskDecision;
        }

        public async Task<List<RiskDecision>> GetAllRiskDecisions()
        {
            await using var context = new DatabaseContext(DatabaseContext.Ops.DbOptions);
            var riskDecisions = await context.RiskDecisions.ToListAsync();
            return riskDecisions;
        }

        public List<RiskDecision> GenerateData()
        {
            var objects = new List<RiskDecision>(GeneratedSamples);
            for (var i = 0; i < GeneratedSamples; ++i)
            {
                objects.Add(GeneratorUtils.GenerateDataForClass<RiskDecision>());
            }

            return objects;
        }
    }
}
