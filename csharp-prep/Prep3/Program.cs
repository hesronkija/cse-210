using System;
using System.Runtime.Intrinsics.Arm;

class Program
{
    static void Main(string[] args)
    {
        //computer picks a random number
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 11);
        Boolean correctGuess;

        //user tries to guess the number
        Console.WriteLine("I have the magic number!!\n");
        do
        {
            Console.WriteLine("What is your guess? ");
            int guess = int.Parse(Console.ReadLine());

            //after each guess tell them "higher" or "lower"
            if (magicNumber > guess)
            {
                System.Console.WriteLine("Wrong!!");
                System.Console.WriteLine("Your guess is too low!!");
                correctGuess = false;
            }
            else if (magicNumber < guess)
            {
                System.Console.WriteLine("Your guess is too high!!");
                correctGuess = false;
            }
            else
            {
                System.Console.WriteLine("Correct guess");
                correctGuess = true;
            }
        } while (!correctGuess);
    }
}