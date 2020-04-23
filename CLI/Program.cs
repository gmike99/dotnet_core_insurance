using System;

namespace CLI
{
    public class Program
    {
        private const string DefaultFilePath = "C:\\Users\\hp\\Desktop\\data.csv";
        
        static void Main(string[] args)
        {
            if (args == null || args.Length == 0) return;
            var action = args[0];
            Console.WriteLine(action);
            switch (action)
            {
                case "generate" :
                    CsvGeneratorCli.CallGenerator(DefaultFilePath);
                    break;
            }
        }
    }
}
