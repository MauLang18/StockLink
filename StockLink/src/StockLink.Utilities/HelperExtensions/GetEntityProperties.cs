﻿using System.Reflection;

namespace StockLink.Utilities.HelperExtensions
{
    public static class GetEntityProperties
    {
        public static Dictionary<string, object> GetPropertiesWithValues<T>(this T entity)
        {
            PropertyInfo[] properties = typeof(T).GetProperties();
            var entityParams = new Dictionary<string, object>();

            foreach (PropertyInfo property in properties)
            {
                object value = property.GetValue(entity, null)!;

                if (value != null)
                {
                    entityParams[property.Name] = value;
                }
            }

            return entityParams;
        }
    }
}
