using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string name = PromptUserName();
        int number = PromptUserNumber();

        int square = SquareNumber(number);

        int year;
        PromptUserBirthYear(out year);

        DisplayResult(name, square, year);
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }
    static string PromptUserName()
    {
        Console.WriteLine("What is your name?");
        string name = Console.ReadLine();
        return name;
    }
    static int PromptUserNumber()
    {
        Console.WriteLine("What is your favorite number?");
        string input = Console.ReadLine();
        int favorite_number = int.Parse(input);
        return favorite_number;
    }
    static void PromptUserBirthYear(out int year)
    {
        Console.WriteLine("What is your birth year?");
        year = int.Parse(Console.ReadLine());
    }
    static int SquareNumber(int favorite_number)
    {
        int square = favorite_number * favorite_number;
        return square;
    }
    static void DisplayResult(string name, int square, int year)
    {
        Console.WriteLine($"{name}, the square of your number is {square}.");
        Console.WriteLine($"{name}, you will turn {2025 - year} years old this year.");
    }
}
