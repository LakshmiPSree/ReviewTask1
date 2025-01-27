using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FinalReviewOfFundamentals
{
    internal class TPL
    {
        public TPL()
        {
            Task t1 = Task.Run(() => WriteNumberInFile());
            Task t2 = Task.Run(() => CalculateSumOfArray());
            Task t3 = Task.Run(() => SortNumbersInFile());
            Task.WhenAll(t1, t2, t3);
            Console.WriteLine("All tasks are completed");
        }
        public static void WriteNumberInFile()
        {
            string Path = "C:/Users/ADMIN/source/repos/ReviewTask1/FinalReviewOfFundamentals/file.txt";
            //File.Create(Path);
            Console.WriteLine("Enetr the numbers of elements to write in file: ");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Enter number to write in file: ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            File.WriteAllLines(Path, arr.Select(e=>e.ToString()));
        }
        public static void CalculateSumOfArray()
        {
            string Path = "C:/Users/ADMIN/source/repos/ReviewTask1/FinalReviewOfFundamentals/file.txt";
            string[] lines = File.ReadAllLines(Path);
            int sum = 0;
            foreach (var item in lines)
            {
                sum += int.Parse(item);
            }
            Console.WriteLine("Sum of elements in file is: " + sum);
        }
        public static void SortNumbersInFile()
        {
            string Path = "C:/Users/ADMIN/source/repos/ReviewTask1/FinalReviewOfFundamentals/file.txt";
            string[] lines = File.ReadAllLines(Path);
            int[] arr = new int[lines.Length];
            for (int i = 0; i < lines.Length; i++)
            {
                arr[i] = int.Parse(lines[i]);
            }
            Array.Sort(arr);
            File.WriteAllLines(Path, arr.Select(e => e.ToString()));
        }


    }
}
