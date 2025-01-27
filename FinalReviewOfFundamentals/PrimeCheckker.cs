using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalReviewOfFundamentals
{
    internal class PrimeCheckker
    {
        //Write a console app to check if a number is prime. Implement input validation and ensure proper error handling.
        public PrimeCheckker()
        {
            PrimeChecker();
        }
        public void PrimeChecker()
        {
            Console.WriteLine("Enter a number to check if it is prime: ");
            if (int.TryParse(Console.ReadLine(), out int input))
            {
                if (input < 2)
                {
                    Console.WriteLine("Number is not prime");
                }
                else
                {
                    bool isPrime = true;
                    for (int i = 2; i <= Math.Sqrt(input); i++)
                    {
                        if (input % i == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                    if (isPrime)
                    {
                        Console.WriteLine("Number is prime");
                    }
                    else
                    {
                        Console.WriteLine("Number is not prime");
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
    }
}
