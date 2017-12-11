using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {

            // Exercise 5 - Facebook Post

            {

                var names = new List<string>();

                while (true)
                {
                    Console.Write("Enter a Name or Press Enter to Exit: ");

                    var input = Console.ReadLine();
                    if (String.IsNullOrWhiteSpace(input))
                        break;
                    names.Add(input);
                }

                if (names.Count > 2)
                    Console.WriteLine("{0}, {1} and {2} like you post", names[0], names[1], names[2]);
                else if (names.Count == 2)
                    Console.WriteLine("{0} and {1} like your post", names[0], names[1]);
                else if (names.Count == 1)
                    Console.WriteLine("{0} likes your post", names[0]);

                Console.WriteLine();

            }

            // Exercise 6 - Reversed Name

            {
                Console.Write("Enter Your Name: ");
                var name = Console.ReadLine();

                var nameArray = new char[name.Length];
                for (var i = name.Length; i > 0; i--) 
                    nameArray[name.Length - i] = name[i - 1]; 

                var reversed = new string(nameArray);
                Console.WriteLine("Reversed Name: " + reversed);
                                                
                
            }

            {

                // Exercise 7 - User Enters 5 Numbers. If the Number is Dup, display an error message. Once User has entered 5 unique numbers, sort and display.

                var numbers = new List<int>();

                while (numbers.Count < 5)
                {
                    Console.Write("Enter a Number: ");
                    var number = Convert.ToInt32(Console.ReadLine());
                    if (numbers.Contains(number))

                    {

                        Console.Write("You've already entered {0}, Try Again. ", number);
                        continue;

                    }

                    numbers.Add(number);

                }
                    numbers.Sort();

                foreach (var number in numbers)
                    Console.WriteLine(number);
                                               

                }

            {
                // Write a Program which asks the User to Continuously enter a number or type "Quit" to exit. Can include Dups. Display unique numbers.

                var numbers = new List<int>();

                while (true)
                {
                    Console.Write("Enter a Number, or type Quit to Exit: ");
                    var input = Console.ReadLine();

                    if (input.ToLower() == "quit")
                        break;

                    else
                        numbers.Add(Convert.ToInt32(input));

                }

                var uniqueNumbers = new List<int>();

                foreach (var number in numbers)
                {
                    if (!uniqueNumbers.Contains(number))
                        uniqueNumbers.Add(number);
                }

                Console.WriteLine("Unique Numbers: ");
                foreach (var number in uniqueNumbers)
                    Console.WriteLine(number);
            }

            {
                // Program that asks the User to Supply a List of Comma Seperated Values, If Empty or < 5, display Invalid List and ask to retry. Otherwise Display 3 Smallest Int.

                string[] elements;

                while (true)
                {
                    Console.WriteLine("Enter 5 Numbers, Seperated by commas: ");
                    var input = Console.ReadLine();

                    if (!String.IsNullOrWhiteSpace(input))
                    {
                        elements = input.Split(',');
                        if (elements.Length >= 5)
                            break;
                    }

                    Console.WriteLine("Invalid List");
                                    
                }

                var numbers = new List<int>();
                foreach (var number in elements)
                    numbers.Add(Convert.ToInt32(number));

                var smallestValues = new List<int>();
                while (smallestValues.Count < 3)

                {
                    var min = numbers[0];
                    foreach (var number in numbers)
                    {
                        if (number < min)
                            min = number;

                    }

                    smallestValues.Add(min);

                    numbers.Remove(min);

                }

                Console.WriteLine("The Minimum Values are: ");
                foreach (var number in smallestValues)
                    Console.WriteLine(number);
                                
            }
        }       

    }
}
