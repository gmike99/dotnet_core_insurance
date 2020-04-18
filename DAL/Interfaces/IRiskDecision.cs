using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;


namespace DAL.Interfaces
{
    public interface IRiskDecision
    {
        Task<RiskDecision> AddRiskDecision(
            string decisionDescription,
            double evaluatedRiskDamage,
            double evaluatedDamageChance,
            double evaluatedInsuranceFee,
            int applicatinoId
        );

        Task<List<RiskDecision>> GetAllRiskDecisions();
    }
}
