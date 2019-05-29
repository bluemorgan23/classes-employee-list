using System;

namespace employee_list
{
    class Program
    {
        static void Main(string[] args)
        {
            Company NSS = new Company(new DateTime(2011, 09, 27), "Nashville Software School");

            Employee Chris = new Employee("Chris", "Morgan", "Software Developer", new DateTime(2019, 02, 19));

            Employee Harry = new Employee("Harry", "Hart", "Credit Analyst", new DateTime(2019, 05, 09));

            Employee Han = new Employee("Han", "Mastrianni", "Hospitality and Customer Service", new DateTime(2019, 11, 21));

            NSS.AddEmployee(Chris);
            NSS.AddEmployee(Harry);
            NSS.AddEmployee(Han);

            Console.WriteLine(NSS.CoName);
            Console.WriteLine($"Founded in {NSS.DateFounded}.");
            NSS.ListEmployees();
        }
    }
}
