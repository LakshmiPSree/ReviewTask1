using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Review4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1)Given a list of employees with properties like ID, Name, Department, Salary, and DateOfJoining, write queries to:
            //Find employees who joined after a specific date.
            //Calculate the average salary of employees in each department.
            //Group employees by department and list their names.
            //Find the top 3 highest - paid employees using Lambda and LINQ.
            Employee employee = new Employee();
            employee.Linq();

            //2)You have a list of products with ProductID, Name, Category, Price, and StockQuantity.
            //Write a LINQ query to filter out products with stock less than 10.
            //Use Lambda expressions to calculate the total value of products in a specific category.
            //Find the cheapest product in each category.
            Product product = new Product();
            product.regex();

            //3)Read a CSV file containing user data(Name, Email, Age).
            //Validate email addresses using Regex.
            //Use LINQ to filter users whose age is above 18.
            //Save the filtered data into a new CSV file.
            User user = new User();
            user.Call();

        }
    }
}
