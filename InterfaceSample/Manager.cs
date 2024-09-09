using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSample
{
    public class Manager : Person
    {
        public Manager() {
            Console.WriteLine("Manager Class Created");
        }

        public int StaffCount { get; set; }

        public string getManagerInfo() {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append($"Id: {Id}\n");
            stringBuilder.Append($"Full Name: {FirstName} {LastName}\n");
            stringBuilder.Append($"Department: {Department}\n");
            stringBuilder.Append($"Salary: {Salary}\n");
            stringBuilder.Append($"Staff Count: {StaffCount}\n");

            return stringBuilder.ToString();
        }
    }
}
