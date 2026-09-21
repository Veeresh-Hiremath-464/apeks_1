using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePrograms
{
    internal class Employee
    {
        int EmpId=101;
        string EmpName="Aopeksha";
        int Age=22;
        double Salary=10000;

        public void GetEmployeeDetails()
        {
            Console.WriteLine("Enter employeeId:");
            EmpId=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter employee name:");
            EmpName = Console.ReadLine();
            Console.WriteLine("Enter Age of Employee:");
            Age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Salary:");
            Salary = double.Parse(Console.ReadLine());

        }
        public void PrintEmployeeDetails()
        {
            Console.WriteLine("EmpId: {0} EmpName: {1} Age: {2} Salary: {3}", EmpId, EmpName, Age, Salary);
        }
    }
}
