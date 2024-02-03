using System;
using static System.Console;
class Program
{
    static void Main(string[] args)
    {
        Run();
        Outro();        
        WaitForKey();
    }

    static int currentPromptIndex = 0;
    static Journal journal = new Journal();

    static void Run()
    {

        string choice;

        do
        {
            Menu();
            choice = GetChoice();

            switch (choice)
            {
                case "1":
                    Clear();
                    ForegroundColor = ConsoleColor.Green;
                    string prompt = GetPrompt();
                    WriteLine(prompt);

                    ForegroundColor = ConsoleColor.Cyan;
                    string response = ReadLine();
                    string date = DateTime.Now.ToString();
                    journal.AddEntry(prompt, response, date);
                    Clear();
                    break;

                case "2":
                    Clear();
                    ForegroundColor = ConsoleColor.Blue;
                    journal.DisplayJournal();
                    WaitForKey();
                    Clear();
                    break;

                case "3":
                    Clear();
                    var entries = journal.ExportJournal();
                    Save(entries);
                    Clear();
                    break;

                case "4":
                    Clear();
                    var entriesFromFile = Load();
                    journal = new Journal(entriesFromFile);
                    Clear();
                    break;

                case "5":
                    break;
            }
        } while (choice != "5");



    }
    static string GetPrompt()
    {
        string[] prompts = {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What is a goal I accomplished today, no matter how small?",
        "Describe a moment that made me laugh today.",
        "How did I handle a challenging situation today?",
        "Reflect on a new thing I learned today.",
        "Write about a person who inspired or influenced me today.",
        "What is something I'm grateful for right now?",
        "Share a memory from the past that came to mind today.",
        "Describe a place or environment that had an impact on me today.",
        "Write about a decision I made today and its consequences.",
        "Reflect on a skill or talent I utilized or developed today."
    };

        string prompt = prompts[currentPromptIndex];
        currentPromptIndex = (currentPromptIndex + 1) % prompts.Length;
        return prompt;
    }

    static void Menu()
    {
        ForegroundColor = ConsoleColor.White;
        Art();
        WriteLine("1. Write");
        WriteLine("2. Display");
        WriteLine("3. Save");
        WriteLine("4. Load");
        WriteLine("5. Quit");

    }

    static string GetChoice()
    {
        WriteLine("What do you want to do?");
        string choice = ReadLine();
        return choice;
    }

    static void Save(string[] entries)
    {
        WriteLine("What is the name of the file you want to save to?");
        var fileName = ReadLine();
        File.WriteAllLines(fileName, entries);
    }

    static string[] Load()
    {
        WriteLine("what is the name of the file You wanna Load?");
        var fileName = ReadLine();
        return File.ReadAllLines(fileName);
    }

    static void WaitForKey()
    {
        ForegroundColor = ConsoleColor.DarkGray;
        WriteLine("\n_Press any key..._");
        ReadKey(true);
        ForegroundColor = ConsoleColor.White;
        Clear();
    }
    static void Art()
    {
        WriteLine(@"      
      ______ ______
    _/      Y      \_
   // ~~ ~~ | ~~ ~  \\
  // ~ ~ ~~ | ~~~ ~~ \\      
 //________.|.________\\     
`----------`-'----------'");
    }
    static void Outro()
    {
        WriteLine("\nThanks, for using the Journal App\n");
        ForegroundColor = ConsoleColor.Red;
        WriteLine("Art by \nhttps://www.asciiart.eu/books/books @\n\tOriginal Unknown\n\tDiddled by David Issel");
    }
}