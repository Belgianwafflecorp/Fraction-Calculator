using System;
using FractionLibrary;

namespace THE_FRACTION_CONSOLE_APPLICATION
{
    internal class Program
    {
        private static int firstNumerator;
        private static int firstDenominator;
        private static int secondNumerator;
        private static int secondDenominator;

        public static int GetValidNumerator()
        {
            int numerator;
            while (!int.TryParse(Console.ReadLine(), out numerator) || numerator == 0)
            {
                if (numerator == 0)
                    Console.WriteLine("Numerator cannot be zero");
                else
                    Console.WriteLine("Error: Please enter a valid number");
            }
            return numerator;
        }
        public static int GetValidDenominator()
        {
            int denominator;
            while (!int.TryParse(Console.ReadLine(), out denominator) || denominator == 0)
            {
                if (denominator == 0)
                    Console.WriteLine("Denominator cannot be zero");
                else
                    Console.WriteLine("Error: Please enter a valid number");
            }
            return denominator;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Fraction Calculator!");
            // Get input for first fraction
            Console.Write("Enter numerator for fraction 1: ");
            firstNumerator = GetValidNumerator();
            Console.Write("Enter denominator for fraction 1: ");
            firstDenominator = GetValidDenominator();

            // Get input for second fraction
            Console.Write("Enter numerator for fraction 2: ");
            secondNumerator = GetValidNumerator();
            Console.Write("Enter denominator for fraction 2: ");
            secondDenominator = GetValidDenominator();

            // Create Fraction objects
            Fraction fraction1 = new Fraction(firstNumerator, firstDenominator);
            Fraction fraction2 = new Fraction(secondNumerator, secondDenominator);

            // Perform operations
            Console.WriteLine($"Fraction 1: {fraction1}");
            Console.WriteLine($"Fraction 2: {fraction2}");

            Console.WriteLine($"Addition: {fraction1.Add(fraction2)}");
            Console.WriteLine($"Subtraction: {fraction1.Subtract(fraction2)}");
            Console.WriteLine($"Multiplication: {fraction1.Multiply(fraction2)}");
            Console.WriteLine($"Division: {fraction1.Divide(fraction2)}");
            Console.WriteLine($"Reciprocal of fraction 1: {fraction1.Reciprocal()}");
            Console.WriteLine($"Invert of fraction 1: {fraction1.Invert()}");

            Console.WriteLine($"Fraction 1 result: {fraction1.Result()}");
            Console.WriteLine($"Fraction 2 result: {fraction2.Result()}");
        }

    }
    
}
