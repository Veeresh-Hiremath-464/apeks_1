/*
 * Methods in LINQ
 * - SingleOrDefault() -> search for particular element or object particular collection, If condition is staisfied it wil, return object, If object is not found it returns null value
 *      *Advisible to use this if the condition is primary key
 * - Single() -> search for particular element or object particular collection, If condition is staisfied it wil, return object, If object is not found it will throw an exception
 * - FirstOrDefault -> search for particular element or object particular collection, If condition is staisfied it wil, return first occurence of an object, If object is not found it returns null value
 * - First() -> search for particular element or object particular collection, If condition is staisfied it wil,return first occurence of an object, If object is not found it will throw exception
 * */

using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQDemo
{
    //When you make the class internal, you can access class anywhere inside the same project
   public class CustomerService
    {
        public List<Customer> CustomerList { get; set; }= new List<Customer>();

        //How will you know that customer created successfullty: check of count of list as you add
        public void CreateCustomer(Customer customer)
        {
            CustomerList.Add(customer);
        }

        // Here to check if it is updated: Chceck if customer=customerUpdateObj
        public void UpdateCustomer(Customer customer)
        {
     
                //Object which i am updating from what i have passed
                var customerUpdateObj = (from c in CustomerList where c.CustomerId == customer.CustomerId select c).SingleOrDefault();

            var Query = CustomerList.Where(c => c.CustomerId == customer.CustomerId).Select(c=>c).SingleOrDefault();
            //if (customerUpdateObj == null)
             //{
                 //throw new NoSuchCustomerFoundException("No Such Customer Avalaible, Please Check");
                //Create NoSuchCustomerFoundException --> "No Such Customer Avalaible, Please Check"
             //}

            customerUpdateObj.CustomerName = customer.CustomerName;
            customerUpdateObj.EmailId = customer.EmailId;
            customerUpdateObj.City= customer.City;

        }

        // check for th count
        public string DeleteCustomer(int id) {
            var customerDeleteObj=(from c in CustomerList where c.CustomerId==id select c).SingleOrDefault();
            
            string status = string.Empty; //local variables no default value-- We must initilize before using them
            bool result= CustomerList.Remove(customerDeleteObj);
            if (result == true)
            {
                status = "Customer Deleted";
            }
            else
            {
                status = "Customer Not Found";
            }
            return status;
        }

        public void PrintCustomers()
        {
            foreach(Customer item in CustomerList)
            {
                Console.WriteLine("{0} {1} {2} {3}", item.CustomerId, item.CustomerName, item.EmailId, item.City);
            }
        }


        //==========================ORDERS========================
        public void AddOrders(int id,Order o)
        {
            Customer customer = CustomerList.SingleOrDefault(c => c.CustomerId == id);

            if (customer == null)
            {
                Console.WriteLine("Customer not found.");
                return;
            }

            o.CustomerId = id;
            customer.Orders.Add(o);

        }

        public void DisplayOrder(int id)
        {
            Customer customer = CustomerList.SingleOrDefault(c => c.CustomerId == id);

            if (customer == null)
            {
                Console.WriteLine("Customer not found.");
                return;
            }

            foreach (Order item in customer.Orders)
            {
                Console.WriteLine("{0} {1} {2} {3}",item.OrderId,item.MyProperty,item.OrderDate,item.Status);
            }
        }
    }
}
