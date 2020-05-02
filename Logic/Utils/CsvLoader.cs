using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Logic.Functions;
using Logic.Interfaces;

namespace Logic.Utils
{
    public class CsvLoader
    {
        private readonly IApplicationLogic _applicationLogic;
        private readonly IInsuranceClientLogic _insuranceClientLogic;
        private readonly IInsuranceCompanyLogic _insuranceCompanyLogic;
        private readonly IInsuranceContractLogic _insuranceContractLogic;
        private readonly IInsuranceFormLogic _insuranceFormLogic;
        private readonly IRiskDecisionLogic _decisionLogic;

        public CsvLoader(
            IApplicationLogic applicationLogic,
            IInsuranceClientLogic client,
            IInsuranceCompanyLogic companyLogic,
            IInsuranceContractLogic contractLogic,
            IInsuranceFormLogic formLogic,
            IRiskDecisionLogic decisionLogic)
        {
            _insuranceClientLogic = client;
            _insuranceCompanyLogic = companyLogic;
            _insuranceContractLogic = contractLogic;
            _insuranceFormLogic = formLogic;
            _decisionLogic = decisionLogic;
            _applicationLogic = applicationLogic;
        }

        public CsvLoader()
        {
            _insuranceClientLogic = new InsuranceClientLogic();
            _insuranceCompanyLogic = new InsuranceCompanyLogic();
            _insuranceContractLogic = new InsuranceContractLogic();
            _insuranceFormLogic = new InsuranceFormLogic();
            _decisionLogic = new RiskDecisionLogic();
            _applicationLogic = new ApplicationLogic();
        }

        public async Task<Boolean> LoadCsv(string csvPath)
        {
            var csvText = File.ReadAllText(csvPath);
            var csvFileRecord = csvText.Split('\n');

            var applicationRecords = csvFileRecord.Take(150);
            var insuranceClientRecords = csvFileRecord.Skip(150).Take(150);
            var insuranceCompanyRecords = csvFileRecord.Skip(300).Take(150);
            var insuranceContractRecords = csvFileRecord.Skip(450).Take(150);
            var insuranceFormRecords = csvFileRecord.Skip(600).Take(150);
            var riskDecisionRecords = csvFileRecord.Skip(750).Take(150);

            foreach (var row in insuranceFormRecords)
            {
                if (string.IsNullOrEmpty(row)) continue;
                var cells = row.Split(',');
                await _insuranceFormLogic.AddInsuranceForm(cells[1], cells[1], cells[1],
                    int.Parse(cells[4]), cells[1]);
            }

            foreach (var row in insuranceCompanyRecords)
            {
                if (string.IsNullOrEmpty(row)) continue;
                var cells = row.Split(',');
                await _insuranceCompanyLogic.AddInsuranceCompany(cells[1], cells[1], int.Parse(cells[0]), cells[1]);
            }

            foreach (var row in insuranceClientRecords)
            {
                if (string.IsNullOrEmpty(row)) continue;
                var cells = row.Split(',');
                await _insuranceClientLogic.AddInsuranceClient(cells[1], cells[1], int.Parse(cells[0]),
                    cells[1], cells[1], cells[1], cells[1], cells[1]);
            }

            foreach (var row in applicationRecords)
            {
                if (string.IsNullOrEmpty(row)) continue;
                var cells = row.Split(',');
                await _applicationLogic.AddApplication(int.Parse(cells[0]), cells[1], cells[1], int.Parse(cells[0]));
            }

            foreach (var row in insuranceContractRecords)
            {
                if (string.IsNullOrEmpty(row)) continue;
                var cells = row.Split(',');
                await _insuranceContractLogic.AddInsuranceContract(cells[1], int.Parse(cells[0]), int.Parse(cells[0]));
            }

            foreach (var row in riskDecisionRecords)
            {
                if (string.IsNullOrEmpty(row)) continue;
                var cells = row.Split(',');
                await _decisionLogic.AddRiskDecision(cells[1], double.Parse(cells[0]),
                    double.Parse(cells[0]), double.Parse(cells[0]), int.Parse(cells[0]));
            }

            return true;
        }
    }
}