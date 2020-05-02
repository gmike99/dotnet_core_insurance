using System;
using System.Threading.Tasks;
using DAL.Functions;

// TODO remove password string
// TODO carry out path string to config
namespace CLI
{
    public class Program
    {
        private const string DefaultFilePath = "C:\\Users\\hp\\Desktop\\data.csv";

        static async Task Main(string[] args)
        {
            if (args == null || args.Length == 0) return;
            var action = args[0];
            Console.WriteLine(action);
            switch (action)
            {
                case "generate" :
                    CsvGeneratorCli.CallGenerator(DefaultFilePath);
                    break;
                case "load" :
                   await CsvGeneratorCli.CallLoader(DefaultFilePath);
                   break;
                case "test":
                    var formFunc = new InsuranceFormFunctions();
                    await formFunc.AddInsuranceForm("veve", "verer", "aerbeb", 5, "berte");
                    break;
            }
        }
    }
}
