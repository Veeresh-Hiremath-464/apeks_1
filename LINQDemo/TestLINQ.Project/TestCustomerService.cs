//using System.Collections.Generic;
using LINQDemo;

namespace TestLINQ.Project
{

    public class TestCustomerService
    {
        CustomerService customerServiceObj;

        [SetUp]
        public void Setup()
        {
            customerServiceObj = new CustomerService();
            customerServiceObj.CustomerList = new List<Customer>();
        }

        [Test]

        public void TestCreateCustomer()
        {
            Customer customer = new Customer() { CustomerId = 101, CustomerName = "Sony", EmailId = "sony@g.c", City = "Banglore", IsActive = true };
            customerServiceObj.CustomerList.Add(customer);
            Assert.That(customerServiceObj.CustomerList[0].CustomerId, Is.EqualTo(101));
            Assert.That(customerServiceObj.CustomerList[0].CustomerName, Is.EqualTo("Sony"));
            Assert.Pass();
        }

        [Test]
        public void TestUpdateCustomer()
        {
            Customer customer = new Customer() { CustomerId = 101, CustomerName = "Sony", EmailId = "sony@g.c", City = "Banglore", IsActive = true };
            
            customerServiceObj.CreateCustomer(customer);

            Customer updateCustomerObj = new Customer() { CustomerId = 101, CustomerName = "Apeksha", EmailId = "apeksha@g.c", City = "Hubli", IsActive = true };
       
            customerServiceObj.UpdateCustomer(updateCustomerObj);

            Assert.That(customerServiceObj.CustomerList[0].CustomerId, Is.EqualTo(101));
            Assert.That(customerServiceObj.CustomerList[0].CustomerName, Is.EqualTo("Apeksha"));
            Assert.That(customerServiceObj.CustomerList[0].EmailId, Is.EqualTo("apeksha@g.c"));
            Assert.That(customerServiceObj.CustomerList[0].City, Is.EqualTo("Hubli"));
        }
    }
}
