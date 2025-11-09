using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
public class Breathing : Activity
{
    private string _breathInMsg = "Breathe in...";
    private string _breathOutMsg = "Breathe out...";
    private int _inhaleSeconds = 4;
    private int _exhaleSeconds = 4;

    public Breathing() : base("Breathing Activity",
        "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }
    public override void RunActivity()
    {
        var sw = Stopwatch.StartNew();
        Console.WriteLine();
        while (sw.Elapsed.TotalSeconds < DurationSeconds)
        {
            Console.WriteLine();
            Console.WriteLine(_breathInMsg);
            int remain = SecondsLeftOrChunk((int)sw.Elapsed.TotalSeconds, _inhaleSeconds);
            ShowCountdown(remain);
            if (sw.Elapsed.TotalSeconds >= DurationSeconds) break;

            Console.WriteLine();
            Console.WriteLine(_breathOutMsg);
            remain = SecondsLeftOrChunk((int)sw.Elapsed.TotalSeconds, _exhaleSeconds);
            ShowCountdown(remain);
        }
    }
    private int SecondsLeftOrChunk(int elapsed, int chunk)
    {
        int remaining = DurationSeconds - elapsed;
        return Math.Max(1, Math.Min(chunk, remaining));
    }
}