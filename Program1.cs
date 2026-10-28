using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("66283");
            Console.WriteLine("733743");
            Console.WriteLine("Name: jahanzaib");
            Console.WriteLine("24-10-2026");

            Console.Write("Enter a day number (1-7): ");

            if (int.TryParse(Console.ReadLine(), out int day))
            {
                switch (day)
                {
                    case 1:
                        Console.WriteLine("Monday");
                        break;
                    case 2:
                        Console.WriteLine("Tuesday");
                        break;
                    case 3:
                        Console.WriteLine("Wednesday");
                        break;
                    case 4:
                        Console.WriteLine("Thursday");
                        break;
                    case 5:
                        Console.WriteLine("Friday");
                        break;
                    case 6:
                        Console.WriteLine("Saturday");
                        break;
                    case 7:
                        Console.WriteLine("Sunday");
                        break;
                    default:
                        Console.WriteLine("Invalid number");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid number");
            }

        }
    }
}
s
