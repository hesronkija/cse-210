using System;
using static System.Console;

class Program
{
    static void Main(string[] args)
    {
        Run();
        WriteLine("Goodbye!!");
        Thread.Sleep(3000);
        Clear();
    }
    static int Menu()
    {
        WriteLine("Menu Options");
        WriteLine("\t1. Breathing activity");
        WriteLine("\t2. Reflection activity");
        WriteLine("\t3. Listing activity");
        WriteLine("\t4. Quit");
        Write("Select a choice from the menu: ");
        int choice = int.Parse(ReadLine());

        return choice;
    }
    static void Run()
    {

        bool validChoice = true ;
        int choice;
        while (validChoice)
        {
            choice = Menu();
            if (choice == 1 || choice == 2 || choice == 3 || choice == 4)
            {
                switch (choice)
                {
                    case 1:
                        Clear();
                        Breathing breathing = new Breathing(choice);
                        breathing.RunBreathing();
                        Clear();
                        break;
                    case 2:
                        Clear();
                        Reflection reflection = new Reflection(choice);
                        reflection.RunReflection();
                        Clear();
                        break;
                    case 3:
                        Clear();
                        Listing listing = new Listing(choice);
                        listing.RunListing();
                        Clear();
                        break;
                    case 4:
                        validChoice = false;
                        break;
                }
            }
            else
            {
                WriteLine("\nPlease enter a valid choice!!");
                Thread.Sleep(2000);
                Clear();
            }
        }

    }
}
