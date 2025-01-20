using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review4
{
    internal class Product
    {
        //2)You have a list of products with ProductID, Name, Category, Price, and StockQuantity.
        //Write a LINQ query to filter out products with stock less than 10.
        //Use Lambda expressions to calculate the total value of products in a specific category.
        //Find the cheapest product in each category.
        public class Products
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Category { get; set; }
            public int StockQuantity { get; set; }
            public double Price { get; set; }

            public Products(int id, string name, string category, int stockQuantity, double price)
            {
                this.Id = id;
                this.Name = name;
                this.Category = category;
                this.StockQuantity = stockQuantity;
                this.Price = price;
            }

        }

        public void regex()
        {
            List<Products> products = new List<Products>()
            {
                new Products(1,"Milk","Milk Product",30,50),
                new Products(2,"Cheese","Milk Product",6,15),
                new Products(3,"Ice Candy","Milk Product",2,30),
                new Products(4,"Potato","veggies",6,20),
                new Products(5,"Tomato","veggies",2,50)

            };
            var less10 = products.Where(e => e.StockQuantity < 10);
            Console.WriteLine(" products with stock less than 10");
            foreach (var item in less10)
            {
                Console.WriteLine(item.Name);
            }

            Console.WriteLine("the total value of products in a specific category and the cheapest product in each category.");
            var group = products.GroupBy(e => e.Category).Select(grp => new
            {
                Category = grp.Key,
                Total = grp.Count(),
                Products = grp.ToList(),
                Cheapest = grp.Min(e=>e.Price)
            });
            foreach(var item1 in group)
            {
                Console.WriteLine($"Category is {item1.Category} and total count is {item1.Total} and cheapest is {item1.Cheapest}");
                foreach(var item2 in item1.Products)
                {
                    Console.WriteLine($"Product is {item2.Name} and price is {item2.Price}");
                }
            }
        }

    
    }
}
