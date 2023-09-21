using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();

        int numberInput = -1;
        List<int> numbersList = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        // Enter numbers into the list
        do
        {
            Console.Write("Enter number: ");
            numberInput = int.Parse(Console.ReadLine());
            if (numberInput != 0)
            {
                numbersList.Add(numberInput);
            }
        } while (numberInput != 0);

        // Calculate the sum of the list
        int sum = 0;
        foreach (int number in numbersList)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");

        // Calculate the average of the list
        float average = ((float)sum) / numbersList.Count;
        Console.WriteLine($"The average is: {average}");

        // Find the largest number
        int maxNumber = numbersList.Max();

        /* int maxNumber = numbersList[0];
        foreach (int number in numbersList)
        {
            if (number > maxNumber)
            {
                maxNumber = number;
            }
        } */

        Console.WriteLine($"The largest number is: {maxNumber}");

        // Find the smallest positive number
        int smallestPositiveNumber = 999999999;
        foreach (int number in numbersList)
        {
            if ((number > 0) && (number < smallestPositiveNumber))
            {
                smallestPositiveNumber = number;
            }
        }

        // Display the smalles positive number result
        if (smallestPositiveNumber != 999999999)
        {
            Console.WriteLine($"The smallest positive number is: {smallestPositiveNumber}");
        }
        else
        {
            Console.WriteLine("None of the numbers are positive.");
        }

        // Sort the list
        numbersList.Sort();

        // Display the sorted list
        foreach (int number in numbersList)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine();
    }
}