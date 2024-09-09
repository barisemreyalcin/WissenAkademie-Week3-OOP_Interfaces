using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInheritanceWithInterface
{
    // Hem IPerson hem IEmployee özelliklerini taşıyacak
    public class Personnel : IPerson, IEmployee
    {
        // IPerson
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        // IEmployee
        public int Id { get; set; }
        public int WorkingHours { get; set; }
    }
}
