using System;
using static System.Console;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction = new Fraction(3,4);
        WriteLine(fraction.GetFractionString());
        WriteLine(fraction.GetDecimalValue());
    }
}