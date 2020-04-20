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
    public class RiskDecisionFunctions : IRiskDecision
    {
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
            using (var context = new DatabaseContext(DatabaseContext.Ops.DbOptions))
            {
                await context.RiskDecisions.AddAsync(riskDecision);
                await context.SaveChangesAsync();
            };
            return riskDecision;
        }

        public async Task<List<RiskDecision>> GetAllRiskDecisions()
        {
            List<RiskDecision> riskDecisions = new List<RiskDecision>();
            using (var context = new DatabaseContext(DatabaseContext.Ops.DbOptions))
            {
                riskDecisions = await context.RiskDecisions.ToListAsync();
            }
            return riskDecisions;
        }

        public Task<bool> GenerateData()
        {
            throw new NotImplementedException();
        }
    }
}
