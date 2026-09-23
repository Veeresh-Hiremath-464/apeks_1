using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQDemo
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string EmailId { get; set; }
        public string City { get; set; }
        public bool IsActive { get; set; }

        public List<Order> Orders { get; set;  }= new List<Order>();
        public List<Customer> ListCustomer { get; set; } = new List<Customer>();
        public void GetDetails()
        {
            //Customer c1 = new Customer()
            //{
            //    CustomerId = 1,
            //    CustomerName = "Rock",
            //    EmailId = "rock@g.c",
            //    City = "Banglore",
            //    IsActive = true
            //};

            ListCustomer = new List<Customer>()
            {
                new Customer()
            {
                CustomerId = 1,
                CustomerName = "Rock",
                EmailId = "rock@g.c",
                City = "Hubli",
                IsActive = true
            },
                 new Customer()
            {
                CustomerId = 2,
                CustomerName = "Sony",
                EmailId = "sony@g.c",
                City = "Mysore",
                IsActive = true
            },
                      new Customer()
            {
                CustomerId = 3,
                CustomerName = "mark",
                EmailId = "mark@g.c",
                City = "Banglore",
                IsActive = true
            },
                           new Customer()
            {
                CustomerId = 4,
                CustomerName = "david",
                EmailId = "david@g.c",
                City = "Banglore",
                IsActive = true
            },

            };

            var Query = ListCustomer.Where(c => c.City == "Banglore").Select(c => c);
            foreach(var item in Query)
            {
                Console.WriteLine("{0} {1} {2}",item.CustomerName,item.City,item.EmailId);
            }

            var GroupQuery = from c in ListCustomer
                             group c by c.City into groupCity
                             select new
                             {
                                 groupCity.Key,
                                 TotalCustomerCount = groupCity.Count(),
                                 Names = groupCity.Select(c => c.CustomerName)

                             };
            
            foreach(var item in GroupQuery)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine(item.TotalCustomerCount);

                Console.WriteLine("----------------------------");
                foreach(var items in item.Names)
                {
                    Console.WriteLine(items);
                }
            }
            
        }


    }
}
