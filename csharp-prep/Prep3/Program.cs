using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magic_number = randomGenerator.Next(1, 101);
        int guess = -1;

        while (guess != magic_number)
        {
            Console.WriteLine("Guess the magic number");
            string input = Console.ReadLine();
            guess = int.Parse(input);
            
            if (guess < magic_number)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > magic_number)
            {
                Console.WriteLine("Lower");
            }
        }

        Console.WriteLine("You guessed it!");

    }
}