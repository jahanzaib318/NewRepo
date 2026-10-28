using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("ClassID: YOUR");
            Console.WriteLine("Registration ID: 66283);
            Console.WriteLine("Name: jahnzaib");
            Console.WriteLine("Submission Date: 24-10-2026");

            Console.Write("Enter a year: ");

            if (int.TryParse(Console.ReadLine(), out int year) && year > 0)
            {
                if (year % 400 == 0)
                {
                    Console.WriteLine(year + " is a Leap Year");
                }
                else if (year % 100 == 0)
                {
                    Console.WriteLine(year + " is Not a Leap Year");
                }
                else if (year % 4 == 0)
                {
                    Console.WriteLine(year + " is a Leap Year");
                }
                else
                {
                    Console.WriteLine(year + " is Not a Leap Year");
                }
            }
            else
            {
                Console.WriteLine("Invalid year");
            }

        }
    }
}
