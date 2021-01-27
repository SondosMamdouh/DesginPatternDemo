using System;
using System.Collections.Generic;
using System.Text;

namespace LazyLoadDemo
{
    public class Company
    {
        public string CompanyName;
    public Lazy<List<Employee>> Employees = null;
    public Company()
    {
        CompanyName = "MNC";
        Employees = new Lazy<List<Employee>>(() => getEmployees());
    }
    //Method to get Employees.  
    public List<Employee> getEmployees()
    {
        List<Employee> Employees = new List<Employee>
            {
                new Employee
                {
                    FirstName = "Sridhar", LastName = "Adusumilli"
                }, new Employee
                {
                    FirstName = "Manas", LastName = "Mohapatra"
                }
            };
        return Employees;
    }
}
public class Employee
{
    public string FirstName
    {
        get;
        set;
    }
    public string LastName
    {
        get;
        set;
    }
}
}
