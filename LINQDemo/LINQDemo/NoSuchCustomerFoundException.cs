using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQDemo
{
    internal class NoSuchCustomerFoundException
    {
        //This says we need to replace the default exception message with what mentioned in code
        //When you are creating own exception class i want to replace with my own msg property
        //public NoSuchCustomerFoundException(string message) : base(message)
        //{

        //}

        //public string ErrorMessage {  get; set; }

        //public NoSuchCustomerFoundException()
        //{
        //    ErrorMessage = "No Such Customer Avalaible, Please Check";
        //}
    }
}
