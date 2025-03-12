using System;

class Program
{
    static void Main()
    {
        // Ask the user for their grade percentage
        Console.Write("Enter your grade percentage: ");
        int grade = int.Parse(Console.ReadLine());
        
        string letter = "";
        string sign = "";
        
        // Determine the letter grade
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Determine the grade sign (+ or -)
        int lastDigit = grade % 10;
        if (letter != "A" && letter != "F")
        {
            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
        }
        else if (letter == "A" && lastDigit < 3)
        {
            sign = "-";
        }
        
        Console.WriteLine($"Your letter grade is: {letter}{sign}");

        // Determine if the user passed
        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
        else
        {
            Console.WriteLine("Keep working hard! You can do better next time.");
        }
    }
}
