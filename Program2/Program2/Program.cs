/*
 *         Difference between virtual and abstract methods
 *         ------------------------------------------------
 *      calculateSalary(){} virtual function -> Provide default implementationin base class, that is overridden in the derived class
 *      calculateTax() abstract function : compulsary to use in both derived class, here no function implementation, Derived class has flexibility to provide their own implementations for the base class method(abstract class)
 *      -> 2 interface methods can be used in single class
 *      -> Abstract method shld be written only in abstract class, or else it shld be interface
 *      -> As C# doesn't support multiple inheritance, when inheriting 1st use base class then interface
 *      -> Console is static class, WriteLine is static method
 *      ->Sealed class and method, used on virtual functions, sealed will be applied only for overridden methods not for virtual functions
 *      
 *      
 *      Static data members
 *      -> Static class
 *      -> Static methods
 *      -> Static variables
 *      Usecases: Utility functions, like calculations, configuration setting where you do this for whole applications, conversion or mathematical functions, working with log files(static class)-> check how to use static class to log the exception to the file using C# console->Product inventory application
 *      
 *      
 *      -> Exception handling with respect to C# : try(code logic), catch(if mistake in try block), throw(rethrow errors to next level) and finally
 *      *think exception in 2 ways developes(log file) and end users customised error messages
 *      *presentation layer: code related to frontend(html, js, css, or js framework)
 *      *business logic layer
 *      * data access layer(data access logic, unable to connect to DB bcz wrong DB name, store exception to log file)
 *      *go through inbuild exceptions in C#
 *      
 *      -> exception properties: message, source, taretsize, stacktrace
 *  
 *      
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //In case of method overriding
            //Employee employee = new Analyst();
            Analyst employee = new Analyst();
            Console.WriteLine("Analyst Salary:{0}",employee.CalculateSalary()-employee.CalculateTax());
            Console.WriteLine(employee.GetReportingLocation());

            //employee = new SalesPerson();
            SalesPerson salesPerson = new SalesPerson();
            Console.WriteLine("SalesPerson Salary:{0}", salesPerson.CalculateSalary()- salesPerson.CalculateTax());
            Console.WriteLine(salesPerson.GetReportingLocation());
        }
    }
}
