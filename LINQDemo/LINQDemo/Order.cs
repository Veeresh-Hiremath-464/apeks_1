using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQDemo
{
    public class Order
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public double MyProperty { get; set; }
        public DateTime OrderDate { get; set; }
        public string Status { get; set; }

    }
}
