using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction1 = new Fraction();
        Fraction fraction2 = new Fraction(5);
        Fraction fraction3 = new Fraction(3, 4);
        Fraction fraction4 = new Fraction();

        fraction4.SetNumerator(1);
        fraction4.SetDenominator(3);


        Console.WriteLine(fraction1);
        Console.WriteLine(fraction2);
        Console.WriteLine(fraction3);

    }
}