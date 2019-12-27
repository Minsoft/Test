using System;
using System.Collections.Generic;

namespace TestConsoleApp
{
    public delegate bool IsPromotable(Employee employee);

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Experience { get; set; }
        public int Salary { get; set; }

        public static void PromoteEmployee(List<Employee> employees, IsPromotable isPromotable)
        {
            foreach(var emp in employees)
            {
                if(isPromotable(emp))
                {
                    Console.WriteLine(emp.Name + " - Promoted");
                }
            }
        } 
    }

    public class Program
    {
        static void Main(string[] args)
        {
            var empList = new List<Employee> 
            { 
                new Employee { Id = 1, Name = "Minsaf", Experience = 6, Salary = 20000 },
                new Employee { Id = 2, Name = "Dilini", Experience = 3, Salary = 60000 }
            };

            Employee.PromoteEmployee(empList, emp =>
            {
                return emp.Salary > 60000;
            });
        }

        //public static bool IsEligibleToPromoteByAge(Employee employee)
        //{
        //    return employee.Experience > 5;
        //}

        //public static bool IsEligibleToPromoteBySalary(Employee employee)
        //{
        //    return employee.Salary > 50000;
        //}
    }
}
