using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInheritanceWithInterface
{
    public class Robot : IEmployee
    {
        public int Id { get; set; }
        public int WorkingHours { get; set; }
    }
}
