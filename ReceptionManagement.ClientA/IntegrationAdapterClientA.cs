using ReceptionManagement.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReceptionManagement.ClientA
{
    public class IntegrationAdapterClientA : IIntegrationAdapter
    {
        public void ProcessData(Student student)
        {
            Console.WriteLine("Student's data process starting for ClientA");

            Console.WriteLine($"{nameof(student.FirstName)} = {student.FirstName}");
            Console.WriteLine($"{nameof(student.LastName)} = {student.LastName}");
            Console.WriteLine($"{nameof(student.Phone)} = {student.Phone}");

            Console.WriteLine("Student's data process ending for ClientA");
        }
    }
}
