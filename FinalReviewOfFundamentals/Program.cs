using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalReviewOfFundamentals
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Stack stack = new Stack();
            //PrimeCheckker prime = new PrimeCheckker();
            //Name name = new Name();
            TPL tpl = new TPL();

            Console.WriteLine("Enter the age");
            int age = int.Parse(Console.ReadLine());
            try
            {
                if (age < 18)
                {
                    throw new CustomException("Age should be greater than 18");
                }
            }
            catch (CustomException ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
