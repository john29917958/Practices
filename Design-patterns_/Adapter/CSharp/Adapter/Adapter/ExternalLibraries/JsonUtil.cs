using System.Collections.Generic;
using System.Reflection;

namespace Adapter.ExternalLibraries
{
    public class JsonUtil
    {
        public string Serialize(object obj)
        {
            string result = "{";
            List<string> properties = new List<string>();

            foreach (PropertyInfo property in obj.GetType().GetProperties())
            {
                if (!property.CanRead) continue;

                string propertyStr = string.Empty;

                propertyStr += '"' + property.Name + "\":";

                object value = property.GetValue(obj);

                if (IsNumeric(value))
                {
                    propertyStr += value.ToString();
                }
                else
                {
                    propertyStr += '"' + value.ToString() + '"';
                }

                properties.Add(propertyStr);
            }

            result += string.Join(",", properties) + "}";

            return result;
        }

        private static bool IsNumeric(object value)
        {
            return value is sbyte
                   || value is byte
                   || value is short
                   || value is ushort
                   || value is int
                   || value is uint
                   || value is long
                   || value is ulong
                   || value is float
                   || value is double
                   || value is decimal;
        }
    }
}