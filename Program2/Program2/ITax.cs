using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program2
{
    //In case of interface, it by default considers as abstract methods
    //Initially like C# 4.8 or 5 versions we just need to use abstract methods, custom methods cannot be used. But in latest version it supports
    // C# does not support mutltiple inheritance
    internal interface ITax
    {
        double CalculateTax();   //By defauly public and abstract
        
    }
}
