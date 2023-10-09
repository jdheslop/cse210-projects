using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction1 = new Fraction();
		Console.WriteLine($"Get numerator: {fraction1.GetNumerator()}");
		Console.WriteLine($"Get denominator: {fraction1.GetDenominator()}");
		Console.WriteLine(fraction1.GenerateFraction());
		Console.WriteLine(fraction1.GenerateDecimel());
	
        Fraction fraction2 = new Fraction(5);
		Console.WriteLine(fraction2.GenerateFraction());
		Console.WriteLine(fraction2.GenerateDecimel());

        Fraction fraction3 = new Fraction(3, 4);
		Console.WriteLine(fraction3.GenerateFraction());
		Console.WriteLine(fraction3.GenerateDecimel());

        Fraction fraction4 = new Fraction();
        fraction4.SetNumerator(1);
        fraction4.SetDenominator(3);
		Console.WriteLine(fraction4.GenerateFraction());
		Console.WriteLine(fraction4.GenerateDecimel());
    }
}

