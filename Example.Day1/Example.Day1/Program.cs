using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.Day1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //console is a class and WriteLine is a static method
            //Console.WriteLine("Welcome to C# Learning");

            // ClassName ObjectName=new ClassName()
            // Call Method --> ObjectName.MethodName()


            //Employee employeeObj = new Employee();
            //employeeObj.GetEmployeeDetail();
            //employeeObj.PrintEmployeeDetail();


            EmployeeDetail employeeDetailObj = new EmployeeDetail();
            //Console.WriteLine("Enter ID:");
            //employeeDetailObj.employeeId = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Name:");
            //employeeDetailObj.employeeName = Console.ReadLine();
            //Console.WriteLine("Enter Email-ID:");
            //employeeDetailObj.emailId = Console.ReadLine();
            //Console.WriteLine("Enter Salary:");
            //employeeDetailObj.salary = double.Parse(Console.ReadLine());
            //employeeDetailObj.GetEmployeeDetail(employeeDetailObj.employeeId, employeeDetailObj.employeeName, employeeDetailObj.emailId, employeeDetailObj.salary);
            //employeeDetailObj.GetEmployee(employeeDetailObj);

            //EmployeeDetail E1 = new EmployeeDetail();

            employeeDetailObj.ReturnEmployee(employeeDetailObj);

            employeeDetailObj.GetEmployee(employeeDetailObj);

            Demo demoObj = new Demo();
            demoObj.TypeConversion();
            demoObj.ConversionDemo();

            ArrayDemo arrayObj = new ArrayDemo();
            arrayObj.StoreNumbers();
            arrayObj.printNumbers();
            arrayObj.StoreMatrix();
            arrayObj.PrintMatrix();

            Customer custObj = new Customer();

            int value;
            do
            {
                Console.WriteLine("\n--- Customer Management Menu ---");
                Console.WriteLine("1. Store Customers");
                Console.WriteLine("2. Display Customer Details");
                Console.WriteLine("3. Search Customer by ID");
                Console.WriteLine("4. Search Customer by Name");
                Console.WriteLine("5. Update Customer Details");
                Console.WriteLine("6. Exit Application");
                Console.Write("\nSelect an operation (1-6): ");

                //Switch case
                Console.WriteLine("Ask the user to perform which operation:");
                value = int.Parse(Console.ReadLine());

                switch (value)
                {
                    case 1:
                        {
                            Console.WriteLine("Store Customers:");
                            custObj.StoreCustomers();
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Display Customer Details");
                            custObj.PrintCustomers();
                    
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Search Customers by ID:");
                            Console.WriteLine("Enter the CustomerId you want to search:");
                            int id = int.Parse(Console.ReadLine());
                            custObj.searchCustomerById(id);
                           
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Search Customers by name:");
                            Console.WriteLine("Enter the CustomerName you want to search:");
                            string name = Console.ReadLine();
                            custObj.searchCustomerByName(name);
                            
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("Update Customers of specific Id:");
                            Console.WriteLine("Enter the CustomerId you want to update the details name,email-id:");
                            int id = int.Parse(Console.ReadLine());
                            custObj.updateCustomer(id, "Apeksha", "apekshab@deloitte.com");
                            custObj.PrintCustomers();
                           
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("No operation to perform");
                            break;
                        }


                }
            } while (value != 6);


            JaggedArray jaggedObj = new JaggedArray();
            jaggedObj.DisplayJaggedArray();

            }
        }
    }
