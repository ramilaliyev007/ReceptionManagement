using ReceptionManagement.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReceptionManagement.ClientB
{
    public class IntegrationAdapterClientB : IIntegrationAdapter
    {
        public void ProcessData(Student student)
        {
            Console.WriteLine("Student's data process starting for ClientB");

            Console.WriteLine($"{nameof(student.FirstName)} = {student.FirstName}");

            //Burada LastName və Phone process olunmur

            Console.WriteLine("Student's data process ending for ClientB");
        }
    }
}
