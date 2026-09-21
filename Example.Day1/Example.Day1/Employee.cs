using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.Day1
{
    internal class Employee
    {
        //class or instance variables
        //int employeeId =101;
        //string employeeName="Apeksha";
        //string emailId="apes@deloitte.com";
        //double salary=20000;

        int employeeId;
        string employeeName;
        string emailId;
        double salary;

        public void GetEmployeeDetail()
        {
            Console.WriteLine("Enter ID:");
            employeeId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name:");
            employeeName= Console.ReadLine();
            Console.WriteLine("Enter Email-ID:");
            emailId= Console.ReadLine();
            Console.WriteLine("Enter Salary:");
            salary=double.Parse(Console.ReadLine());

        }
        public void PrintEmployeeDetail()
        {
            Console.WriteLine("{0} {1} {2} {3}",employeeId,employeeName,emailId, salary);
        }
    }
}
