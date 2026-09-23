using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_Project
{
    internal class Customer
    {
       // type "prop"
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }

        public double Payment { get; set; }

        //So in this case suppose if u have another class say Product, then if you try to add Product ArryList in this listCustomers you get error
        List<Customer> listCustomers = new   List< Customer > ();
        //ArrayList listCustomers;
        
        public void GetDetails()
        {
            List<Customer> listCustomers = new List<Customer>();
            Customer c1 = new Customer() { CustomerId = 101, CustomerName = "Apeksha", Payment = 100000 };
            Customer c2 = new Customer() { CustomerId = 102, CustomerName = "Bhagya", Payment = 20000 };
            Customer c3 = new Customer() { CustomerId = 103, CustomerName = "Neha", Payment = 3000 };
            Customer c4 = new Customer() { CustomerId = 104, CustomerName = "Apes", Payment = 1000 };

            listCustomers.Add(c1);
            listCustomers.Add(c2);
            listCustomers.Add(c3);
            listCustomers.Add(c4);

            var Query1 = from c in listCustomers where c.Payment > 10000 orderby c.CustomerName select c;

            var Query2 = from c in listCustomers where c.Payment > 10000 orderby c.CustomerName select new {c.CustomerName,c.Payment};//Anonymous type

            foreach (Customer val in Query1)
            {
                Console.WriteLine("{0} {1} {2}", val.CustomerId, val.CustomerName, val.Payment);
            }

            //var : bcz we are trying to access few columns
            foreach (var val in Query2)
            {
                Console.WriteLine("{0} {1}",val.CustomerName, val.Payment);
            }
        }
        public void StoreCoustomers()
        {
            //listCustomers = new ArrayList();
            Customer c1=new Customer() { CustomerId=101,CustomerName="Apeksha",Payment=100000};
            Customer c2=new Customer() { CustomerId = 102, CustomerName = "Bhagya", Payment = 10000 } ;
            Customer c3=new Customer() { CustomerId = 103, CustomerName = "Neha", Payment = 1000 };

            listCustomers.Add(c1);
            listCustomers.Add(c2);
            listCustomers.Add(c3);

        }

        // Search
        public void Search()
        {
            try
            {
                Console.WriteLine("Enter CustomerId:");
                int searchId = int.Parse(Console.ReadLine());

                for (int i = 0; i < listCustomers.Count; i++)
                {
                    if (listCustomers[i].CustomerId == searchId)
                    {
                        Console.WriteLine(listCustomers[i]);
                        return;
                    }
                }
                throw new NoSuchCustomerFoundException("No such customers avaliable");
            }
            catch (NoSuchCustomerFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }

        // Update customer
        public void Update()
        {
            try
            {
                Console.WriteLine("Enter CustomerId:");
                int searchId = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Updated CustomerName:");
                string newCustName = Console.ReadLine();

                Console.WriteLine("Enter Updated payment:");
                double newPayment = double.Parse(Console.ReadLine());

                for (int i = 0; i < listCustomers.Count; i++)
                {
                    if (listCustomers[i].CustomerId == searchId)
                    {
                        listCustomers[i].CustomerName = newCustName;
                        listCustomers[i].Payment = newPayment;
                        Console.WriteLine(listCustomers[i]);
                        return;
                    }
                }
                throw new NoSuchCustomerFoundException("No such customers avaliable");
            }
            catch (NoSuchCustomerFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        // Remove customer
        public void RemoveCust()
        {
            try
            {
                Console.WriteLine("Enter CustomerId:");
                int searchId = int.Parse(Console.ReadLine());

                for (int i = 0; i < listCustomers.Count; i++)
                {
                    if (listCustomers[i].CustomerId == searchId)
                    {
                        listCustomers.Remove(listCustomers[i]);
                        return;
                    }
                }
                throw new NoSuchCustomerFoundException("No such customers avaliable");
            }
            catch (NoSuchCustomerFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        // Insert customer
        public void InsertCust()
        {
            try
            {
                Console.WriteLine("Enter CustomerId:");
                int searchId = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Updated CustomerName:");
                string CustName = Console.ReadLine();

                Console.WriteLine("Enter Updated payment:");
                double payment = double.Parse(Console.ReadLine());

                Customer c = new Customer() {CustomerId=searchId,CustomerName=CustName,Payment=payment};
                listCustomers.Add(c);
                throw new NoSuchCustomerFoundException("No such customers avaliable");
            }
            catch (NoSuchCustomerFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }


        public void PrintCustomers()
        {
            foreach(Customer val in listCustomers)
            {
                Console.WriteLine("{0} {1} {2}",val.CustomerId,val.CustomerName,val.Payment);
            }
        }
    }
}
