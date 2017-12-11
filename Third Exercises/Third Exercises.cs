using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Third_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            {

                // Exercise 10
                // User enters numbers separated by '-'. Work out if the numbers are sequential, and display "Consecutive" or "Not Consecutive".

                Console.WriteLine("Enter a Series of Numbers Seperated via hyphen: ");
                var input = Console.ReadLine();

                var numbers = new List<int>();
                foreach (var number in input.Split('-'))
                    numbers.Add(Convert.ToInt32(number));

                numbers.Sort();

                var isSequential = true;
                for (var i = 1; i < numbers.Count; i++)
                {
                    if (numbers[i] != numbers[i - 1] + 1)    // Here ( i + 1) - 1 doesn't work. Work out why.
                    {
                        isSequential = false;
                        break;
                    }
                }

                var message = isSequential ? "Consecutive" : "Not Consecutive";
                Console.WriteLine(message);

            }

            {

                // Exercise 11
                // User enters a few numbers sep. by hyphen. If the users presses enter, without input, exit. Otherwise check for dups and display Duplicates.

                 

                Console.WriteLine("Enter a Series of Numbers separated by a hyphen, or Press Enter to Exit: ");
                var input = Console.ReadLine();

                if (String.IsNullOrWhiteSpace(input))
                return;

                var numbers = new List<int>();
                foreach (var number in input.Split('-'))
                numbers.Add(Convert.ToInt32(number));
                

                var uniques = new List<int>();
                var isDuplicate = false;
                foreach (var number in numbers)
                {
                    if (!uniques.Contains(number))
                        uniques.Add(number);
                    else
                    {
                        isDuplicate = true;
                        break;
                    }
                }

                if (isDuplicate)
                    Console.WriteLine("Duplicate");

                // Initially used While, which meant the program didn't terminate, and asked for continueous streams of input, until Enter Pressed. Still showed "Duplicate".
                // This is a better method of doing this. 
            }
        }
    }
}
