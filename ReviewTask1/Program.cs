using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ReviewTask1
{
    public abstract class Shape
    {
        public abstract void calculateArea();

        public void Display()
        {
            Console.WriteLine("this is a shape");
        }
    }

    public class Circle : Shape
    {
        public double radius { get; set; }
        public override void calculateArea()
        {
            Console.WriteLine($"the area of the circle is {3.14 * radius * radius}");
        }
    }


    public class Rectangle : Shape
    {
        public double length { get; set; }
        public double breadth { get; set; }
        public override void calculateArea()
        {
            Console.WriteLine($"the area of the rectangle is {length * breadth}");
        }
    }

    public class Square : Shape
    {
        public double side { get; set; }
        public override void calculateArea()
        {
            Console.WriteLine($"the area of the square is  {side * side}");
        }
    }
    internal class Program
    {

        static void Main(string[] args)
        {  //1)Write a program that counts the number of vowels and consonants in a given string.
            
            Console.WriteLine("Enter any sentence");
            string sentence = Console.ReadLine().ToLower();
            int countVowel = 0;
            int CountConsonant = 0;
            for (int i = 0; i < sentence.Length; i++)
            {
                
                if (sentence[i] == 'a'|| sentence[i] == 'e' || sentence[i] == 'i' || sentence[i] == 'o' || sentence[i] == 'u')
                {
                    countVowel++;
                }
                else if (sentence[i] == ' ')
                {
                    continue; 
                }
                else
                {
                    CountConsonant++;
                }
            }
            Console.WriteLine($"Number of vowels is {countVowel} and the Number of consonants is {CountConsonant}");
            //2)Write a program that removes all vowels from a given string.
            
            Console.WriteLine("Enter any sentence");
            string statement = Console.ReadLine().ToLower();
            for (int i = 0; i < statement.Length; i++)
            {
                if (statement[i] != 'a' && statement[i] != 'e' && statement[i] != 'i' && statement[i] != 'o' && statement[i] != 'u')
                {
                    Console.Write(statement[i]);
                }
            }

            
            // 3)Write a program that calculates a person's age based on their birth date.
            Console.WriteLine("Enter the birth date");
            DateTime birthdate = Convert.ToDateTime(Console.ReadLine());
            DateTime dateTime = DateTime.Now;
            Console.WriteLine($"Persons is {dateTime.Year - birthdate.Year} year {dateTime.Month - birthdate.Month} month old");

            
            // 4)Write a program that calculates the sum of even and odd digits in a given integer separately.
            Console.WriteLine("Enter the Integer");
            int Integer = int.Parse(Console.ReadLine());
            int evenSum = 0;
            int oddSum = 0;
            while (Integer > 0)
            {
                int remainder = Integer % 10;
                if (remainder % 2 == 0)
                {
                    evenSum += remainder;
                }
                else
                {
                    oddSum += remainder;
                }
                Integer = Integer / 10;
            }
            Console.WriteLine($"The even sum of the given integer is {evenSum} and the oddSum is {oddSum}");


            // 5)Create a class Shape with methods to calculate the area of different shapes like a circle, rectangle, and square.
            
            Circle circle = new Circle();
            Console.WriteLine("Enter the radis of the circle");
            circle.radius = double.Parse(Console.ReadLine());
            circle.calculateArea();
            Rectangle rectangle = new Rectangle();
            Console.WriteLine("Enter the length and breadth of the rectangle");
            rectangle.length = double.Parse(Console.ReadLine());
            rectangle.breadth = double.Parse(Console.ReadLine());
            rectangle.calculateArea();
            Console.WriteLine("Enter the side of the square");
            Square square = new Square();
            square.side = double.Parse(Console.ReadLine());
            square.calculateArea();
            
        }
    }
    
}

