using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;
using DAL.Functions;
using Logic.Interfaces;
using DAL.Interfaces;

namespace Logic.Functions
{
    public class RiskDecisionLogic : IRiskDecisionLogic
    {
        private readonly IRiskDecision _riskDecision;

        public RiskDecisionLogic()
        {
            _riskDecision = new RiskDecisionFunctions();
        }

        public async Task<Boolean> AddRiskDecision(string decisionDescription, double evaluatedRiskDamage, double evaluatedDamageChance,
                                                   double evaluatedInsuranceFee, int applicationId)
        {
            try
            {
                var result = await _riskDecision.AddRiskDecision(decisionDescription, evaluatedRiskDamage, evaluatedDamageChance,
                                                                 evaluatedInsuranceFee, applicationId);
                return result.Id > 0;
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
