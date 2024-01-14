using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int userNumber;
        while (true)
        {
            Console.Write("Enter number: ");
            userNumber = int.Parse(Console.ReadLine());
            if (userNumber == 0) break;
            numbers.Add(userNumber);
        }

        // Compute the sum 
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }


        //Compute average
        float average = numbers.Count > 0 ? (float)sum / numbers.Count : 0;

        //Find the max
        int max = numbers.Count > 0 ? numbers[0] : 0;
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The max is: {max}");
    }
}