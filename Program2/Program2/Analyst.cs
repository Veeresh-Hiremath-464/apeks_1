using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program2
{
    //Inheritance to access employee properties and methods
    internal class Analyst:Employee,ITax
    {
        public double ClientAllowance=5000;
        //double TaxPercentage = 0.10;

        //base ===> similar to super keyword we use in python, It is used to access base class method or constructor impleentation from derived class method
        public override double CalculateSalary()
        {
            return base.CalculateSalary()+ClientAllowance;
        }

        public override string GetReportingLocation()
        {
            return "Chennai";
        }
        public double CalculateTax()
        {
            return 0.10;
        }
    }
}
