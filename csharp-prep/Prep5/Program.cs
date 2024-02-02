using System;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void DisplayWelcome()
    {
        System.Console.WriteLine("Welcome to the Program");
    }
    static string PromptUserName()
    {
        System.Console.WriteLine("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }
    static int PromptUserNumber()
    {
        System.Console.WriteLine("Please enter your number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }
    static int SquareNumber(int number)
    {
        return number*number;
    }
    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }

    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int square = SquareNumber(number);
        DisplayResult(name, square);
    }
}