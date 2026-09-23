using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Day3_Project
{
  // It is inherited from the super class exception
    internal class NoSuchCustomerFoundException:Exception
    {

        // for creating constructor : ctor press tab
        //parameterised constructor
        public NoSuchCustomerFoundException(string message):base(message)
        {
            
        }
    }
}
