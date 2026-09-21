using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Employee employeeObj = new Employee();
            //employeeObj.GetEmployeeDetails();
            //employeeObj.PrintEmployeeDetails();

            //Method with parameters
            //------------------------
            //EmployeeDetail empDetailObj =new EmployeeDetail();
            //Console.WriteLine("Enter employeeId:");
            //empDetailObj.EmpId = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter employee name:");
            //empDetailObj.EmpName = Console.ReadLine();
            //Console.WriteLine("Enter Age of Employee:");
            //empDetailObj.Age = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Salary:");
            //empDetailObj.Salary = double.Parse(Console.ReadLine());
            //empDetailObj.GetEmployeeDetails(empDetailObj);

            //Method with Return type
            //-----------------------
            //EmployeeDetail empDetailObj = new EmployeeDetail();
            //EmployeeDetail E1=new EmployeeDetail();
            //E1=empDetailObj.ReturnEmployeeDetail(empDetailObj);
            //empDetailObj.GetEmployeeDetails(E1);


            //TypeConversion 
            //---------------
            //TypeConversion typeObj = new TypeConversion();
            //typeObj.ImplicitConversion();
            //typeObj.ExplicitConversion();

            //Single dimensional array
            //----------------------
            //ArrayTypes arrayObj = new ArrayTypes();
            //arrayObj.StoreValues();
            //arrayObj.Print();

            //Multidimensional array
            //-------------------------
            //arrayObj.StoreMatrix();
            //arrayObj.PrintMatrix();

            // Jagged array
            //--------------
            JaggedArray jaggedObj = new JaggedArray();
            jaggedObj.Jagged();


            //Array of objects
            //-----------------
            StudentArrayOfObjects studentObj = new StudentArrayOfObjects();
            studentObj.StoreStudent();
            studentObj.print();



        }
    }
}
