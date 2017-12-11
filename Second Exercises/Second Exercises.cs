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

            // Exercise 5 - Facebook Post - Complete

            {

                var names = new List<string>();

                while (true)
                {
                    Console.WriteLine("Enter a Name or Hit Enter to Exit");
                    var input = Console.ReadLine();

                    if (String.IsNullOrWhiteSpace(input))
                        break;
                    else
                        names.Add(input);

                }

                if (names.Count > 2)
                    Console.WriteLine("{0}, {1} and {2} liked your post", names[0], names[1], names[2]);
                else if (names.Count == 2)
                    Console.WriteLine("{0} and {1} liked your post", names[0], names[1]);
                else if (names.Count == 1)
                    Console.WriteLine("{0} liked your post", names[0]);
                      

            }

            // Exercise 6 - Reversed Name

            {
                Console.Write("Enter Your Name: ");
                var input = Console.ReadLine();

                var nameArray = new char[input.Length];
                for (var i = input.Length; i > 0; i--)
                    nameArray[input.Length - i] = input[i - 1];

                var reversed = new string(nameArray);
                Console.WriteLine("Your Name Reversed is: " + reversed);



                
            }

            {

                // Exercise 7
                // User Enters 5 Numbers. If the Number is Dup, display an error message. Once User has entered 5 unique numbers, sort and display.

                var numbers = new List<int>();

                while (numbers.Count < 5)
                {
                    Console.WriteLine("Enter a Number: ");
                    var number = Convert.ToInt32(Console.ReadLine());
                    {
                        if (numbers.Contains(number))
                            Console.WriteLine("Duplicate! Enter Another Number: .");
                        else
                            continue;

                    }

                    numbers.Add(number);

                }

                numbers.Sort();

                foreach (var number in numbers)
                    Console.WriteLine(number);
                                 

                }

                

            {
                // Exercise 8
                // Write a Program which asks the User to Continuously enter a number or type "Quit" to exit. Can include Dups. Display unique numbers.

                var numbers = new List<int>();

                while (true)
                {
                    Console.WriteLine("Enter a Number: ");
                    var number = Console.ReadLine();

                    if (number.ToLower() == "quit")
                        break;

                    else
                        numbers.Add(Convert.ToInt32(number));
                                        
                }

                var uniqueNumbers = new List<int>();

                foreach (var number in numbers)
                {
                    if (!uniqueNumbers.Contains(number))
                        uniqueNumbers.Add(number);
                }

                Console.WriteLine("Unique Numbers are: ");
                foreach (var number in uniqueNumbers)
                    Console.WriteLine(number);
            }

            {
                // Exercise 9
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
