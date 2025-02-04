using System;

public class Fraction
{

    private int _topNumber;
    private int _bottom;

    public Fraction()
    {
        _topNumber = 1;
        _bottom = 1;
    }

    public Fraction(int wholeNumber)
    {
        _topNumber = wholeNumber;
        _bottom = 1;
    }

    public Fraction(int topNumber, int bottom)
    {
        _topNumber = topNumber;
        _bottom = bottom;
    }

    public string GetStringFraction()
    {
        string fraction = $"{_topNumber}/{_bottom}";
        return fraction;
    }

    public double GetDecimalValue()
    {
        return (double)_topNumber / (double)_bottom;
    }

}