using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePrograms
{
    internal class EmployeeDetail
    {
        public int EmpId = 101;
        public string EmpName = "Aopeksha";
        public int Age = 22;
        public double Salary = 10000;

        public void GetEmployeeDetails(EmployeeDetail empObj)
        {
            Console.WriteLine("{0} {1} {2} {3}", empObj.EmpId, empObj.EmpName, empObj.Age, empObj.Salary);
        }

        public EmployeeDetail ReturnEmployeeDetail(EmployeeDetail obj)
        {
            Console.WriteLine("Enter employeeId:");
            obj.EmpId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter employee name:");
            obj.EmpName = Console.ReadLine();
            Console.WriteLine("Enter Age of Employee:");
            obj.Age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Salary:");
            obj.Salary = double.Parse(Console.ReadLine());
            return obj;
        }
    }
}
