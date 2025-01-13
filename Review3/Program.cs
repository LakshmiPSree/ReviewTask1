using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Review3
{
    internal class Program
    {
        public class Employee
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Department { get; set; }
            public double  Salary { get; set; }
            public DateTime DateOfJoining { get; set; }

            public Employee(int id,string name,string department,double salary,DateTime dateofjoining) { 
            
                this.Id = id;
                this.Name = name;
                this.Department = department;
                this.Salary = salary;
                this.DateOfJoining = dateofjoining;
            }
        }
        public class Product
        {
            public int ProductId { get; set; }
            public string ProductName { get; set; }
            public string Category { get; set; }
            public double Price { get; set; }
            public int StockQuantity { get; set; }

            public Product(int id, string name, string category, double price, int stockQuantity)
            {

                this.ProductId = id;
                this.ProductName = name;
                this.Price = price;
                this.Category = category;
                this.StockQuantity = stockQuantity;
            }
        }


            static void Main(string[] args)
        {
            //1)Given a list of employees with properties like ID, Name, Department, Salary, and DateOfJoining, write queries to:
            //Find employees who joined after a specific date.
            //Calculate the average salary of employees in each department.
            //Group employees by department and list their names.
            //Find the top 3 highest - paid employees using Lambda and LINQ.
            List<Employee> list = new List<Employee>
            {
                new Employee(1,"Ayesha","IT",20000,new DateTime(2024,05,31)),
                new Employee(2,"Devjani","COMP",10000,new DateTime(2025,5,21)),
                new Employee(3,"Ambruta","IT",29000,new DateTime(2024,8,30)),
                new Employee(4,"Pratik","COMP",32000,new DateTime(2024,3,14)),
                new Employee(5,"Prathamesh","COMP",10000,new DateTime(2024,9,26)),
                new Employee(6,"Siddhi","IT",20000,new DateTime(2024,1,31)),

            };
            DateTime specificdate = new DateTime(2024,4,19);
            var afterdate=list.Where(e=>e.DateOfJoining > specificdate).ToList();
            Console.WriteLine($"Joined after {specificdate}");
            foreach (var item in afterdate)
            {
                Console.WriteLine($"{item.Name} joining date was {item.DateOfJoining}");
            }


            var groupby = list.GroupBy(e => e.Department).Select(group => new
            {
                Category = group.Key,
                employees = group.ToList()
            });
            foreach (var employee in groupby)
            {
                Console.WriteLine(employee.Category);
                foreach(var emp in employee.employees)
                {
                    Console.WriteLine(emp.Name);
                }
            }

            var joinedIT = list.Where(e=>e.Department == "IT").Average(x => x.Salary);
            Console.WriteLine($"The Average salary of IT department is {joinedIT}");
            var joinedCOMP = list.Where(e => e.Department == "COMP").Average(x => x.Salary);
            Console.WriteLine($"The Average salary of COMP department is {joinedCOMP}");

            var highest = list.OrderByDescending(e => e.Salary).Take(3);
            Console.WriteLine("Top 3 highest - paid employees are ");
            foreach(var  item in highest)
            {
                Console.WriteLine($" Name of the employee is : {item.Name} and the salary is :{item.Salary}");
            }
            //2)You have a list of products with ProductID, Name, Category, Price, and StockQuantity.
            //Write a LINQ query to filter out products with stock less than 10.
            //Use Lambda expressions to calculate the total value of products in a specific category.
            //Find the cheapest product in each category.
            List<Product> products = new List<Product>
            {
                new Product(1, "Ice cream", "Milk Product",45,9),
                new Product(2, "Cheese", "Milk Product",200,11),
                new Product(3, "Milk", "Milk Product",50,19),
                new Product(4, "Cabbage", "Vegetables",55,6),
                new Product(5, "tomato", "Vegetables",35,23),
                new Product(6, "Potato", "Vegetables",35,39),
                new Product(7, "palak", "Vegetables",25,50),
                new Product(8, "Carrot", "Vegetables",65,10),
                new Product(9, "Onion", "Vegetables",115,90),
            };
            var less10 = products.Where(e => e.StockQuantity < 10);
            Console.WriteLine(" products with stock less than 10");
            foreach(var  item in less10)
            {
                Console.WriteLine(item.ProductName);
            }

            var grp = products.GroupBy(e => e.Category).Select(group => new
            {
                category = group.Key,
                Total=group.Count(),
                products=group.ToList(),
                Cheapest = group.Min(p=>p.Price)          
            });
            foreach (var item in grp)
            {
                Console.WriteLine($"categorized into {item.category} and count is {item.Total} and cheapest is {item.Cheapest}");
                foreach (var item2 in item.products)
                {
                    Console.WriteLine($"{item2.ProductName} and its price is {item2.Price}");
                }
            }

            var milk = products.Where(e => e.Category == "Milk Product").OrderBy(e => e.Price).Take(1).Select(word=>word.ProductName);
            foreach (var item in milk)
            {
                Console.WriteLine($"cheapest product in Milk Product is {item}");
            }
            var vegees = products.Where(e => e.Category == "Vegetables").OrderBy(e => e.Price).Take(1).Select(word => word.ProductName);
            foreach (var item in vegees)
            {
                Console.WriteLine($"The cheapest product in Vegetables  is {item}");
            }

        }
    }
}
