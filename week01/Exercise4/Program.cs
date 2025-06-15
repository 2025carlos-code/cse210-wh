using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        //ask the user for a series of numbers and append them to a list

        // declare and initialize the list
       List<int> numbers = new List<int>();
        int number = -1; // initialize to a non-zero value to enter the loop
          // Tell user what to do
        Console.WriteLine("Enter numbers to add to the list (enter 0 to stop):");

        // keep asking for numbers until the user enters 0

        while (number != 0)
        {
            //ask the user to enter a number
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out number))
            {
                if (number != 0)
                {
                    numbers.Add(number);
                    Console.WriteLine($"Added {number} to the list.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        }
            //Calculate the sum (total) of all numbers in the list.
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            Console.WriteLine($"Current sum of numbers in the list: {sum}");

            if (numbers.Count > 0)
            {
                // Calculate the average of all numbers in the list.
                double average = (double)sum / numbers.Count;
                Console.WriteLine($"Current average of numbers in the list: {average}");
            }
            else
            {
                Console.WriteLine("No numbers in the list to calculate average.");
            }
            
            // Find the maximum number in the list.


            if (numbers.Count > 0)
        {
            int max = numbers[0];
            foreach (int num in numbers)
            {
                if (num > max)
                {
                    max = num;
                }
            }
            Console.WriteLine($"Current maximum number in the list: {max}");
        }

            
            
        
    }
}