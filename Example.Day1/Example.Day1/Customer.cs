using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Example.Day1
{
    internal class Customer
    { 
        int CustomerId;
        string CustomerName;
        string EmailId;

        Customer[] CustomersArray;  //Array Declaration

        public void StoreCustomers()
        {
            Console.WriteLine("Count");
            int count = int.Parse(Console.ReadLine());
            CustomersArray = new Customer[count];   //Arraay Initialization with Size

            for(int i=0;i<count;i++)
            {
                CustomersArray[i] = new Customer(); //Store objects to Customer array

                Console.WriteLine("ID");
                CustomersArray[i].CustomerId = int.Parse(Console.ReadLine());

                Console.WriteLine("Name");
                CustomersArray[i].CustomerName = Console.ReadLine();

                Console.WriteLine("Email-ID");
                CustomersArray[i].EmailId = Console.ReadLine();

            }
       }

        public void searchCustomerById(int id)
        {
            for(int i=0;i< CustomersArray.Length; i++)
            {
                if (CustomersArray[i].CustomerId==id)
                {
                    Console.WriteLine("Customer Found");
                    Console.WriteLine("{0} {1} {2}", CustomersArray[i].CustomerId, CustomersArray[i].CustomerName, CustomersArray[i].EmailId);
                    return;

                }
   
            }
            Console.WriteLine("Customer you are trying to find is not found in the array");
        }

        public void searchCustomerByName(string name)
        {
            for (int i = 0; i < CustomersArray.Length; i++)
            {
                if (CustomersArray[i].CustomerName == name)
                {
                    Console.WriteLine("Customer Found");
                    Console.WriteLine("{0} {1} {2}", CustomersArray[i].CustomerId, CustomersArray[i].CustomerName, CustomersArray[i].EmailId);
                    return;
                }

            }
            Console.WriteLine("Customer you are trying to find is not found in the array");
        }


        public void updateCustomer(int id,string name,string email)
        {
            for (int i = 0; i < CustomersArray.Length; i++)
            {
                if (CustomersArray[i].CustomerId == id)
                {
                    Console.WriteLine("Customer Found to Update, And the updated details are:");
                    CustomersArray[i].CustomerName = name;
                    CustomersArray[i].EmailId = email;
                    return;

                }

            }
            Console.WriteLine("Customer you are trying to find is not found in the array to update");
        }


        public void PrintCustomers()
        {
            for(int i=0;i<CustomersArray.Length;i++)
            {
                Console.WriteLine("{0} {1} {2}", CustomersArray[i].CustomerId, CustomersArray[i].CustomerName, CustomersArray[i].EmailId);
            }
        }

    }
}
