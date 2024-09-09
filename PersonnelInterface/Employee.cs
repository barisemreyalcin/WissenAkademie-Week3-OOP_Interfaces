﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelInterface
{
    public class Employee : IPerson
    {
        // Interface'den gelen ----
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
        public double Salary { get; set; }
        // Interface'den gelen ----

        // Buraya özel ----
        public int ManagerId { get; set; }
        // Buraya özel ----

        // Interface'den gelen ----
        public string GetInfo() // Farklı class'lar için farklı çıktı olabilir. Polymorphism ile ilişkili
        {
            // Buraya özel ----
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append($"Id: {Id}\n");
            stringBuilder.Append($"Full Name: {FirstName} {LastName}\n");
            stringBuilder.Append($"Department: {Department}\n");
            stringBuilder.Append($"Salary: {Salary}\n");
            stringBuilder.Append($"Reporting Manager Id: {ManagerId}\n");

            return stringBuilder.ToString();
            // Buraya özel ----
        }
        // Interface'den gelen ----

    }
}
