using System;

namespace DAL.Utils
{
    public static class GeneratorUtils
    {
        private const string Chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789abcdefghijklmnopqrstuvwxyz";
        private const int DefaultStringLength = 12;

        private static string GetRandomString(int length)
        {
            var random = new Random();
            var result = new char[length];
            for (var i = 0; i < length; ++i)
            {
                result[i] = Chars[random.Next(Chars.Length)];
            }

            return new string(result);
        }


        public static TModelClass GenerateDataForClass<TModelClass>() where TModelClass : new()
        {
            var model = new TModelClass();
            var properties = typeof(TModelClass).GetProperties();

            foreach (var property in properties)
            {
                if (property.PropertyType == typeof(Int64))
                {
                    property.SetValue(model, 1, null);
                }
                else if (property.PropertyType == typeof(String))
                {
                    var randomString = GetRandomString(DefaultStringLength);
                    property.SetValue(model, randomString, null);
                }
            }

            return model;
        }
    }
}