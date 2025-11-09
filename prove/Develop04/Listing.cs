using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
public class Listing : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    private List<string> _userResponses = new List<string>();

    public Listing() : base("Listing Activity",
        "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    { }

    public override void RunActivity()
    {
        Console.WriteLine();
        string prompt = PickRandom(_prompts);
        Console.WriteLine("Listing prompt:");
        Console.WriteLine($"> {prompt}");
        Console.WriteLine();
        Console.WriteLine("You will have a few seconds to think, then list as many items as you can. Press Enter after each item.");
        ShowCountdown(5);

        Console.WriteLine("\nStart listing now:");

        var sw = Stopwatch.StartNew();

        while (sw.Elapsed.TotalSeconds < DurationSeconds)
        {
            int remainingMs = (int)((DurationSeconds - sw.Elapsed.TotalSeconds) * 1000);
            if (remainingMs <= 0) break;

            var task = Task.Run(() => Console.ReadLine());
            bool completed = task.Wait(remainingMs);
            if (completed)
            {
                var response = task.Result;
                if (!string.IsNullOrWhiteSpace(response))
                {
                    _userResponses.Add(response.Trim());
                }
            }
            else
            {
                break;
            }
        }

        Console.WriteLine();
        Console.WriteLine($"You listed {_userResponses.Count} item(s).");
        if (_userResponses.Count > 0)
        {
            Console.WriteLine("Your items:");
            int i = 1;
            foreach (var item in _userResponses)
            {
                Console.WriteLine($"{i++}. {item}");
            }
        }
        _userResponses.Clear();
    }
}
