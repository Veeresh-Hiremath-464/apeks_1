using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program2
{
    internal class SalesPerson:Employee,ITax
    {
        public double SalesIncentive=5000;
        public int SalesOrder;

        public override double CalculateSalary()    
        {
            Console.WriteLine("Enter sales order count:");
            SalesOrder = int.Parse(Console.ReadLine());
            return base.CalculateSalary() + (SalesIncentive+ SalesOrder);
        }

        public override string GetReportingLocation()
        {
            return "Banglore";
        }

      
        public double CalculateTax()
        {
            return 0.15;
        }

        public sealed override double GetSpecialAllowance()
        {
            return base.GetSpecialAllowance();
        }
    }
}
