using System;
using System.Threading.Tasks;
using Logic.Utils;


namespace CLI
{
    public class CsvGeneratorCli
    {
        public static void CallGenerator(string filepath)
        {
            CsvGenerator.GenerateCsv(filepath);
        }

        public static async Task<Boolean> CallLoader(string filepath)
        {
            var csvLoader = new CsvLoader();
            return await csvLoader.LoadCsv(filepath);
        }
    }
}