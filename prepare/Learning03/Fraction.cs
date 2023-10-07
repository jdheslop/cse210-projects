/*
Class: Fraction
Attributes:
    _numerator : int
    _denominator : int
Constructors:
    Fraction()
    Fraction(wholeNumber : int)
    Fraction(numerator:int, denominator:int)
Methods:
    Getters and Setters:
        GetNumerator() : int
        GetDenominator() : int
        SetNumerator(numerator:int) : void
        SetDenominator(denominator:int) : void
    Methods: 
        GenerateFraction() : string
        GenerateDecimal() : double
*/

using System;

public class Fraction
{
    // Attributes
    private int _numerator;
    private int _denominator;

    // Constructors
    public Fraction()
    {
        // Default to 1
        _numerator = 1;
        _denominator = 1;
    }

    public Fraction(int wholeNumber)
    {
        _numerator = wholeNumber;
        _denominator = 1;
    }

    public Fraction(int numerator, int denominator)
    {
        _numerator = numerator;
        _denominator = denominator;
    }

    // Getters and Setters
    //GetNumerator() : int
    //GetDenominator() : int
    //SetNumerator(numerator:int) : void
    //SetDenominator(denominator:int) : void

    // Methods
    //GenerateFraction() : string
    //GenerateDecimal() : double


}