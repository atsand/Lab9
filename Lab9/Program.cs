using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the circle builder.");
            Start();
        }

        private static double CheckInput()
        {
            double input;
            Console.WriteLine();
            Console.WriteLine("Please enter a radius:");
            if (double.TryParse(Console.ReadLine(), out input))
            {
                return input;
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Input is not valid");
                return CheckInput();
            }
        }

        private static void Start()
        {
            bool again = true;
            int count = 0;
            while (again)
            {
                double radius;
                Circle newCircle;
                radius = CheckInput();
                newCircle = new Circle(radius);

                Console.WriteLine();
                Console.WriteLine("Circumference: " + newCircle.CalculateFormattedCircumference());
                Console.WriteLine("Area: " + newCircle.CalculateFormattedArea());
                Console.WriteLine();
                count++;
                again = Again();
            }
            Console.WriteLine();
            Console.WriteLine("You created {0} circles.", count);
        }

        private static bool Again()
        {
            bool again;
            string input;

            Console.WriteLine("Continue? (Y/N)");
            input = Console.ReadLine();
            if (input.ToLower() == "y")
            {
                again = true;
            }
            else if (input.ToLower() == "n")
            {
                Console.WriteLine("Goodbye");
                again = false;
            }
            else
            {
                Console.WriteLine("Sorry, I couldn't understand your input.  Let's try again.");
                again = Again();
            }
            return again;
        }
    }
}
