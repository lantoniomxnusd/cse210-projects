using System;
using System.Diagnostics;

public class Fractions
{
    private int _numerator;
    private int _denominator;

    public Fractions()
    {
        _numerator = 1;
        _denominator = 1;
    }

    public Fractions(int wholeNumber)
    {
        _numerator = wholeNumber;
        _denominator = 1;
    }

    public Fractions(int top, int bottom)
    {
        _numerator = top;
        _denominator = bottom;
    }

    public string GetFractionString()
    {
        string text = $"{_numerator}/{_denominator}";
        return text;
    }

    public double GetDecimalValue()
        {
            return (double)_numerator / (double)_denominator;
        }

}
