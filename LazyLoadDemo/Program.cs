using System;
using System.Collections.Generic;

namespace LazyLoadDemo
{    
    class Program
    {
        static void Main(string[] args)
        {  
            //Lazy Init
            /*
            Company cmp = new Company();
            Console.WriteLine(cmp.CompanyName);
            foreach (var item in cmp.Employees.Value)  
            {
                Console.WriteLine(item.FirstName + " " + item.LastName);
            }
            Console.ReadLine();
            */
            //Virual Proxy
            /*
            int testOrderId = 123;
            var order = new OrderFactory().CreateFromId(testOrderId);
             order.PrintLabel();
            */

        }
    }
}
