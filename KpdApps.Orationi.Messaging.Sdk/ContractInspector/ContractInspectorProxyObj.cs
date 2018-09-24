using System;
using System.Reflection;
using KpdApps.Orationi.Messaging.Sdk.Attributes;

namespace KpdApps.Orationi.Messaging.Sdk.ContractInspector
{
    public class ContractInspectorProxyObj : MarshalByRefObject
    {
        public string RequestContract { get; private set; }
        public string ResponseContract { get; private set; }
        public bool IsError { get; private set; }
        public Exception Exception { get; private set; }
        public bool IsInspected { get; private set; }

        public void Inspect(AssemblyName assemblyRef, string className)
        {
            try
            {
                var assembly = Assembly.Load(assemblyRef);
                var pluginType = assembly.GetType(className);

                RequestContract =
                    ((ContractAttribute)pluginType.GetCustomAttribute(typeof(RequestContractInAttribute)))
                    ?.GetXsd(assembly);

                ResponseContract =
                    ((ContractAttribute)pluginType.GetCustomAttribute(typeof(ResponseContractOutAttribute)))
                    ?.GetXsd(assembly);
            }
            catch (Exception ex)
            {
                IsError = true;
                Exception = ex;
            }
            finally
            {
                IsInspected = true;
            }
        }
    }
}
