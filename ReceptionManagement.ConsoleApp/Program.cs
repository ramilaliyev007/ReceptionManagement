using ReceptionManagement.Core;
using System.Configuration;

namespace ReceptionManagement.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var assemblyPath = ConfigurationManager.AppSettings["AssemblyPath"];
            var clientName = ConfigurationManager.AppSettings["ClientName"];

            IIntegrationAdapter integrationAdapter = IIntegrationAdapter.CreateInstance(assemblyPath, clientName);

            var student = new Student
            {
                FirstName = "Ramil",
                LastName = "Aliyev",
                Phone = "+994 94 994 94 94"
            };

            integrationAdapter.ProcessData(student);
        }
    }
}
