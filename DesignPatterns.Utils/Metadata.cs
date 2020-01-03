using System;
using System.Reflection;
using System.Text;

namespace DesignPatterns.Utils
{
    public static class Metadata
    {
        public static string GetObjectDetails(string objectName, object obj)
        {
            StringBuilder result = new StringBuilder();

            if (!String.IsNullOrWhiteSpace(objectName))
            {
                result.AppendLine(objectName);
            }
                        
            Type           objectType      = obj.GetType();
            PropertyInfo[] classProperties = objectType.GetProperties();

            foreach (PropertyInfo classProperty in classProperties)
            {
                string classPropertyName   = classProperty.Name;
                object objectPropertyValue = classProperty.GetValue(obj, null);

                result.AppendLine($"\t\t{classPropertyName} = {objectPropertyValue.ToString()}");
            }
            result.AppendLine();

            return result.ToString();
        }
    }
}