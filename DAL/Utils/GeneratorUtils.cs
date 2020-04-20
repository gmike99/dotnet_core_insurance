using System;

namespace DAL.Utils
{
    public static class GeneratorUtils
    {
        private const string Chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789abcdefghijklmnopqrstuvwxyz";
        
        public static string GetRandomString(int length)
        {
            var random = new Random();
            var result = new char[length];
            for (var i = 0; i < length; ++i)
            {
                result[i] = Chars[random.Next(Chars.Length)];
            }

            return result.ToString();
        }


        public static void GenerateDataForClass<TModelClass>()
        {
            var properties = typeof(TModelClass).GetProperties();

            foreach (var property in properties)
            {
                if (property is int)
                {
                    Console.WriteLine("Property is int");
                }
            }
        }
    }
}