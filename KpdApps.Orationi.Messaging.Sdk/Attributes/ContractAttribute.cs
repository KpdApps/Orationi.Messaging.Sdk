using System;
using System.IO;
using System.Reflection;
using System.Text;

namespace KpdApps.Orationi.Messaging.Sdk.Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    public class ContractAttribute : Attribute
    {
        public ContractAttribute(string uri)
        {
            Uri = uri;
        }

        /// <summary>
        /// Путь к ресурсу содержащему схему Xsd
        /// </summary>
        public string Uri { get; }

        /// <summary>
        /// Получение схемы Xsd из вложенных ресурсов предоставленной сборки
        /// </summary>
        /// <param name="assembly"></param>
        /// <returns></returns>
        public string GetXsd(Assembly assembly)
        {
            var resourceStream = assembly.GetManifestResourceStream(Uri);
            if (resourceStream is null)
            {
                // Такое случается в случае:
                // 1. когда в ресурсах текущей сборки нет искомого контракта, т.е. он вместе с базовым классом находится в другой сборке
                // 2. указан некорректный Uri
                return null;
            }

            using (var streamReader = new StreamReader(resourceStream, Encoding.UTF8))
            {
                return streamReader.ReadToEnd();
            }
        }
    }
}
