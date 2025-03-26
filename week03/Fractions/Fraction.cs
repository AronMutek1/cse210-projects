public class Fraction
{
    private int numerator;
    private int denominator;

    // No-argument constructor
    public Fraction()
    {
        numerator = 1;
        denominator = 1;
    }

    // Single-parameter constructor
    public Fraction(int numerator)
    {
        this.numerator = numerator;
        denominator = 1;
    }

    // Two-parameter constructor
    public Fraction(int numerator, int denominator)
    {
        this.numerator = numerator;
        this.denominator = denominator;
    }

    // Getter for Numerator
    public int GetNumerator()
    {
        return numerator;
    }

    // Setter for Numerator
    public void SetNumerator(int numerator)
    {
        this.numerator = numerator;
    }

    // Getter for Denominator
    public int GetDenominator()
    {
        return denominator;
    }

    // Setter for Denominator
    public void SetDenominator(int denominator)
    {
        this.denominator = denominator;
    }

    // Method to get the fraction as a string
    public string GetFractionString()
    {
        return $"{numerator}/{denominator}";
    }

    // Method to get the decimal value of the fraction
    public double GetDecimalValue()
    {
        return (double)numerator / denominator;
    }
}
