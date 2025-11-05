using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        DisplayMenu();
        string input = GetUserInput();
    }
    
    public static void DisplayMenu()
    {
        Console.WriteLine("Menu Options: ");
        Console.WriteLine("1. Start Breathing Activity");
        Console.WriteLine("2. Start Reflection Activity");
        Console.WriteLine("3. Start Listing Activity");
        Console.WriteLine("4. Quit");
    }

    public static string GetUserInput()
    {
        Console.Write("Select your choice: ");
        return Console.ReadLine();
    }
}