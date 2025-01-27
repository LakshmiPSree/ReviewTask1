using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using CsvHelper;

namespace Review4
{
    internal class User
    {
        public class Write
        {

            [Required(ErrorMessage = "Name is required")]
            public string Name { get; set; }

            [Required(ErrorMessage = "Email is required")]
            [RegularExpression(@"^[a-zA-Z\d._]+@gamil/.com$", ErrorMessage = "Email should be of valid format eg.abc@gamil.com")]
            public string Email { get; set; }

            [Required(ErrorMessage = "Age is required")]
            public int Age { get; set; }

            public Write(string name, string email, int age)
            {
                Name = name;
                Email = email;
                Age = age;
            }
        }

        public void Call()
        {
            //Read a CSV file containing user data(Name, Email, Age).
            //Validate email addresses using Regex.
            //Use LINQ to filter users whose age is above 18.
            //Save the filtered data into a new CSV file
            string path = "C:/Users/ADMIN/source/repos/ReviewTask1/Review4/file.csv";
            //File.Create(path);
            List<Write> list = new List<Write>()
            {
                new Write("Ambu","ab@gmail.com",28),
                new Write("Lakshmi","adb@gmail.com",12),
                new Write("Viji","abc@gmail.com",20),

            };
            using (var write = new StreamWriter(path))
            using (var csvWriter = new CsvWriter(write, CultureInfo.InvariantCulture))
            {
                csvWriter.WriteRecords(list);
            }
            

            using (var reader = new StreamReader(path))
            {
                using (var csvreader = new CsvReader(reader, CultureInfo.InvariantCulture)) 
                {
                    var dataFromCsv = csvreader.GetRecords(list);
                    foreach (var record in dataFromCsv) {
                        Console.WriteLine($"name is {record}");
                    
                    }
                    var filter = list.Where(e => e.Age > 18).Select(e => e.Name).ToList();
                    
                }

            }

        }
    }
}
