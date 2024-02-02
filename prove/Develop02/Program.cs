using System;
using static System.Console;
class Program
{
    static void Main(string[] args)
    {
        Run();
    }

    static int currentPromptIndex = 0;
    static void Run()
    {
        RunMenu();
        WaitForKey();
    }

    static void RunMenu() 
    {
        Journal journal = new Journal();
        string choice;

        Menu();
        do
        {
            choice = GetChoice();

            switch (choice)
            {
                case "1":
                    Clear();
                    string prompt = GetPrompt();
                    WriteLine(prompt);
                    string response = ReadLine();
                    string date = DateTime.Now.ToString();
                    journal.AddEntry(prompt, response, date);
                    Clear();
                    break;
                case "2":
                    break;
                case "3":
                    break;
                case "4":
                    break;
                case "5":
                    break;
            }

            Menu();
        }while(choice != "5");



    }
    static string GetPrompt()
        {
            string[] prompts = {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };

            string prompt = prompts[currentPromptIndex];
            currentPromptIndex = (currentPromptIndex + 1) % prompts.Length;
            return prompt;
        }        

    
    static void Menu()
    {
        WriteLine("1. Write");
        WriteLine("2. Display");
        WriteLine("3. Load");
        WriteLine("4. Save");            
        WriteLine("5. Quit");    
        
    }

    static string GetChoice()
    {
        WriteLine("What do you want to do?");
        string choice = ReadLine();
        return choice;
    }
    static void WaitForKey()
    {
        WriteLine("\nPress any key...");
        ReadKey(true);
    }

}