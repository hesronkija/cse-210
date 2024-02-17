// Program.cs
using System;
using static System.Console;

class Program
{
    static void Main(string[] args)
    {
        DisplayScripture();
        Run();
    }
    
    
    static Scripture scripture = new Scripture();

    static void Run()
    {
        while (!scripture.AllWordsHidden)
        {
            WriteLine("\nPress Enter to continue or type 'quit' to exit:");
            string input = ReadLine();
            if (input.ToLower() == "quit")
                break;
            else
            {
                scripture.HideRandomWords(3);
                DisplayScripture();
            }
        }
    }
    static void DisplayScripture()
    {
        Clear();
        WriteLine(scripture.GetFullReference());
        WriteLine(scripture.GetVisibleWords());
    }
}
