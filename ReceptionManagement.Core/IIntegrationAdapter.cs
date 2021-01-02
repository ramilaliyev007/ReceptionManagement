using System;
using System.Reflection;

namespace ReceptionManagement.Core
{
    public interface IIntegrationAdapter
    {
        void ProcessData(Student student);

        static IIntegrationAdapter CreateInstance(string assemblyPath, string clientName)
        {
            var assembly = Assembly.LoadFile(assemblyPath);

            //For example: ReceptionManagement.ClientA.IntegrationAdapterClientA
            var typeFullName = $"ReceptionManagement.{clientName}.IntegrationAdapter{clientName}";

            var integrationAdapterType = assembly.GetType(typeFullName);

            var instance = Activator.CreateInstance(integrationAdapterType) as IIntegrationAdapter;

            return instance;
        }
    }
}
