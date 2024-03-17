using System.IO;
using static System.Console;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Run();
    }

    static List<Goal> goal = new List<Goal>();
    static int currentPoints = 0;



    static int Menu()
    {
        WriteLine($"\nYou have {currentPoints} points\n");

        WriteLine("Menu Options");
        WriteLine("\t1. Create New Goal");
        WriteLine("\t2. List Goals");
        WriteLine("\t3. Save Goals");
        WriteLine("\t4. Load Goals");
        WriteLine("\t5. Record Event");
        WriteLine("\t6. Quit");
        Write("Select a choice from the menu: ");
        int choice = int.Parse(ReadLine());

        return choice;
    }

    static void Run()
    {
        bool validChoice = true;
        int choice;
        while (validChoice)
        {
            choice = Menu();
            if (choice == 1 || choice == 2 || choice == 3 || choice == 4 || choice == 5 || choice == 6)
            {
                switch (choice)
                {
                    case 1:
                        Clear();
                        CreateGoal();
                        break;
                    case 2:
                        Clear();
                        ListGoals();
                        Thread.Sleep(2000);
                        break;
                    case 3:
                        SaveGoals();
                        Clear();
                        break;
                    case 4:
                        ExtractGoals();
                        Clear();
                        break;
                    case 5:
                        Clear();
                        RecordGoal();
                        break;
                    case 6:
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

    static void CreateGoal()
    {
        bool validChoice = true;
        int choice;
        while (validChoice)
        {
            choice = ShowGoals();
            if (choice == 1 || choice == 2 || choice == 3)
            {
                switch (choice)
                {
                    case 1:
                        SimpleGoal simpleGoal = new();
                        simpleGoal.SetType();
                        simpleGoal.RunGoal();
                        goal.Add(simpleGoal);
                        validChoice = false;
                        break;
                    case 2:
                        EternalGoal eternalGoal = new();
                        eternalGoal.SetType();
                        eternalGoal.RunGoal();
                        goal.Add(eternalGoal);
                        validChoice = false;
                        break;
                    case 3:
                        ChecklistGoal checklistGoal = new();
                        checklistGoal.SetType();
                        checklistGoal.RunGoal();
                        goal.Add(checklistGoal);
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

        static int ShowGoals()
        {
            {
                WriteLine("The types of goals are: ");
                WriteLine("\t1. Simple Goal");
                WriteLine("\t2. Eternal Goal");
                WriteLine("\t3. Checklist Goal");

                Write("Which type of goal would you like to create? ");
                int choice = int.Parse(ReadLine());

                return choice;
            }
        }
    }

    static void ListGoals()
    {
        WriteLine("The Goals are: ");
        int count = 1;
        foreach (Goal g in goal)
        {
            WriteLine($"{count}. {g.DisplayGoal()}");
            count++;
        }
    }

    static void SaveGoals()
    {
        Write("What is the filename fot the goal file? ");
        string filename = ReadLine();

        var goals = new List<string>
       {
           $"Total points: {currentPoints}"
       };
        foreach (Goal g in goal)
            goals.Add($"{g.SaveGoal()}");

        File.WriteAllLines(filename, goals.ToArray());
    }

    static string[] LoadGoals()
    {
        Write("What is the name of the file that you wanna load from? ");
        var filename = ReadLine();
        try
        {

            return File.ReadAllLines(filename);
        }
        catch (FileNotFoundException)
        {
            WriteLine($"\n\n****{filename} not found****");
            return new string[0];
        }
    }

    static void ExtractGoals()
    {
        goal.Clear();
        string[] goalsArray = LoadGoals();
        foreach (var line in goalsArray)
        {
            if (line.StartsWith("Total points:"))
            {
                string points = line.Split(':')[1].Trim();
                currentPoints = int.Parse(points);
            }
            else if (line.StartsWith("SimpleGoal"))
            {
                string[] parts = line.Split('|');
                SimpleGoal simpleGoal = new(parts);
                goal.Add(simpleGoal);

            }
            else if (line.StartsWith("EternalGoal"))
            {
                string[] parts = line.Split('|');
                EternalGoal eternalGoal = new(parts);
                goal.Add(eternalGoal);

            }
            else if (line.StartsWith("ChecklistGoal"))
            {
                string[] parts = line.Split('|');
                ChecklistGoal checklistGoal = new(parts);
                goal.Add(checklistGoal);

            }
        }
    }

    static void RecordGoal()
    {
        ShowGoalNames();
        Write("Which goal did you accomplish? ");
        int goalId = int.Parse(ReadLine());
        if (goalId > 0 && goalId <= goal.Count)
        {
            Goal selectedGoal = goal[goalId - 1];
            if (selectedGoal.check == ' ')
            {
                WriteLine("Congratulations!!");
                WriteLine($"You have earned {selectedGoal.GetPoints()} points!");

                currentPoints += selectedGoal.GetPoints();
                WriteLine($"You now have {currentPoints} points!");

                if (selectedGoal.GetGoalType() == "SimpleGoal")
                    selectedGoal.check = '\u2713';
                else if (selectedGoal is ChecklistGoal checklistGoal)
                {
                    if (checklistGoal.CheckIfAccomplished())
                    {
                        selectedGoal.check = '\u2713';
                        currentPoints += checklistGoal.GetBonus();
                        WriteLine($"You have received a bonus of {checklistGoal.GetBonus()}");
                    }
                    else
                        selectedGoal.check = ' ';
                }
            }
            else if (selectedGoal.check == '\u2713')
            {
                WriteLine("You have already completed this goal");
            }

        }
        else
        {
            WriteLine("Invalid goal ID.");
        }
    }
    static void ShowGoalNames()
    {
        WriteLine("The Goals are: ");
        int count = 1;
        foreach (Goal g in goal)
        {
            WriteLine($"{count}. {g.GetName()}");
            count++;
        }
    }
}
