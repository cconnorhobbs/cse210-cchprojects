using System;
using System.Collections.Generic;
using System.Diagnostics;

public class Visualization : Activity
{
    private readonly List<string> _scenes = new List<string>()
    {
        "Imagine a calm beach with gentle waves lapping the shore.",
        "Picture yourself walking through a quiet forest, hearing birds chirp.",
        "Visualize a mountain peak with clear skies above.",
        "Imagine a cozy cabin with a warm fire inside.",
        "Picture yourself achieving a personal goal with pride and happiness."
    };

    public Visualization() : base("Visualization Activity",
        "This activity will help you relax and focus by guiding you to visualize calming scenes and positive outcomes.")
    { }

    public override void RunActivity()
    {
        Console.WriteLine();
        var sw = Stopwatch.StartNew();
        Console.WriteLine("Focus on the visualization prompts below. Breathe slowly and imagine each scene.");
        ShowSpinner(3);

        int sceneIndex = 0;
        while (sw.Elapsed.TotalSeconds < DurationSeconds)
        {
            string scene = _scenes[sceneIndex % _scenes.Count];
            Console.WriteLine();
            Console.WriteLine("Visualize:");
            Console.WriteLine($"> {scene}");

            int pauseSeconds = Math.Max(1, Math.Min(6, DurationSeconds - (int)sw.Elapsed.TotalSeconds));
            ShowSpinner(pauseSeconds);

            sceneIndex++;
        }
    }
}
