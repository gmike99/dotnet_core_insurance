using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;

namespace Logic.Interfaces
{
    public interface IRiskDecisionLogic
    {
        Task<Boolean> AddRiskDecision(
            string decisionDescription,
            double evaluatedRiskDamage,
            double evaluatedDamageChance,
            double evaluatedInsuranceFee,
            int applicatinoId
        );

        Task<List<RiskDecision>> GetAllRiskDecisions();
    }
}
