using System;

namespace employee_list
{
    class Employee {
        public Employee(string firstName, string lastName, string title, DateTime startDate){
            FirstName = firstName;
            LastName = lastName;
            Title = title;
            StartingDate = startDate;
        }

        public string FirstName {get; set;}
        public string LastName {get; set;}
        public string Title {get; set;}

        public DateTime StartingDate {get; set;}
    }
}