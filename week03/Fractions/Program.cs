using System;

class Program
{
    static void Main(string[] args)
    {
        // Testing the constructors
        Fraction fraction1 = new Fraction();  // Default: 1/1
        Fraction fraction2 = new Fraction(5); // Single parameter: 5/1
        Fraction fraction3 = new Fraction(3, 4); // Two parameters: 3/4

        // Display the fractions and their decimal values
        Console.WriteLine(fraction1.GetFractionString()); // Should print: 1/1
        Console.WriteLine(fraction1.GetDecimalValue());   // Should print: 1.0

        Console.WriteLine(fraction2.GetFractionString()); // Should print: 5/1
        Console.WriteLine(fraction2.GetDecimalValue());   // Should print: 5.0

        Console.WriteLine(fraction3.GetFractionString()); // Should print: 3/4
        Console.WriteLine(fraction3.GetDecimalValue());   // Should print: 0.75
    }
}
