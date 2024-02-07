using System;

class Fraction
{
    int top;
    int bottom;

    public Fraction()
    {
        top = 1;
        bottom = 1;
    }
    public Fraction(int wholeNumber)
    {
        top = wholeNumber;
        bottom = 1;
    }
    public Fraction(int top, int bottom)
    {
        this.top = top;
        this.bottom = bottom;
    }

    int GetTop()
    {
        return top;
    }
    void SetTop(int top)
    {
        this.top = top;
    }
    int GetBottom()
    {
        return bottom;
    }
    void SetBottom(int bottom)
    {
        this.bottom = bottom;
    }

    public string GetFractionString()
    {
        return $"{GetTop()}/{GetBottom()}";
    }
    public double GetDecimalValue()
    {
        double value = (double)top / (double)bottom;
        return value;
    }

}