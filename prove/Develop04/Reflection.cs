using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
public class Reflection : Activity
{
    private readonly List<string> _prompts = new List<string>()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private readonly List<string> _questions = new List<string>()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public Reflection() : base("Reflection Activity",
        "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    { }
    public override void RunActivity()
    {
        Console.WriteLine();
        string prompt = PickRandom(_prompts);
        Console.WriteLine("Prompt:");
        Console.WriteLine($"> {prompt}");
        Console.WriteLine();

        var sw = Stopwatch.StartNew();
        Console.WriteLine("Consider the prompt. You'll be asked reflection questions. Take your time to think.");
        ShowSpinner(4);

        var rnd = new Random();
        var questionPool = _questions.OrderBy(x => rnd.Next()).ToList();
        int qIndex = 0;

        while (sw.Elapsed.TotalSeconds < DurationSeconds)
        {
            string question = questionPool[qIndex % questionPool.Count];
            Console.WriteLine();
            Console.WriteLine("Reflection question:");
            Console.WriteLine($"> {question}");
            int pauseSeconds = ComputeChunkOrRemaining((int)sw.Elapsed.TotalSeconds, 6);
            ShowSpinner(pauseSeconds);
            qIndex++;
        }
    }
    private int ComputeChunkOrRemaining(int elapsed, int chunk)
    {
        int remaining = DurationSeconds - elapsed;
        return Math.Max(1, Math.Min(chunk, remaining));
    }
}
