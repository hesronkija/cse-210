using System;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
       //appending numbers in a list
       List<int> numbers = new List<int>();
       System.Console.WriteLine("Enter a list of numbers, type 0 when finished");
       int number;
       do
       {
        System.Console.WriteLine("Enter your number: ");
        number = int.Parse(Console.ReadLine());
        if(number != 0)
            numbers.Add(number);
       } while (number != 0);

       int sum = 0;
       foreach (int num in numbers)
       {
            sum = sum + num;
       }
       System.Console.WriteLine($"The sum is: {sum}");

       int amountOfNumbers = numbers.Count;
       int avg = sum / amountOfNumbers;
       System.Console.WriteLine($"The average is: {avg}");

       //checking for the largest number
       int largestNumber = 0;
       foreach (int num in numbers)
       {
        if (num > largestNumber)
            largestNumber = num;
       }
       System.Console.WriteLine($"The largest number is {largestNumber}");

        //checking for the smallest number    
       int smallestNumber = 1000000;
       foreach (int num in numbers)
       {
        if (num < smallestNumber)
            smallestNumber = num;
       }
       System.Console.WriteLine($"The smallest number is {smallestNumber}");

       //sorting numbers
       numbers.Sort();
       System.Console.WriteLine($"Here are the numbers from {smallestNumber} to {largestNumber}");
       foreach (int num in numbers) 
       {
        System.Console.WriteLine(num);
       }

    }
}