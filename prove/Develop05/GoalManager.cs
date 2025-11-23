using System;
using System.Collections.Generic;
using System.IO;

class GoalManager
{
    private List<Goal> goals = new List<Goal>();
    private int level = 1;
    private int xp = 0;
    public void Run()
    {
        bool running = true;

        while (running)
        {
            Console.Clear();
            Console.WriteLine("==== Eternal Quest ====");
            Console.WriteLine($"Level: {level}    XP: {xp}/{level * 1000}");
            Console.WriteLine();
            Console.WriteLine("1. New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Load");
            Console.WriteLine("0. Quit");
            Console.Write("Choice: ");

            switch (Console.ReadLine())
            {
                case "1": NewGoal(); break;
                case "2": ListGoals(); break;
                case "3": Record(); break;
                case "4": Save(); break;
                case "5": Load(); break;
                case "0": running = false; break;
            }
        }
    }
    private void NewGoal()
    {
        Console.Clear();
        Console.WriteLine("Choose Goal Type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Type: ");
        string type = Console.ReadLine();

        Console.Write("Name: ");
        string n = Console.ReadLine();
        Console.Write("Description: ");
        string d = Console.ReadLine();
        Console.Write("Points: ");
        int p = int.Parse(Console.ReadLine());

        if (type == "1")
        {
            goals.Add(new SimpleGoal(n, d, p));
        }
        else if (type == "2")
        {
            goals.Add(new EternalGoal(n, d, p));
        }
        else if (type == "3")
        {
            Console.Write("Target count: ");
            int t = int.Parse(Console.ReadLine());
            Console.Write("Bonus: ");
            int b = int.Parse(Console.ReadLine());

            goals.Add(new ChecklistGoal(n, d, p, t, b));
        }
    }
    private void ListGoals()
    {
        Console.Clear();
        if (goals.Count == 0)
        {
            Console.WriteLine("No goals yet.");
            Console.ReadLine();
            return;
        }

        Console.WriteLine("==== Your Goals ====");
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].Display()}");
        }
        Console.ReadLine();
    }
    private void Record()
    {
        Console.Clear();
        if (goals.Count == 0)
        {
            Console.WriteLine("No goals to record.");
            Console.ReadLine();
            return;
        }

        ListGoals();
        Console.Write("Which goal number did you complete? ");
        int choice = int.Parse(Console.ReadLine());

        if (choice < 1 || choice > goals.Count)
        {
            Console.WriteLine("Invalid choice.");
            Console.ReadLine();
            return;
        }

        int earned = goals[choice - 1].RecordEvent();
        xp += earned;

        Console.WriteLine($"You earned {earned} XP!");
        CheckLevelUp();

        Console.ReadLine();
    }
    private void CheckLevelUp()
    {
        int xpNeeded = level * 1000;

        while (xp >= xpNeeded)
        {
            xp -= xpNeeded;
            level++;

            Console.WriteLine();
            Console.WriteLine("***********************************");
            Console.WriteLine($"🎉 LEVEL UP! You are now Level {level}!");
            Console.WriteLine("***********************************");
            Console.WriteLine();

            xpNeeded = level * 1000;
        }
    }
    private void Save()
    {
        using (StreamWriter sw = new StreamWriter("goals.txt"))
        {
            sw.WriteLine(level);
            sw.WriteLine(xp);

            foreach (Goal g in goals)
            {
                sw.WriteLine(g.SaveString());
            }
        }
        Console.WriteLine("Progress Saved!");
        Console.ReadLine();
    }
    private void Load()
    {
        if (!File.Exists("goals.txt"))
        {
            Console.WriteLine("No save file found.");
            Console.ReadLine();
            return;
        }

        goals.Clear();
        string[] lines = File.ReadAllLines("goals.txt");
        level = int.Parse(lines[0]);
        xp = int.Parse(lines[1]);

        for (int i = 2; i < lines.Length; i++)
        {
            string[] p = lines[i].Split('|');
            string type = p[0];

            if (type == "Simple")
            {
                SimpleGoal s = new SimpleGoal(p[1], p[2], int.Parse(p[3]));
                s.IsComplete = bool.Parse(p[4]);
                goals.Add(s);
            }
            else if (type == "Eternal")
            {
                EternalGoal eg = new EternalGoal(p[1], p[2], int.Parse(p[3]));
                goals.Add(eg);
            }
            else if (type == "Checklist")
            {
                ChecklistGoal cg = new ChecklistGoal(
                    p[1],
                    p[2],
                    int.Parse(p[3]),
                    int.Parse(p[5]),
                    int.Parse(p[7]),
                    int.Parse(p[6])
                );

                cg.IsComplete = bool.Parse(p[4]);
                goals.Add(cg);
            }
        }
        Console.WriteLine("Progress Loaded!");
        Console.ReadLine();
    }
}
