using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSample
{
    public class Person
    {
        public Person()
        {
            Console.WriteLine("Person Class Created");
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Salary{ get; set; }
        public string Department{ get; set; }
    }
}
