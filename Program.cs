using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace activity2how_old_are_you_in_month
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Get user's age in years
            Console.Write("Enter your age in years: ");
            string input = Console.ReadLine();

            // Validate and convert age
            if (int.TryParse(input, out int age))
            {
                if (age < 1 || age > 120)
                {
                    Console.WriteLine("Error: Age must be between 1 and 120.");
                }
                else
                {
                    // Convert age to months
                    int ageInMonths = age * 12;

                    // Display the result
                    Console.WriteLine($"You are {ageInMonths} months old.");
                }

            }
            else
            {
                Console.WriteLine("Error: Please enter a valid integer for age.");
            }
        }
    }
 }






