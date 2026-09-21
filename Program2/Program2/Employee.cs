using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program2
{
    internal abstract class Employee
    {
        public int EmpId;
        public string Name;
        public string EmailId;
        public double MedicalInsurance=10000;

        public abstract string GetReportingLocation();

        //When you define function virtual, as by default 1st we go to implementation of base class methods, with virtual we are telling t implement derived class functions
        public virtual double CalculateSalary()
        {
            return MedicalInsurance;
        }

         //To test sealed functionality
        public virtual double GetSpecialAllowance()
        {
            return 3000;
        }

    }
}
