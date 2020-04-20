using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;
using Logic.Interfaces;
using DAL.Interfaces;

namespace Logic.Functions
{
    public class RiskDecisionLogic : IRiskDecisionLogic
    {
        private readonly IRiskDecision _riskDecision;

        public async Task<Boolean> AddRiskDecision(string decisionDescription, double evaluatedRiskDamage, double evaluatedDamageChance,
                                                   double evaluatedInsuranceFee, int applicationId)
        {
            try
            {
                var result = await _riskDecision.AddRiskDecision(decisionDescription, evaluatedRiskDamage, evaluatedDamageChance,
                                                                 evaluatedInsuranceFee, applicationId);
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

        public async Task<List<RiskDecision>> GetAllRiskDecisions()
        {
            List<RiskDecision> riskDecisions = await _riskDecision.GetAllRiskDecisions();
            return riskDecisions;
        }
    }
}
