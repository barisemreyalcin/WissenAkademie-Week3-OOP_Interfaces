using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSample
{
    public class Employee : Person
    {
        public Employee() {
            Console.WriteLine("Employee Class Created");
        }

        public int ManagerId { get; set; }

        public string GetEmployeeInfo() { 
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append($"Id: {Id}\n");
            stringBuilder.Append($"Full Name: {FirstName} {LastName}\n");
            stringBuilder.Append($"Department: {Department}\n");
            stringBuilder.Append($"Salary: {Salary}\n");
            stringBuilder.Append($"Reporting Manager Id: {ManagerId}\n");

            return stringBuilder.ToString();
        } 
    }
}
