using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment math1 = new MathAssignment("Connor Hobbs", "Fractions", "8", "1-10");
        Console.WriteLine(math1.GetSummary());
        Console.WriteLine(math1.GetHomeworkList());

        WritingAssignment w1 = new WritingAssignment("Connor Hobbs", "European History", "The Invention of the Crossiant");
        Console.WriteLine(w1.GetSummary());
         Console.WriteLine(w1.GetWritingInformation());
    }
}