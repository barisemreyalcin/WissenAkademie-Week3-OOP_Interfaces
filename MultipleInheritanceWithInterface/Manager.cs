﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInheritanceWithInterface
{
    public class Manager : IPerson, IEmployee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public int Id { get; set; }
        public int WorkingHours { get; set; }
    }
}
