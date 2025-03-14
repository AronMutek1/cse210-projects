using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>();
        int number;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        do
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());
            if (number != 0)
            {
                numbers.Add(number);
            }
        } while (number != 0);

        if (numbers.Count > 0)
        {
            int sum = 0;
            int max = numbers[0];
            foreach (int num in numbers)
            {
                sum += num;
                if (num > max)
                {
                    max = num;
                }
            }
            
            double average = (double)sum / numbers.Count;
            
            Console.WriteLine($"The sum is: {sum}");
            Console.WriteLine($"The average is: {average}");
            Console.WriteLine($"The largest number is: {max}");

            // Stretch Challenge
            int? smallestPositive = null;
            foreach (int num in numbers)
            {
                if (num > 0 && (smallestPositive == null || num < smallestPositive))
                {
                    smallestPositive = num;
                }
            }
            if (smallestPositive != null)
            {
                Console.WriteLine($"The smallest positive number is: {smallestPositive}");
            }

            numbers.Sort();
            Console.WriteLine("The sorted list is:");
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }
        }
        else
        {
            Console.WriteLine("No numbers were entered.");
        }
    }
}
