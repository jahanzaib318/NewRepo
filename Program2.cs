using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("ClassID:66283   ");
            Console.WriteLine("Registration ID: 66283  ");
            Console.WriteLine("Name: jahanzaib  ");
           

            Console.Write("Enter purchase amount: ");

            if (decimal.TryParse(Console.ReadLine(), out decimal amount) && amount >= 0)
            {
                decimal discountPercentage;

                if (amount >= 5000)
                {
                    discountPercentage = 20;
                }
                else if (amount >= 2000)
                {
                    discountPercentage = 10;
                }
                else
                {
                    discountPercentage = 0;
                }

                decimal discountAmount = amount * discountPercentage / 100;
                decimal finalAmount = amount - discountAmount;

                Console.WriteLine("Discount Percentage: " + discountPercentage + "%");
                Console.WriteLine("Discount Amount: Rs. " + discountAmount);
                Console.WriteLine("Final Payable Amount: Rs. " + finalAmount);
            }
            else
            {
                Console.WriteLine("Invalid purchase amount");
            }

        }
    }
}
