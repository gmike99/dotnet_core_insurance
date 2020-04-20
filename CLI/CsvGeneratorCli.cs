using Logic.Utils;


namespace CLI
{
    public class CsvGeneratorCli
    {
        public static void CallGenerator(string filepath)
        {
            CsvGenerator.GenerateCsv(filepath);
        }
    }
}