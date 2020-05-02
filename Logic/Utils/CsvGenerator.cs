using System.Collections;
using DAL.Functions;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using CsvHelper;


namespace Logic.Utils
{
    public static class CsvGenerator
    {
        public static void GenerateCsv(string filepath)
        {
            var objects = new List<object>();
            objects.AddRange(ApplicationFunctions.GenerateData());
            objects.AddRange(InsuranceClientFunctions.GenerateData());
            objects.AddRange(InsuranceCompanyFunctions.GenerateData());
            objects.AddRange(InsuranceContractFunctions.GenerateData());
            objects.AddRange(InsuranceFormFunctions.GenerateData());
            objects.AddRange(RiskDecisionFunctions.GenerateData());

            using var writer = new StreamWriter(filepath);
            using var csv = new CsvWriter(writer, CultureInfo.InvariantCulture);
            csv.WriteRecords((IEnumerable) objects);
        }
    }
}