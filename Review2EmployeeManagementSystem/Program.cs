using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Review2EmployeeManagementSystem.Program;

namespace Review2EmployeeManagementSystem
{
    internal class Program
    {
        public class Employee
        {
            private int id;
            private string name;
            private int age;

            public int Id
            {
                get { return id; }
                set { id = value; }
            }
            public string Name
            {
                get { return name; }
                set { name = value; }
            }
            public int Age
            {
                get { return age; }
                set { age = value; }
            }
            public Employee(int IdEmployee, string FullName, int Age)
            {
                this.id = IdEmployee;
                this.Name = FullName;
                this.Age = Age;
            }
        }
        public class EmployeeManage
        {   
            int FullDayHour = 8;
            int HalfDayHour = 4;
            int WagePerHour = 20;
            public bool EmployeePresent()
            {   
                Random random = new Random();
                int randomNumber = random.Next(0,2);
                if (randomNumber == 1)
                {
                    Console.WriteLine("Employee is present");
                    return true;
                }
                return false;
            }
            public int PartTime()
            {
                return HalfDayHour * WagePerHour;
            }

            public int CalculateDailyWages() {
                return FullDayHour * WagePerHour;
            }
            public int CalculateMonthlyWages()
            {
                return FullDayHour * WagePerHour *20;//assuming 20 days per month;
            }
        }
            static void Main(string[] args)
        {   List<Employee > Employeelist = new List<Employee>();
            EmployeeManage manager = new EmployeeManage();
            Console.WriteLine("Welcome to Employee Management System");
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("*******************MENU**********************");
                Console.WriteLine("1.Check whether the employee is present or not");
                Console.WriteLine("2.Calculate daily Employee wage");
                Console.WriteLine("3.Add PartTime employee and wage");
                Console.WriteLine("4.Calculate Wages for month");
                Console.WriteLine("5.exit");
                Console.WriteLine("Enter the choice");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        
                        if (!manager.EmployeePresent())
                        {
                            Console.WriteLine("Employee not present");
                        } 
                        break;
                    case 2:Console.WriteLine("Calculating the daily wages:");
                        int DailyWage = manager.CalculateDailyWages();
                        Console.WriteLine($"Daily Wages of the full time employee is {DailyWage}");
                        break;
                    case 3:Console.WriteLine("Adding Part time Employee");
                        Console.WriteLine("Enter the id");
                        int id = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter your Full Name");
                        string name = Console.ReadLine();
                        Console.WriteLine("Enter your Age");
                        int age = int.Parse(Console.ReadLine());
                        Employee employee = new Employee(id, name, age);
                        Employeelist.Add(employee);
                        Console.WriteLine("Employee successfully added");
                        int dailywageOfPartTimeEmployee = manager.PartTime();
                        Console.WriteLine($"The Daily wage of the Part Time Employee is {dailywageOfPartTimeEmployee}");
                        break;
                    case 4:
                        Console.WriteLine("Calculating the monthly wages:");
                        int MonthlyWage = manager.CalculateMonthlyWages();
                        Console.WriteLine($"Monthly Wages of the full time employee is {MonthlyWage}");
                        break;
                    case 5:
                        Console.WriteLine("Thankyou for using our Employee Management System");
                        return;
                    default:
                        Console.WriteLine("Please enter a valid choice");
                        break;
                }
            }

                
        }
    }
}
