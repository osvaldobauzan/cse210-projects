using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Amonooooooooooos");

        Console.WriteLine("Enter a list of possitive numbers, type 0 when finished.");
        int number = -1;
        List<int> numbers = new List<int>();

        while (number != 0)
        {
            Console.Write("Enter a number:");
            string numberStr = Console.ReadLine();
            number = int.Parse(numberStr);

            numbers.Add(number);
        }
        
        int sum = 0;
        int largest = int.MinValue;

        foreach (int num in numbers)
        {
            sum += num;
            if (num > largest)
            {
                largest = num;
            }
        }

        double average = (double)sum / numbers.Count;

        Console.WriteLine("The sum is: " + sum);
        Console.WriteLine("The average is: " + average);
        Console.WriteLine("The largest number is: " + largest);
    }
}