using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
public abstract class Activity
{
    private string _name;
    private string _description;
    private int _durationSeconds;
    protected string Name => _name;
    protected string Description => _description;
    protected int DurationSeconds => _durationSeconds;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }
    public void StartActivity()
    {
        Console.Clear();
        ShowStartingMessage();
        _durationSeconds = PromptForDuration();
        Console.WriteLine("\nGet ready...");
        ShowSpinner(3);
        Console.WriteLine();
        RunActivity();
        ShowEndingMessage();
    }
    public abstract void RunActivity();
    public void ShowStartingMessage()
    {
        Console.WriteLine($"--- {Name} ---");
        Console.WriteLine();
        Console.WriteLine(Description);
        Console.WriteLine();
    }
    public int PromptForDuration()
    {
        while (true)
        {
            Console.Write("Enter duration in seconds for this activity: ");
            var input = Console.ReadLine();
            if (int.TryParse(input, out int seconds) && seconds > 0)
            {
                return seconds;
            }
            Console.WriteLine("Please enter a positive integer for seconds.");
        }
    }
    public void ShowEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!");
        ShowSpinner(2);
        Console.WriteLine($"You have completed the {Name} for {DurationSeconds} seconds.");
        ShowSpinner(3);
        Console.WriteLine("Press Enter to return to the menu.");
        Console.ReadLine();
    }
    protected void ShowSpinner(int seconds)
    {
        var spinner = new[] { "|", "/", "-", "\\" };
        var sw = Stopwatch.StartNew();
        int idx = 0;
        while (sw.Elapsed.TotalSeconds < seconds)
        {
            Console.Write($"\r{spinner[idx % spinner.Length]} ");
            idx++;
            Thread.Sleep(200);
        }
        Console.Write("\r  \r");
    }
    protected void ShowCountdown(int seconds)
    {
        for (int i = seconds; i >= 1; i--)
        {
            Console.Write($"\r{i} ");
            Thread.Sleep(1000);
        }
        Console.Write("\r   \r");
    }
    protected string PickRandom(IList<string> list)
    {
        if (list == null || list.Count == 0) return "";
        var rnd = new Random();
        return list[rnd.Next(list.Count)];
    }
}