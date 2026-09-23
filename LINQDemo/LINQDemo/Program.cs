using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LINQDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int val;
            CustomerService cust = new CustomerService();

            do {
                Console.WriteLine("1. Create Customers");
                Console.WriteLine("2. Update Customers");
                Console.WriteLine("3. Delete Customers");
                Console.WriteLine("4. Print Customers");
                Console.WriteLine("5. Add orders to Customers");
                Console.WriteLine("6.Display Orders");
                Console.WriteLine("7. Exit");

                Console.WriteLine("Enter your choice:");
                val = int.Parse(Console.ReadLine());

                
                Customer cust1 = new Customer();
                cust1.CustomerName = "Apeksha";
                cust1.CustomerId = 101;
                cust1.EmailId = "apes@g.c";
                cust1.City = "Dharwad";

                Customer cust2 = new Customer();
                cust2.CustomerName = "Sony";
                cust2.CustomerId = 102;
                cust2.EmailId = "sony@g.c";
                cust2.City = "Hubli";

                switch (val) {
                    case 1:
                        {
                            Console.WriteLine("=========Create Customer===============");
              
                            cust.CreateCustomer(cust1);
                            cust.CreateCustomer(cust2);
                            cust.PrintCustomers();
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("=========Update Customer===============");
                            Customer custUpdate = new Customer();
                            custUpdate.CustomerName = "rocky";
                            custUpdate.CustomerId = 101;
                            custUpdate.EmailId = "rocky@g.c";
                            custUpdate.City = "mumbai";

                            cust.UpdateCustomer(custUpdate);
                            cust.PrintCustomers();
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("=========Delete Customer===============");
                            cust.DeleteCustomer(101);
                            cust.PrintCustomers();
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("=========Display Customer===============");
                            cust.PrintCustomers();
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("=========Add orders to Customer===============");
                            cust.AddOrders(101, new Order
                            {
                                OrderId = 1001,
                                MyProperty = 2499.50,
                                OrderDate = new DateTime(2026, 9, 23),
                                Status = "Placed"
                            });

                            cust.AddOrders(101, new Order
                            {
                                OrderId = 1002,
                                MyProperty = 799.99,
                                OrderDate = new DateTime(2026, 9, 23),
                                Status = "Shipped"
                            });

                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine("=========Display Order Details===============");
                            cust.DisplayOrder(101);
                            break;
                        }
                    default:
                        //Console.WriteLine("Enter valid choice");
                        break;
            }

      }while(val!=7);

            Customer custObj = new Customer();
            custObj.GetDetails();

        }
    }
}
