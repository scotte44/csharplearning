using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    public class Program
    {
        static void Main(string[] args)
        {

            /* Writing a Program that asks the user to enter a number.
             * In order to be valid it should be between 1 and 10. 
             * If Invalid, Display "Invalid */

            //Exercise1
        
            {

                Console.Write("Enter a number between 1 and 10: ");

                var input = Console.ReadLine();
                var number = Convert.ToInt32(input);

                if (number >= 1 && number <= 10)
                    Console.WriteLine("Valid");
                else
                    Console.WriteLine("Invalid");

            }

            /* Write a Program which takes two entered numbers, and displays the Max Value */

            //Exercise2

            {
                Console.Write("Enter a number: ");
                var input1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter another number: ");
                var input2 = Convert.ToInt32(Console.ReadLine());

                /*if (input1 > input2)
                   Console.WriteLine("The Maximum Value is " + input1);
                else
                   Console.WriteLine("The Maximum Value is " + input2);*/

                // Cleaner Way of Writing Below

                var max = (input1 > input2) ? input1 : input2;
                // var max = (Condition) (? = If True) (Value if True) : (Value if False)
                Console.WriteLine("The Maximum Value is: {0}",max);

                
            }

            /* Write a Program and Ask the User to Enter the Width and Height of an image,
             * Determine whether it's landscape or portrait*/

            // Exercise3

            {

                Console.Write("Image Width: ");
                var width = Convert.ToInt32(Console.ReadLine());

                Console.Write("Image Length: ");
                var length = Convert.ToInt32(Console.ReadLine());

                var orientation = (width > length) ? "Landscape" : "Portrait";
                Console.WriteLine("Your Image is {0}", orientation);

                // Possible to Use Enum here

                // var orientation = (width > length) ? ImageOrientation.Landscape : ImageOrientation.Portrait

                /* public enum ImageOrientation
                * {
                * 
                * Landscape,
                * Portrait
                * 
                * } */

            }

            /* Write a Program for a Speed Camera
             * Ask to Enter Speed, if below limit then display "OK"
             * If Above Limit, then calculate the number of demerit points
             * For Every 5kmh above the speed limit, 1 Demerit Point
             * If Number of Demerit Points is above 12, Program should display License Suspended */

            // Exercise4

            {
                Console.Write("What is the Speed Limit? ");
                var speedLimit = Convert.ToInt32(Console.ReadLine());

                Console.Write("How Fast was the car going? ");
                var carSpeed = Convert.ToInt32(Console.ReadLine());

                
                if (carSpeed < speedLimit)
                    Console.WriteLine("Okay");
                else
                {
                    const int perKM = 5;
                    var demeritPoints = (carSpeed - speedLimit) / perKM;
                    if (demeritPoints > 12)
                        Console.WriteLine("License Suspended");
                    else
                        Console.WriteLine("You deserve {0} Demerit Points", demeritPoints);

                                        
                }
            }
                     
        }
    }
}
