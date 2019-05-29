using System;
using System.Collections.Generic;

namespace employee_list
{
    class Company
    {
        public Company(DateTime dateFounded, string coName)
        {
            DateFounded = dateFounded;
            CoName = coName;
        }
        public DateTime DateFounded {get; set;}
        public string CoName {get; set;}
        public List<Employee> EmployeeList = new List<Employee>();

        public void ListEmployees()
        {
            Console.WriteLine($"List of Employees at {CoName}");
            Console.WriteLine("- - - - - - - - -");
            foreach(Employee employee in EmployeeList)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName}");
                Console.WriteLine($"Role: {employee.Title}");
                Console.WriteLine($"Starting Date: {employee.StartingDate}");
                Console.WriteLine(" ");
            }
        }

        public void AddEmployee(Employee employee)
        {
            EmployeeList.Add(employee);
        }
    }
}