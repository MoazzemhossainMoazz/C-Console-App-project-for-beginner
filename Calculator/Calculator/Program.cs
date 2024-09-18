using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;

            int result;

            string answer;

            Console.WriteLine("Hello! Welcome to the calculator program!\n");
            Console.WriteLine("Please enter your first number");

            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nPlease enter your 2nd number.");

            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nWhat type of operation would you like to do?");
            Console.WriteLine("\nPleae enter a for addition, s for subtraction, m for multiplication or d for division.");

            answer = Console.ReadLine();

            if(answer == "a")
            {
                result = num1 + num2;
            }
            else if(answer == "s")
            {
                result = num1 - num2;
            }
            else if(answer == "m")
            {
                result = num1 * num2;
            }
            else
            {
                result = num1 / num2;
            }

            Console.WriteLine("\nThe result is " + result);
            Console.WriteLine("\nThank you for using the calculator program!");

            Console.ReadKey();
        }
    }
}
