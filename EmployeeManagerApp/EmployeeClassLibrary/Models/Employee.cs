using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeClassLibrary.Models
{
    public class Employee : Person
    {
        public decimal BaseSalary { get; set; }
        public bool HasCommission { get; set; }
        public decimal Commission { get; set; }
        public string JobTitle { get; set; }
        public string Department { get; set; }
        public DateTime Doh { get; set; }       
        public bool IsAdmin { get; set; }
        public string AdminUsername { get; set; }
        public string AdminPassword { get; set; }
        public bool IsActive { get; set; }
        public DateTime TerminationDate { get; set; }
        public TerminationReason ReasonForTermination { get; set; }
        public string TerminationDetails { get; set; }
        public string Headshot { get; set; }

        public Employee(){}

        public override string WriteToEmployeeFile()
        {
            return base.WriteToEmployeeFile() + $",{ BaseSalary },{ HasCommission },{ Commission },{ JobTitle },{ Department },{ Doh },{ IsAdmin },{ AdminUsername },{ AdminPassword },{ IsActive },{TerminationDate},{ReasonForTermination},{TerminationDetails},{Headshot}";
        }
    }
}