using System;
using System.Reflection;

namespace Adapter.ExternalLibraries
{
    public class ObjToTextLibrary
    {
        private readonly object _obj;

        public ObjToTextLibrary(object obj)
        {
            _obj = obj;
        }

        public string Convert()
        {
            string result = string.Empty;

            foreach (PropertyInfo property in _obj.GetType().GetProperties())
            {
                if (!property.CanRead) continue;

                result += property.Name + ": " + property.GetValue(_obj) + Environment.NewLine;
            }

            if (result.EndsWith(Environment.NewLine))
            {
                result = result.Substring(0, result.Length - Environment.NewLine.Length);
            }

            return result;
        }
    }
}