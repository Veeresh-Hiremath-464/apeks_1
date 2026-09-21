using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Example.Day1
{ 
    internal class EmployeeDetail
    {
         //If value unintialised, in case of integer it will be zero, in case of string it will be null, char hold null, boolean will hold false
         //Reference objects will be holding null
        public int employeeId;
        public string employeeName;
        public string emailId;
        public double salary;

      public void PrintEmployeeDetail()
        {
            Console.WriteLine("{0} {1} {2} {3}",employeeId,employeeName,emailId, salary);
        }
        public void GetEmployeeDetail(int id,string name,string email,double salary)
        {
            //Console.WriteLine("Enter ID:");
            //employeeId = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Name:");
            //employeeName = Console.ReadLine();
            //Console.WriteLine("Enter Email-ID:");
            //emailId = Console.ReadLine();
            //Console.WriteLine("Enter Salary:");
            //salary = double.Parse(Console.ReadLine());
            Console.WriteLine("{0} {1} {2} {3}", id, name, email, salary);

        }

        //Employee object as a parameter

        public void GetEmployee(EmployeeDetail employee)
        {
            Console.WriteLine("{0} {1} {2} {3}", employee.employeeId, employee.employeeName, employee.emailId, employee.salary);
        }


        // move all employee details to program.cs
        public EmployeeDetail ReturnEmployee(EmployeeDetail employeeDetailObj)
        {
            //EmployeeDetail e = new EmployeeDetail();
            Console.WriteLine("Enter ID:");
            employeeDetailObj.employeeId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name:");
            employeeDetailObj.employeeName = Console.ReadLine();
            Console.WriteLine("Enter Email-ID:");
            employeeDetailObj.emailId = Console.ReadLine();
            Console.WriteLine("Enter Salary:");
            employeeDetailObj.salary = double.Parse(Console.ReadLine());
            //Console.WriteLine("{0} {1} {2} {3}", e.employeeId, e.employeeName, e.emailId, e.salary);
            return employeeDetailObj;
        }

    }
}
