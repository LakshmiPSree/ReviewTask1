using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review4
{
    //1)Given a list of employees with properties like ID, Name, Department, Salary, and DateOfJoining, write queries to:
    //Find employees who joined after a specific date.
    //Calculate the average salary of employees in each department.
    //Group employees by department and list their names.
    //Find the top 3 highest - paid employees using Lambda and LINQ.
    internal class Employee
    {
        public class Emp
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Department { get; set; }
            public double Salary { get; set; }
            public DateTime dateOfJoining { get; set; }

            public Emp(int Id, string name, string department, double salary, DateTime dateofjoining)
            {
                this.Id = Id;
                this.Name = name;
                this.Department = department;
                this.Salary = salary;
                this.dateOfJoining = dateofjoining;
            }
        }

        public void Linq()
        {//Find employees who joined after a specific date.
         //Calculate the average salary of employees in each department.
         //Group employees by department and list their names.
         //Find the top 3 highest - paid employees using Lambda and LINQ.

        List<Emp> employee = new List<Emp>()
        {
            new Emp(1,"Ambruta","IT",20000,new DateTime(2024,05,31)),
            new Emp(2,"Devjani","COMP",10000,new DateTime(2025,5,21)),
            new Emp(3,"Devika","IT",29000,new DateTime(2024,8,30)),
            new Emp(4,"Pratik","COMP",32000,new DateTime(2024,3,14)),
            new Emp(5,"Prathamesh","COMP",10000,new DateTime(2024,9,26)),
            new Emp(6,"Siddhi","IT",20000,new DateTime(2024,1,31))
        };
        Console.WriteLine("Finding employees who joined after a specific date.");
        DateTime specificdate = new DateTime(2024, 4, 19);
        var afterdate = employee.Where(e => e.dateOfJoining > specificdate).ToList();
        Console.WriteLine($"Joined after {specificdate}");
        foreach (var item in afterdate)
        {
            Console.WriteLine($"{item.Name} joining date was {item.dateOfJoining}");
        }


        Console.WriteLine("Group employees by department and list their names.");
        var group = employee.GroupBy(e => e.Department).Select(grp => new
        {
            Department = grp.Key,
            employee = grp.ToList(),
            Average = grp.Average(e=>e.Salary)
        });
        foreach(var item in group)
        {
            Console.WriteLine($"Department is {item.Department} and average salary is {item.Average}");
            foreach(var item2 in item.employee)
            {
                Console.WriteLine(item2.Name);
            }
        }

        Console.WriteLine("top 3 highest - paid employees");
        var highest = employee.OrderByDescending(e => e.Salary).Take(3);
        foreach (var item in highest)
        {
            Console.WriteLine($" Name of the employee is : {item.Name} and the salary is :{item.Salary}");
        }


        }
    }
}
